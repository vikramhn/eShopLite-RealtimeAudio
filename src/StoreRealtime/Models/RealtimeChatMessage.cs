using StoreRealtime.ContextManagers;

namespace StoreRealtime.Models;

public class RealtimeChatMessage
{    public string Message { get; set; } = string.Empty;
    public bool IsUser { get; set; } = false;
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
