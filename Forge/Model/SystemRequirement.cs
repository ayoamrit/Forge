namespace Forge.Model
{
    public class SystemRequirement
    {
        public int RequirementID { get; set; }
        public int GameID { get; set; }
        public string MinimumOS { get; set; }
        public string MinimumProcessor { get; set; }
        public string MinimumMemory { get; set; }
        public string MinimumStorage { get; set; }
        public string MinimumGraphics { get; set; }
        public string RecommendedOS { get; set; }
        public string RecommendedProcessor { get; set; }
        public string RecommendedMemory { get; set; }
        public string RecommendedStorage { get; set; }
        public string RecommendedGraphics { get; set; }
        public string AdditionalNotes { get; set; }

        public Game Game { get; set; }
    }
}
