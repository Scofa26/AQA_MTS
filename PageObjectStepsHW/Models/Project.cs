using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Models
{
    internal class Project
    {
       [JsonPropertyName("id")] public int Id { get; set; } 
       [JsonPropertyName("name")] public string Name { get; set; } 
       [JsonPropertyName("announcement")] public string Announcement { get; set; } 
       [JsonPropertyName("show_announcement")] public bool IsShowAnnouncement { get; set; } 
       [JsonPropertyName("suite_mode")] public int SuiteMode { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}:{Id}, {nameof(Name)}:{Name}, {nameof(Name)}:{Name}, {nameof(Announcement)}:{Announcement},"+
                $" {nameof(IsShowAnnouncement)}:{IsShowAnnouncement}, {nameof(SuiteMode)}:{SuiteMode}";
        }


        public override bool Equals(object? obj)
        {
            return obj is Project project &&
                   Id == project.Id &&
                   Name == project.Name &&
                   Announcement == project.Announcement &&
                   IsShowAnnouncement == project.IsShowAnnouncement &&
                   SuiteMode == project.SuiteMode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Announcement, IsShowAnnouncement, SuiteMode);
        }
    }
}
