using System.Text.Json.Serialization;

namespace Webhook.Models;

public class PixModel
{
    [JsonPropertyName("endToEndId")]
    public string EndToEndId { get; set; } = null!;

    [JsonPropertyName("txid")]
    public string Txid { get; set; } = null!;

    [JsonPropertyName("valor")]
    public string Valor { get; set; } = null!;

    [JsonPropertyName("chave")]
    public string Chave { get; set; } = null!;

    [JsonPropertyName("horario")]
    public string Horario { get; set; } = null!;

    [JsonPropertyName("infoPagador")]
    public string InfoPagador { get; set; } = null!;
}
