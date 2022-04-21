using MqttClent.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MqttClent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mqttstr = "";
            mqttstr += "{";
            mqttstr += "'id':'23',";
            mqttstr += "'version': '1.0',";
            mqttstr += "'params': {";
            mqttstr += "'CardID': {";
            mqttstr += " 'value': 'photo'";
            mqttstr += "}";
            mqttstr += "},";
            mqttstr += "'method': 'thing.event.property.pos'";
            mqttstr += "}";

 



            MqttService mqttClient = MqttService.getMqttInstance();
            if (mqttClient.Connect()){
                mqttClient.Subscribe("a1nRLG4tszg/MassageService/user/MassageService");
                Console.WriteLine("subscribe Photo top");
                mqttClient.Publish("sys/a1nRLG4tszg/MassageService/thing/event/property/post", mqttstr);
                mqttClient.processMqttMessageEvent += this.processTopicMessage;
            }
   
        }

        public void processTopicMessage(string topic, string message)
        {
            Console.WriteLine(topic + message);
        }
    }
}
