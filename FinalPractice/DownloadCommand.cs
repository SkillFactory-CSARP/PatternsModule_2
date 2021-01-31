using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace FinalPractice
{
    /// <summary>
    /// Команда на скачивание
    /// </summary>
    public class DownloadCommand : Command
    {
        // получатель
        YoutubeClient _videoClient;
        
        public DownloadCommand(YoutubeClient videoClient)
        {
            _videoClient = videoClient;
        }
        
        public override async Task RunAsync( string arg )
        {
            Console.WriteLine();
            Console.WriteLine("Загружаем видео");
            
            // Запуск загрузки
            await _videoClient.Videos.DownloadAsync(arg, $"{Guid.NewGuid()}.mp4", 
                builder => builder.SetPreset(ConversionPreset.UltraFast) // Конфигурация для макимально бысстрой загрузки
            );
            
            Console.WriteLine("Видео загружено");
            Console.WriteLine();
        }
    }
}