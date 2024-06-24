namespace Bridge.Sanatorium.Models;

public class PostingRequest
{
    public Dictionary<string, string> Headers { get; set; }

    public PostTransactionsRequest PostTransactionsRequest { get; set; }
}
