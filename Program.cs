using Microsoft.Extensions.DependencyInjection;
using OnlineChat.Context;
using OnlineChat.Interface;
using OnlineChat.Repository;

namespace OnlineChat
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddDbContext<ChatDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();

            var serviceProvider = services.BuildServiceProvider();

            Application.Run(new LoginForm(serviceProvider));
        }
    }
}