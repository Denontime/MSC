using System;
using System.Collections.Generic;
using System.Text;
using BottlePickModuleForWindows.Resources;
using BottlePickModuleForWindows.Service;

namespace BottlePickModuleForWindows.Controller
{
    public class BottleMqttController
    {

        public void CreateMqttService()
        {
            MqttService mqttService = MqttService.getMqttInstance();
            bool connectSuccess = mqttService.Connect();
            if (!connectSuccess)
            {
                return;
            }
            //订阅主题
            mqttService.Subscribe("Conveyor");
            mqttService.Subscribe("Photo");
            mqttService.processMqttMessageEvent += this.processTopicMessage;
        }

        //监听mqtt消息
        public void processTopicMessage(string topic, string message)
        {

            switch (topic)
            {
                case "Photo":
                    if (message == "photo")
                    {
                        
                    }
                    else if (message == "cut")
                    {

                    }
                    else if (message == "force")
                    {
                        
                    }
                    else if (message == "correct")
                    {

                    }
                    break;

                default:
                    break;
            }
        }
    }
}
