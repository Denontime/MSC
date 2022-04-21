using MQTTnet;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WCS.Core.Net;

namespace MqttClent.Service
{

    public class MqttService
    {
        private static MqttClientService _mqttClient;
        public static string serverIp = "a1nRLG4tszg.iot-as-mqtt.cn-shanghai.aliyuncs.com";
        public static int serverPort = 1883;

        public static MqttService _helperInstance = null;

        public delegate void processMqttMessage(string topic, string message);

        public event processMqttMessage processMqttMessageEvent;

        private MqttService()
        {

        }

        public static MqttService getMqttInstance()
        {
            if (_helperInstance == null)
            {
                _helperInstance = new MqttService();
            }
            if (_mqttClient == null)
            {
                _mqttClient = new MqttClientService(serverIp, serverPort);
                _mqttClient.KeepAliveInterval = 500;
                _mqttClient.CleanSession = false;
                _mqttClient.ClientID = "BottlePickLane|securemode=3,signmethod=hmacsha1|";
                _mqttClient.UserName = "MassageService&a1nRLG4tszg";
                //_mqttClient.Password = GetMqttUserPassword();//4889F864B98EA699AC0858A851F27B423DA51E60
                //_mqttClient = h/*m*/acsha1(  "clientIdBottlePickLane|securemode=3,signmethod=hmacsha1|deviceNameMassageServiceproductKeya1nRLG4tszgtimestamp789").toHexString();
                _mqttClient.Password = HMACSHA1("edbd9bc14c48d76781ec1e751589e2ac", "clientIdBottlePickLane|securemode=3,signmethod=hmacsha1|deviceNameMassageServiceproductKeya1nRLG4tszgtimestamp789").toHexString();
            }
            return _helperInstance;
        }

        private static object HMACSHA1(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private static string GetMqttUserPassword()
        {
            string signmethod = "hmacmd1";
            string DeviceSecret = "edbd9bc14c48d76781ec1e751589e2ac";
            Dictionary<string, string> dict = new Dictionary<string, string>
                {
                    { "productKey", "a1nRLG4tszg" },
                    { "deviceName", "MassageService" },
                    { "clientId", "BottlePickLane|securemode=3,signmethod=hmacsha1|"}
                };

            return IotSignUtils.Sign(dict, DeviceSecret, signmethod).ToUpper();
        }
        public bool Connect()
        {
            _mqttClient.ConnectedEvent += MttClient_ConnectedEvent;
            _mqttClient.DisconnectedEvent += MqttClient_DisconnectedEvent;
            _mqttClient.ReceiveDataEvent += MqttClient_ReceiveDataEvent;

            if (!_mqttClient.Connect(out string errorMessage))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public class IotSignUtils
        {
            public static string Sign(Dictionary<string, string> param, string deviceSecret, string signMethod)
            {
                string[] sortedKey = param.Keys.ToArray();
                Array.Sort(sortedKey);

                StringBuilder builder = new StringBuilder();
                foreach (var i in sortedKey)
                {
                    builder.Append(i).Append(param[i]);
                }

                byte[] key = Encoding.UTF8.GetBytes(deviceSecret);
                byte[] signContent = Encoding.UTF8.GetBytes(builder.ToString());

                var hmac = new HMACMD5(key);
                byte[] hashBytes = hmac.ComputeHash(signContent);

                StringBuilder signBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    signBuilder.AppendFormat("{0:x2}", b);

                return signBuilder.ToString();
            }
        }
        private static string  GetClientId()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
        }
        private void MqttClient_ReceiveDataEvent(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            var item = $"Timestamp: {DateTime.Now:O} | Topic: {eventArgs.ApplicationMessage.Topic} | Payload: {eventArgs.ApplicationMessage.ConvertPayloadToString()} | QoS: {eventArgs.ApplicationMessage.QualityOfServiceLevel}";
            processMqttMessageEvent?.Invoke(eventArgs.ApplicationMessage.Topic, eventArgs.ApplicationMessage.ConvertPayloadToString());
            //处理消息
        }

        private void MqttClient_DisconnectedEvent(MqttClientDisconnectedEventArgs eventArgs)
        {
            //_traceMessages.Enqueue(new MqttNetLogMessage
            //{
            //        Timestamp = DateTime.UtcNow,
            //        ThreadId = -1,
            //        Level = MqttNetLogLevel.Info,
            //        Message = "! DISCONNECTED EVENT FIRED",
            //});

            //Task.Run(UpdateLogAsync);
            //通知服务器已经断开连接
        }

        private void MttClient_ConnectedEvent(MqttClientConnectedEventArgs eventArgs)
        {
            //_traceMessages.Enqueue(new MqttNetLogMessage
            //{
            //        Timestamp = DateTime.UtcNow,
            //        ThreadId = -1,
            //        Level = MqttNetLogLevel.Info,
            //        Message = "! CONNECTED EVENT FIRED",
            //});

            //Task.Run(UpdateLogAsync);
            //通知服务器已经进行连接
        }

        private void Disconnect()
        {
            if (_mqttClient != null)
            {
                _mqttClient.Dispose();
                _mqttClient = null;
            }
        }

        public bool Subscribe(string topic)
        {
            var qos = MqttQualityOfServiceLevel.AtMostOnce;
            if (!_mqttClient.Subscribe(topic, out string errorMessage, qos))
            {
                return false;
                //Trace.Text = $"Failed to subscribe {SubscribeTopic.Text}, Error Message: {errorMessage}. ";
            }
            else
            {
                return true;
                //Trace.Text = $"Successfuly to subscribe {SubscribeTopic.Text}. ";
            }
        }


        public bool Unsubscribe(string topic)
        {
            if (!_mqttClient.Unsubscribe(topic, out string errorMessage))
            {
                return false;
                //log 日志
                //Trace.Text = $"Failed to unsubscribe {SubscribeTopic.Text}, Error Message: {errorMessage}. ";
            }
            else
            {
                return true;
                //Trace.Text = $"Successfuly to unsubscribe {SubscribeTopic.Text}";
            }

        }

        public bool Publish(string topic, string message)
        {
            var qos = MqttQualityOfServiceLevel.AtMostOnce;
            if (!_mqttClient.Publish(topic, message, out string errorMessage, qos))
            {
                return false;
                //Trace.Text = $"Failed to publish {Payload.Text} message, Error Message: {errorMessage}";
            }
            else
            {
                return true;
                //Trace.Text = $"Successfuly to publish {Payload.Text} message. ";
            }

        }
    }
}
