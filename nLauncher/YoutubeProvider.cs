using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace nLauncher
{
    class YoutubeProvider
    {

        public async Task Run(string searchTerm)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyD4vo8oH5g7eb-A7iHDK02nreOzOaZaEYE",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = searchTerm; // Replace with your search term.
            searchListRequest.MaxResults = 5;
            searchListRequest.Type = "video";
            searchListRequest.VideoEmbeddable = SearchResource.ListRequest.VideoEmbeddableEnum.True__;

            // Call the search.list method to retrieve results matching the specified query term.
            try
            {
                var searchListResponse = await searchListRequest.ExecuteAsync();


                List<string> videos = new List<string>();
                List<string> channels = new List<string>();
                List<string> playlists = new List<string>();

                // Add each result to the appropriate list, and then display the lists of
                // matching videos, channels, and playlists.
                foreach (var searchResult in searchListResponse.Items)
                {
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                            break;

                        case "youtube#channel":
                            channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                            break;

                        case "youtube#playlist":
                            playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                            break;
                    }
                }

                Console.WriteLine(String.Format("Videos:\n{0}\n", string.Join("\n", videos)));
                Console.WriteLine(String.Format("Channels:\n{0}\n", string.Join("\n", channels)));
                Console.WriteLine(String.Format("Playlists:\n{0}\n", string.Join("\n", playlists)));

                (Application.OpenForms["Form1"] as Form1).setVideo(searchListResponse.Items[0]);

            }
            catch (Exception ex)
            {
                ex = ex;
            }
        }

    }
}

