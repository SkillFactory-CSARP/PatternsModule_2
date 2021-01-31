using System;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace FinalPractice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Ссылка для загрузки виидео. 
            // Ее также можно запрашивать через Console.Readline()
            var videoUrl = "https://www.youtube.com/watch?v=1lBe2ao3j1Q";
            
            // Ссздадим отправителя и получателя команд
            var downloader = new Downloader();
            var receiverClient = new YoutubeClient();
            
            // Команда на запрос иинформации
            var getInfoCommand = new GetInfoCommand(receiverClient);
            downloader.SetCommand(getInfoCommand);
            await downloader.RunAsync(videoUrl);
            
            // Команда на загрузку
            var downLoadCommand = new DownloadCommand(receiverClient);
            downloader.SetCommand(downLoadCommand);
            await downloader.RunAsync(videoUrl);
        }
    }
}