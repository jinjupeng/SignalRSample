using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
//SignalR的主要功能由集线器定义。集线器由客户端间接调用，接着客户端被调用。
namespace ChatServer
{
    /// <summary>
    /// ChatHub类派生于基类Hub，以获得所需的集线器功能。
    /// </summary>
    public class ChatHub : Hub
    {
        /// <summary>
        /// Send方法定义由客户应用程序调用，把消息发送到其他客户程序。可以使用任何方法名称与任意数量的参数。
        /// 客户端代码只需要匹配方法名和参数。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void Send(string name, string message)
        {
            //为了给客户端发送消息，使用Hub类的Clients属性。Clients属性返回一个IHubCallerConnectContext<dynamic>,
            //它允许把消息发送给特定的客户端或所连接的客户端。
            Clients.All.BroadcastMessage(name, message); //这里使用All属性给所有连接的客户端调用BroadcastMessage。
        }

        public override Task OnConnected()
        {
            // you can access info using base.Context
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}