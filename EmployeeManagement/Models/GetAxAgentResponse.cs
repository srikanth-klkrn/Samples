using System;
using System.Globalization;

namespace SignalRApp1.Models
{

    public class GetAxAgentResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public string DeviceId { get; set; }

        public string Action
        {
            get
            {
                string action = string.Empty;

                switch (State.ToLower(CultureInfo.InvariantCulture).Trim())
                {
                    case "pending":
                        action = "Confirm";
                        break;
                    case "confirmed":
                        action = "Online";
                        break;
                    case "offline":
                        action = "Online";
                        break;
                    case "online":
                    case "disconnected":
                    case "inuse":
                        action = "Offline";
                        break;
                    default:
                        Console.WriteLine("No matching action");
                        break;

                }

                return action;
            }
        }

        public bool IsHidden { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsOnline { get; set; }

        public bool IsDisconnected
        {
            get
            {
                Boolean action = false;

                switch (State.ToLower(CultureInfo.InvariantCulture).Trim())
                {
                    case "disconnected":
                    case "inuse":
                        action = true;
                        break;
                    default:
                        Console.WriteLine("No matching action");
                        break;

                }

                return action;
            }
        }

    }
}