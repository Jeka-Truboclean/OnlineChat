namespace OnlineChat
{
    public partial class LoginForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            // Add UI components like textboxes, labels, and buttons for Login and Register
            // On successful login or registration, open the ChatLobbyForm
        }
    }
}
