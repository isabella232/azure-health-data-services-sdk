﻿using Azure.Messaging.EventGrid;
using Azure.Storage.Queues.Models;

namespace EventGridChannelSample
{
    public class ReceiveEventArgs : EventArgs
    {
        public ReceiveEventArgs(EventGridEvent message)
        {
            Message = message;
        }

        public EventGridEvent Message { get; private set; }
    }
}
