using MQTTnet;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Protocol;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WCS.Core.Net;

namespace BottlePickModuleForWindows.Service
{
    public class MqttService
    {
        private static MqttClientService _mqttClient;
        public static string serverIp = "127.0.0.1";
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
                _mqttClient.UserName = "tmpWebU1ser1";
                _mqttClient.Password = "123456";
            }
            return _helperInstance;
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
