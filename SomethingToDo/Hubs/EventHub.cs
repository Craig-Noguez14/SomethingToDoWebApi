using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace SomethingToDo.Hubs
{
    public class EventHub : Hub
    {
        private readonly Timer _timer;
        private readonly TimeSpan _updateInterval = TimeSpan.FromSeconds(10);

        public EventHub()
        {
            _timer = new Timer(Send, null, _updateInterval, _updateInterval);
        }

        public void Send(object sender)
        {
            Clients.All.broadcastMessage("THIS IS A TEST");
        }

        public void Test()
        {
            Clients.All.broadcastMessage("THIS IS A TEST");
        }
    }
}