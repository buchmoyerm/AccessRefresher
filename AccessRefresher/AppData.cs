using System.Collections.Generic;

namespace AccessRefresher
{
    class AppData
    {
        private static AppData _instance;
        public static AppData Instance
        {
            get { return _instance ?? (_instance = new AppData()); }
        }

        private Dictionary<string, RefreshObject> _refreshObjects = new Dictionary<string, RefreshObject>();

        public void AddRefreshObject(RefreshObject obj)
        {
            lock(_refreshObjects)
                _refreshObjects[obj.Name] = obj;
        }

        public bool IsNameUsed(string name)
        {
            lock (_refreshObjects)
                return _refreshObjects.ContainsKey(name);
        }

        public void RemoveObject(string name)
        {
            lock (_refreshObjects)
                _refreshObjects.Remove(name);
        }
    }
}