
using System.Configuration;

namespace GenshinLyreMidiPlayer.Data.Properties
{
    public class Settings : ApplicationSettingsBase
    {
        private static Settings? defaultInstance;

        public static Settings Default
        {
            get
            {
                return defaultInstance ??= (Settings)Synchronized(new Settings());
            }
        }

        public bool AllowBackgroundPlayback { get; set; } = false;
        
        public bool HoldNotes { get; set; } = false;
        
        public bool MergeNotes { get; set; } = false;
        
        public bool TransposeNotes { get; set; } = true;
        
        public bool UseSpeakers { get; set; } = false;
    }
}
