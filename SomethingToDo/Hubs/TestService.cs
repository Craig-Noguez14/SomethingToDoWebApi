using Microsoft.AspNet.SignalR;
using SomethingToDo.Cache;
using SomethingToDo.DTO.Event;
using SomethingToDo.DTO.User;
using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace SomethingToDo.Hubs
{
    public class TestService
    {
        private Timer taskTimer;
        private IHubContext hub;

        public TestService()
        {

            hub = GlobalHost.ConnectionManager.GetHubContext<EventHub>();

            taskTimer = new Timer(OnTimerElapsed, null,
                TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(10));
        }

        private void OnTimerElapsed(object sender)
        {
            hub.Clients.All.Send(EventCache.Events);
        }

        public void Stop(bool immediate)
        {
            taskTimer.Dispose();

        }
    }
}