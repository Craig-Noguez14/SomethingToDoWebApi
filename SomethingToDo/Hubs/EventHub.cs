using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using SomethingToDo.Repositories.Event;

namespace SomethingToDo.Hubs
{
    public class EventHub : Hub
    {
        private static Timer _timer;
        private static bool _isPolling = false;
        private readonly TimeSpan _updateInterval = TimeSpan.FromSeconds(10);
        private readonly IEventRepository eventRepo;

        public EventHub(IEventRepository eventRepo)
        {
            this.eventRepo = eventRepo;
        }

        public void Start()
        {
            if (_isPolling)
                return;

            _isPolling = true;
            _timer = new Timer(Send, null, _updateInterval, _updateInterval);
        }

        public void Send(object sender)
        {
            Clients.All.broadcastMessage("THIS IS A TEST");
        }

        public void GetAllEventsWithin2Hrs(object sender)
        {
            Clients.All.broadcastMessage(eventRepo.GetAll());
        }
    }
}