using System.Text.Json.Serialization;

namespace Webhook.Models;

public class NotificacaoPixModel
{
    [JsonPropertyName("pix")]
    public List<PixModel> Pix { get; set; } = null!;
}
