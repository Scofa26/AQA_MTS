using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestRailComplexApi.Models
{
    public class Project
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string? Name { get; init; }
        [JsonPropertyName("announcement")] public string? Announcement { get; init; }
        [JsonPropertyName("show_announcement")] public bool ShowAnnouncement { get; set; }
        [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
        [JsonPropertyName("completed_on")] public string? CompletedOn { get; set; }
        [JsonPropertyName("suite_mode")] public int SuiteMode { get; set; }
        [JsonPropertyName("default_role_id")] public string? DefaultRoleId { get; set; }
        [JsonPropertyName("url")] public string? Url { get; set; }
        [JsonPropertyName("users")] public List<User> Users { get; set; } = new();
        [JsonPropertyName("groups")] public List<Groups> Groups { get; set; } = new();
    }
}
