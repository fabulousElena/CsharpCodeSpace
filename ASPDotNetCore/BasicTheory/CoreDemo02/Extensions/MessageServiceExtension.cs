using System;
using Microsoft.Extensions.DependencyInjection;

namespace CoreDemo02.Extensions
{
    public static class MessageServiceExtension
    {
        public static void AddMessage(this IServiceCollection/*服务集合接口*/ services,Action<MessageServiceBuilder>/*封装方法*/ configure)
        {
            //services.AddSingleton<IMessageService, EmailService>();
            //创建一个 MessageServiceBuilder 的实例，然后通过构造体传递 this services
            var builder  = new MessageServiceBuilder(services);
            configure(builder); //然后把这个实例封装，在Startup里面用lamda表达式调用
        }
    }
}
