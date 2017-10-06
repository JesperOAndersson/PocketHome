using System.Threading.Tasks;

namespace PocketHome.Core.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
