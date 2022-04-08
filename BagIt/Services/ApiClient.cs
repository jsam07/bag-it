using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagIt.Services
{
    class ApiClient
    {
        public HttpClient CreateClient()
        {
            #if __ANDROID__
                        return new HttpClient(new Xamarin.Android.Net.AndroidMessageHandler());
            #else
              return new HttpClient();
            #endif
        }
    }
}
