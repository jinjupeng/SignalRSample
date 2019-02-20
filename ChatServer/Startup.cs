using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ChatServer.Startup))]

namespace ChatServer
{
    public class Startup
    {
        /// <summary>
        /// Configuration方法添加MapSignalR的调用。
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            //MapSignalR方法定义了signalR URI，作为请求SignalR集线器的路径。
            app.MapSignalR();
        }
    }
}
