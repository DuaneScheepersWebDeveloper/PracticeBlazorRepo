

using Microsoft.AspNetCore.Components;
using TestingDynamicEditableTable.Data.GridData;

namespace TestingDynamicEditableTable.Pages
{
    public partial class DynamicDataGrid
    {
        [Inject]
        private IYoutubeAnalyticsData? YoutubeData { get; set; }
        [Inject]
        private ICarData? CarData { get; set; }

        private List<YoutubeAnalytics>? YoutubeAnalyticsList { get; set; }
        private List<Car>? CarList { get; set; }

        protected override void OnInitialized()
        {
            YoutubeAnalyticsList = YoutubeData.GetYoutubeData();
            CarList = CarData.GetCarList();
        }

    }
}
