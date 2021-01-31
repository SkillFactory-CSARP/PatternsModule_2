using System;
using System.Threading.Tasks;
using YoutubeExplode;

namespace FinalPractice
{
    /// <summary>
    /// Команда на получение иинформации
    /// </summary>
    public class GetInfoCommand  : Command
    {
        // получатель
        YoutubeClient _videoClient;
        
        public GetInfoCommand(YoutubeClient videoClient)
        {
            _videoClient = videoClient;
        }
        
        public override async Task RunAsync( string arg  )
        {
            Console.WriteLine();
            Console.WriteLine("Загружаем данные");
            
            // Получаем и выводим данные о видео
            var info = await _videoClient.Videos.GetAsync(arg);
            Console.WriteLine(info.Title);
            Console.WriteLine(info.Description);
            
            Console.WriteLine();
        }
    }
}