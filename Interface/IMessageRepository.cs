using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat.Interface
{
    public interface IMessageRepository
    {
        Task<List<Message>> GetMessagesAsync();
        Task AddMessageAsync(Message message);
        Task DeleteMessageAsync(int messageId);
    }
}
