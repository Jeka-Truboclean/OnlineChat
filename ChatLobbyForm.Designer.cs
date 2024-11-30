using OnlineChat.Interface;

namespace OnlineChat
{
    public partial class ChatLobbyForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IMessageRepository _messageRepository;

        public ChatLobbyForm(IUserRepository userRepository, IMessageRepository messageRepository)
        {
            _userRepository = userRepository;
            _messageRepository = messageRepository;

            // Add UI components like ListViews for online/offline users, TextBox for chat messages
            // Implement Send and Delete message functionality
        }
    }
}