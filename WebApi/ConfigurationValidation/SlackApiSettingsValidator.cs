using FluentValidation;

namespace WebApi.Model;

public class SlackApiSettingsValidator : AbstractValidator<SlackApiSettings>
{
    public SlackApiSettingsValidator()
    {
        RuleFor(x => x.DisplayName).NotEmpty();
        RuleFor(x => x.WebhookUrl)
            .NotEmpty()
            .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
            .When(x => !string.IsNullOrEmpty(x.WebhookUrl));
    }
}