
namespace TestingDynamicEditableTable.Data.GridData
{
    public class YoutubeData : IYoutubeAnalyticsData
    {
        public List<YoutubeAnalytics> GetYoutubeData()
        {
            Random r = new Random();
            List<YoutubeAnalytics> youtubeList = new List<YoutubeAnalytics>();

            youtubeList.Add(new YoutubeAnalytics()
            {
                IsSubscribed = true,
                WatchTimeHours = r.Next(100, 300),
                UserName = "NearPerfectUser",
                UserEmail = "Best@gmail.com",
                IsFemale = false
            });

            youtubeList.Add(new YoutubeAnalytics()
            {
                IsSubscribed = false,
                WatchTimeHours = r.Next(0, 50),
                UserName = "Newbie",
                UserEmail = "newguy@gmail.com",
                IsFemale = false
            });

            youtubeList.Add(new YoutubeAnalytics()
            {
                IsSubscribed = true,
                WatchTimeHours = r.Next(1000, 5000),
                UserName = "FemaleTechEnthusiast",
                UserEmail = "SuzyDoo@gmail.com",
                IsFemale = true
            });

            youtubeList.Add(new YoutubeAnalytics()
            {
                IsSubscribed = false,
                WatchTimeHours = r.Next(0, 5),
                UserName = "Reality",
                UserEmail = "",
                IsFemale = false
            });
            return youtubeList;



        }
    }
}
