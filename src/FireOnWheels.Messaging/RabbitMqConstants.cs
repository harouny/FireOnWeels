using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireOnWheels.Messaging
{
    public static class RabbitMqConstants
    {
        public const string RabbitMqUri =
            "rabbitmq://localhost/fireonwheels/";
        public const string UserName = "fire";
        public const string Password = "fire";
        public const string JsonMimeType = "application/json";

        public const string RegisterOrderServiceQueue = "registerorder.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string FinanceServiceQueue = "finance.service";
    }
}
