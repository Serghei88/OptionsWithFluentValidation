namespace WebApi.Model;

public class SlackApiSettings
{
    public string? WebhookUrl { get; set; }
    public string? DisplayName { get; set; }
    public bool ShouldNotify { get; set; }
}