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
            var listRequest = customSearchService.Cse.List();
            listRequest.Cx = searchEngineId;
            listRequest.ImgSize = Google.Apis.Customsearch.v1.CseResource.ListRequest.ImgSizeEnum.XXLARGE;
            listRequest.SearchType = Google.Apis.Customsearch.v1.CseResource.ListRequest.SearchTypeEnum.Image;
            listRequest.Safe = Google.Apis.Customsearch.v1.CseResource.ListRequest.SafeEnum.Off;
            listRequest.Q = query;

            List<Google.Apis.Customsearch.v1.Data.Result> paging = new List<Google.Apis.Customsearch.v1.Data.Result>();
            
            try
            {
                paging = listRequest.Execute().Items.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }

            return paging;

        }
    }
}
