using GitHub_Api;
using System.Net.Http.Json;


internal class Program
{
    private static async Task Main(string[] args)
    {
        PrintText.Green("Enter Username:");
        string username = Console.ReadLine();
        string apiUrl = $"https://api.github.com/users/{username}/events";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "C# HttpClient");
        try
        {
            var events = await client.GetFromJsonAsync<GitHubEvent[]>(apiUrl);
            bool isNull = events.Any();
            if (isNull)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nLast events for {username}:");
                Console.ResetColor();
                int i = 1;
                foreach (var ev in events)
                {
                    Console.WriteLine($"{i}- Type: {ev.type}, Repo: {ev.repo?.name}, Created at: {ev.created_at}");
                    i = i + 1;
                }
            }
            else
            {
                PrintText.Red("There Was No Record For The Current Username.");
            }
        }
        catch (HttpRequestException ex)
        {
            string statusCode = (ex.StatusCode).ToString();

            if (statusCode == "NotFound")
                PrintText.Red("Error: User Not Found");

            else
                throw ex;
        }
    }
}

public class GitHubEvent
{
    public string type { get; set; }
    public DateTime created_at { get; set; }
    public Repo repo { get; set; }
}

public class Repo
{
    public string name { get; set; }
}
