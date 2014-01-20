using System.Threading;

using Excel = NetOffice.ExcelApi;
using Access = NetOffice.AccessApi;

namespace AccessRefresher
{
    class RefreshObject
    {
        private Timer _refreshtimer;
        private int _refreshInterval;

        private string _fromDbFile;
        private string _toExcelFile;

        private Access.Application _fromDb;
        private Excel.Application _toExcel;

        public RefreshObject(string dbFile, string excelFile, int refreshInterval)
        {
            _fromDbFile = dbFile;
            _toExcelFile = excelFile;
            _refreshInterval = refreshInterval;

            OnRefresh();
        }

        private void OnRefresh()
        {
            DoRefresh();
            SetTimer();
        }

        private void SetTimer()
        {
            _refreshtimer = new Timer(OnTimer, null, _refreshInterval, Timeout.Infinite);
        }

        private void OnTimer(object state)
        {
            OnRefresh();
        }

        private void DoRefresh()
        {
            using (_fromDb = new NetOffice.AccessApi.Application(_fromDbFile))
            {
                using (_toExcel = new NetOffice.ExcelApi.Application(_toExcel))
                {
                    
                }
            }
        }
    }
}
