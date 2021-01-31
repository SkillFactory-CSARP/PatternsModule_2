using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HardCodeExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string siteUrl = "http://192.250.225.62/";
            string resourceID = "?965502";
            
            // запрос выгрузки информации с сайта 
            await LoadSite(siteUrl, resourceID);
        }

        static async Task LoadSite( string siteUrl, string resourceId )
        {
            // создаем клиента для http-запросов
            var httpClient = new HttpClient();
            
            // задаем адрес сайта
            httpClient.BaseAddress = new Uri(siteUrl);
            
            // запрашиваем нужный ресурс
            var result = await httpClient.GetAsync(resourceId);
            
            // считываем ответ в строку и выводим
            var contentString = await result.Content.ReadAsStringAsync();
            Console.WriteLine(contentString);
        }
    }
}