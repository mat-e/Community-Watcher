using MunicipalServicesApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Watcher.Models
{
    public static class DataStore
    {
        private static bool loaded = false;

        public static EventManager Manager { get; } = new EventManager();

        public static Event LastAdded { get; set; }

        public static void EnsureLoaded()
        {
            if (loaded)
                return;

            Manager.LoadEvents(EventSeeder.GetSampleEvents());
            loaded = true;
        }
    }
}
