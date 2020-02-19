using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;

namespace chapter5_3_5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private IMqttClient mqttClient;
        private void Form1_Load(object sender, EventArgs e) {
            CombServer.Items.Add("本地服务器");
            CombServer.Items.Add("EMQ服务器");
            CombServer.SelectedIndex = 0;
        }

        private void CombServer_SelectedIndexChanged(object sender, EventArgs e) {
            if (mqttClient!=null){
                mqttClient.Dispose();
                mqttClient = null;
            }
            Task.Run(async () => { await ConnectMqttServerAsync(); });
        }

        private async Task ConnectMqttServerAsync(){
            if (mqttClient == null){
                mqttClient = new MqttFactory().CreateMqttClient();
                mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;
                mqttClient.Connected += MqttClient_Connected;
                mqttClient.Disconnected += MqttClient_Disconnected;
            }
            // <!--******************本地服务器********************--> 第三方MQTT服务器连接地址
            //     <!--******************EMQ服务器********************-->  MQTT服务器连接地址
            try{
                var index = CombServer.InvokeRequired ?
                    (int)CombServer.EndInvoke(CombServer.BeginInvoke(new Func<int>(()=> CombServer.SelectedIndex) ))
                    : CombServer.SelectedIndex;

                Base config = new Base { MqttUrl = (index == 1) ? "192.168.211.128"  : "127.0.0.1" };
                var options = new MqttClientOptionsBuilder()
                    .WithClientId(Guid.NewGuid().ToString().Substring(0, 5))
                    .WithTcpServer(config.MqttUrl,Convert.ToInt32(config.MqttPort))
                    .WithCredentials(config.MqttUserName, config.MqttPassWord)
                    .WithKeepAlivePeriod(TimeSpan.FromSeconds(60))
                    .WithCommunicationTimeout(TimeSpan.FromSeconds(30))
                    .Build();
                await mqttClient.ConnectAsync(options);
            }
            catch (Exception ex){
                Invoke((new Action(() =>{  txtReceiveMessage.AppendText($"连接到MQTT服务器失败！" + Environment.NewLine + ex.Message + Environment.NewLine); })));
            }
        }

        private void MqttClient_Connected(object sender, EventArgs e){
            Invoke((new Action(() =>{ txtReceiveMessage.AppendText("已连接到MQTT服务器！" + Environment.NewLine); })));
        }

        private void MqttClient_Disconnected(object sender, EventArgs e){
            Invoke((new Action(() =>{ txtReceiveMessage.AppendText("已断开MQTT连接！" + Environment.NewLine); })));
        }

        private void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e){
            Invoke((new Action(() =>{ txtReceiveMessage.AppendText($">>{e.ClientId} {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}{Environment.NewLine}"); })));
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            Invoke((new Action(() =>{txtReceiveMessage.Clear();})));
        }

        // 订阅按钮
        private void BtnSubscribe_Click(object sender, EventArgs e){

            var topic = txtSubTopic.Text.Trim();

            if (string.IsNullOrEmpty(topic)){
                MessageBox.Show("订阅主题不能为空！");
                return;
            }

            if (!mqttClient.IsConnected){
                MessageBox.Show("MQTT客户端尚未连接！");
                return;
            }

            mqttClient.SubscribeAsync(new List<TopicFilter> {
                new TopicFilter(topic, MqttQualityOfServiceLevel.AtMostOnce)
            });

            txtReceiveMessage.AppendText($"已订阅[{topic}]主题" + Environment.NewLine);

        }

        // 发布按钮
        private void button1_Click(object sender, EventArgs e) {
            string topic = txtPubTopic.Text.Trim();
            if (string.IsNullOrEmpty(topic)){
                MessageBox.Show("发布主题不能为空！");
                return;
            }

            string inputString = txtSendMessage.Text.Trim();
            var appMsg = new MqttApplicationMessage{
                Topic = topic,
                Payload = Encoding.UTF8.GetBytes(inputString),
                QualityOfServiceLevel = MqttQualityOfServiceLevel.ExactlyOnce,//只有一次
                Retain = false
            };
            Task.Run(async () => { await mqttClient.PublishAsync(appMsg); });
        }
    }
}