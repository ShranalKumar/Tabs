using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Tabs
{
    class AzureManager
    {
        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<shranalNotHotdogModel> shranalNotHotdogTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://shranalnothotdog.azurewebsites.net");
            this.shranalNotHotdogTable = this.client.GetTable<shranalNotHotdogModel>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        public async Task<List<shranalNotHotdogModel>> GetHotDogInformation()
        {
            return await this.shranalNotHotdogTable.ToListAsync();
        }
    }
}
