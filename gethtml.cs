public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("What website should we gather? ");
        string url = Console.ReadLine() ?? "";
        Website website = new(url);
        Console.WriteLine(await website.getHtml());
    }
}

public class Website
{
    public static readonly HttpClient _client = new();
    public string Url { get; set; }
    public Website(string Url)
    {
        this.Url = Url;
    }
    public async Task<string> getHtml()
    {
        try
        {
            string content = await _client.GetStringAsync(Url);
            return content;
        }
        catch(Exception)
        {
            return "Input absolute URI";
        }
    }
}
