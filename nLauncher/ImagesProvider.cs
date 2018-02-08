using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLauncher
{
    public static class ImagesProvider
    {
        public static List<Google.Apis.Customsearch.v1.Data.Result> googleSearch(string query)
        {
            const string apiKey = "AIzaSyALPsRIcFB8dc9SbsaaA-f1gRNG3gZtxV4";
            const string searchEngineId = "015210785414118161171:eaqkejpiflg";

            var customSearchService = new Google.Apis.Customsearch.v1.CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer { ApiKey = apiKey });
            var listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = searchEngineId;
            listRequest.ImgSize = Google.Apis.Customsearch.v1.CseResource.ListRequest.ImgSizeEnum.Large;
            listRequest.SearchType = Google.Apis.Customsearch.v1.CseResource.ListRequest.SearchTypeEnum.Image;
            listRequest.Safe = Google.Apis.Customsearch.v1.CseResource.ListRequest.SafeEnum.Off;

            //IList<Google.Apis.Customsearch.v1.Data.Result> paging = new List<Google.Apis.Customsearch.v1.Data.Result>();
            List<Google.Apis.Customsearch.v1.Data.Result> paging = new List<Google.Apis.Customsearch.v1.Data.Result>();
            var count = 0;

            paging = listRequest.Execute().Items.ToList();
            return paging;

            while (paging != null)
            {
                listRequest.Start = count * 10 + 1;
                paging = listRequest.Execute().Items.ToList();

                
                if (paging != null)
                    foreach (var item in paging)
                    {
                        //searchWindow.AddSearchWindowEntry(item.Link);
                    }
                count++;

                if (count >= 2) { break; }
            }
        }
    }
}
