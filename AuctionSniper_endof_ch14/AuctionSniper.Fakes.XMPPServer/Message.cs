﻿namespace AuctionSniper.Fakes.XMPPServer
{
    public class Message
    {
        private Message()
        {
        }

        public Message(Chat chat)
        {
            Chat = chat;
        }

        public Chat Chat { get; set; }

        public string Body { get; set; }
    }
}