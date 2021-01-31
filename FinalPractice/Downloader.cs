using System.Threading.Tasks;

namespace FinalPractice
{
    class Downloader
    {
        Command _command;
        
        /// <summary>
        /// Установка команды
        /// </summary>
        public void SetCommand(Command command)
        {
            _command = command;
        }
        
        /// <summary>
        /// Выполнение команды
        /// </summary>
        public async Task RunAsync( string sourceUrl )
        {
           await _command.RunAsync(sourceUrl);
        }
    }
}