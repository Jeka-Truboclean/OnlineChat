using Microsoft.EntityFrameworkCore;
using OnlineChat.Context;
using OnlineChat.Interface;
using OnlineChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ChatDbContext _context;

        public MessageRepository(ChatDbContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Message>> GetMessagesAsync()
        {
            return await _context.Messages.Include(m => m.User).ToListAsync();
        }

        public async Task AddMessageAsync(Models.Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMessageAsync(int messageId)
        {
            var message = await _context.Messages.FindAsync(messageId);
            if (message != null)
            {
                _context.Messages.Remove(message);
                await _context.SaveChangesAsync();
            }
        }
    }
}
