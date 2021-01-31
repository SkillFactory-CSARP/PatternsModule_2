using System.Threading.Tasks;

namespace FinalPractice
{
    /// <summary>
    /// Общий интерфейс кооманды
    /// </summary>
    public abstract class Command
    {
        public abstract Task RunAsync( string arg );
    }
}