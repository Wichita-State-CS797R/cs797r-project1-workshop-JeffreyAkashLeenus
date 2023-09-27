namespace MonkeyFinder.Services;

public class MonkeyService
{
    List<Monkey> monkeyList = new();
    HttpClient httpClient;
    public MonkeyService()
    {
        this.httpClient = new HttpClient();
    }

    public async Task<List<Monkey>> GetMonkeys()
    {
        
            return monkeyList;
    }
}
