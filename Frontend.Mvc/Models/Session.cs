namespace Frontend.Mvc.Models;

public record Session
{
    public string? Title { get; set; }

    public string? Duration { get; set; }

    public string? Speaker { get; set; }
}
