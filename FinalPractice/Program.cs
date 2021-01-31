using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace FinalPractice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string siteUrl = "https://youtu.be";
            string resourceID = "/YCaGYUIfdy4";




            var youtube = new YoutubeClient();
            
           var task =  youtube.Videos.DownloadAsync("https://www.youtube.com/watch?v=A11m-vMf24o", "vid.avi");

           task.Wait();
           
           // var result = await videoInfos.Videos.GetAsync(new VideoId("YCaGYUIfdy4"));

           //   result.
           //.GetVideosAsync("rick");


           //  Console.WriteLine();






           // запрос выгрузки информации с сайта 
           // await LoadSite(siteUrl, resourceID);
        }

        static async Task LoadSite( string siteUrl, string resourceId )
        {
            var httpClient = new HttpClient();
            
            httpClient.BaseAddress = new Uri(siteUrl);
            
            var result = await httpClient.GetAsync(resourceId);

            var cntnt = await result.Content.ReadAsByteArrayAsync();
            
           // await File.WriteAllBytesAsync("vid.mp4", cntnt);
            
         //   var contentString = await result.Content.ReadAsStringAsync();
         Console.WriteLine();
           // Console.WriteLine(contentString);
        }
    }
}