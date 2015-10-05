using System;
using System.IO;
using System.Net;
using Bugsnager.Payload;
using Newtonsoft.Json;

namespace Bugsnager
{
    internal class Notifier
    {
        public const string Name = ".NET Bugsnag Notifier for WindowsPhone";
        public static readonly Uri Url = new Uri("https://github.com/bugsnag/bugsnag-net");

        public static readonly string Version = "0.1";

        private static readonly IWebProxy DetectedProxy = WebRequest.DefaultWebProxy;
        private static readonly JsonSerializerSettings JsonSettings =
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

        private Configuration Config { get; set; }
        private NotificationFactory Factory { get; set; }

        public Notifier(Configuration config)
        {
            Config = config;
            Factory = new NotificationFactory(config);
        }

        public void Send(Event errorEvent)
        {
            var notification = Factory.CreateFromError(errorEvent);
            if (notification != null)
                Send(notification);
        }

        private async void Send(Notification notification)
        {
            //  Post JSON to server:
            var request = (HttpWebRequest)(WebRequest.Create(Config.EndpointUrl));

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Proxy = DetectedProxy;

            using (var streamWriter = new StreamWriter(await request.GetRequestStreamAsync()))
            {
                var json = JsonConvert.SerializeObject(notification, JsonSettings);
                streamWriter.Write(json);
                streamWriter.Flush();
            }

            //TODO: add some checks
            try
            {
                var response = await request.GetResponseAsync();
            }
            catch (WebException)
            {
                return;
            }
        }
    }
}
