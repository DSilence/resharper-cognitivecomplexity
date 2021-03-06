using JetBrains.Application.Settings;
using JetBrains.ReSharper.Resources.Settings;

namespace ReSharperPlugin.CognitiveComplexity.Options
{
    [SettingsKey(typeof (CodeInspectionSettings), "Cognitive complexity analysis")]
    public class CognitiveComplexityAnalysisSettings
    {
        public const int DefaultThreshold = 10;

        [SettingsEntry(80, "Mildly complex")]
        public int LowComplexityThreshold { get; set; }
        
        [SettingsEntry(100, "Very complex")]
        public int MiddleComplexityThreshold { get; set; }
        
        [SettingsEntry(150, "Refactor me?")]
        public int HighComplexityThreshold { get; set; }

        [SettingsEntry(DefaultThreshold, "CSharp Threshold")]
        public int CSharpThreshold;
    }
}