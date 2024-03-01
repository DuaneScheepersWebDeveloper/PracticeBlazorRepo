namespace TestingDynamicEditableTable.Data.GridData
{
    public class YoutubeAnalytics
    {
        public bool IsSubscribed { get; set; } = false;
        public int WatchTimeHours { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;

        private bool IsFemaleSubscriber = false;

        public bool IsFemale
        {
            get { return false; }
            set { IsFemaleSubscriber = value; }
        }

    }
}
