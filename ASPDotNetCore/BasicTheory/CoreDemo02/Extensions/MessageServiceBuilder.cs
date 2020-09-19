using CoreDemo02.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoreDemo02.Extensions
{
    public class MessageServiceBuilder
    {
        public IServiceCollection ServiceCollection { get; set; } //定义本类中的ServiceCollection

        public MessageServiceBuilder(IServiceCollection services)
        {
            ServiceCollection = services; //通过构造体传递services
        }
        //方法1
        public void UseEmail()
        {
            //注册服务 等待调用
            ServiceCollection.AddSingleton<IMessageService, EmailService>();
        }
        //方法2 
        public void UseSms()
        {
            //注册服务 等待调用
            ServiceCollection.AddSingleton<IMessageService, SmsService>();
        }
    }
}
