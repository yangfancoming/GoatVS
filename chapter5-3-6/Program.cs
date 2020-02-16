using System;
using System.Text;
using System.Threading;
using MQTTnet;
using MQTTnet.Diagnostics;
using MQTTnet.Protocol;
using MQTTnet.Server;

namespace chapter5_3_6 {
    internal class Program {

        private static MqttServer mqttServer;

        public static void Main(string[] args) {

            new Thread(StartMqttServer).Start();

            while (true){
                var inputString = Console.ReadLine().ToLower().Trim();
                if (inputString == "exit"){
                    mqttServer?.StopAsync().Wait();
                    Console.WriteLine("MQTT服务已停止！");
                    break;
                }

                if (inputString == "clients"){
                    foreach (var item in mqttServer.GetClientSessionsStatus()){//客户端session
                        Console.WriteLine($"客户端标识：{item.ClientId}，协议版本：{item.ProtocolVersion}");
                    }
                }
                else{
                    Console.WriteLine($"命令[{inputString}]无效！");
                }
            }

        }


        private static void StartMqttServer(){
            if (mqttServer != null) return;
            try {
                var options = new MqttServerOptions{
                    ConnectionValidator = c =>{
                        if (c.ClientId.Length < 10){
                            c.ReturnCode= MqttConnectReturnCode.ConnectionRefusedIdentifierRejected;
                        }
                        if (c.Username != "admin" || c.Password != "123"){
                            c.ReturnCode= MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                        }
                        c.ReturnCode= MqttConnectReturnCode.ConnectionAccepted;
                    }
                };
                mqttServer = new MqttFactory().CreateMqttServer(new MqttNetLogger()) as MqttServer;
                mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;
                mqttServer.ClientConnected += MqttServer_ClientConnected;
                mqttServer.ClientDisconnected += MqttServer_ClientDisconnected;
                mqttServer.ClientSubscribedTopic += MqttServer_ClientSubscribedTopic;
                mqttServer.ClientUnsubscribedTopic += MqttServer_ClientUnsubscribedTopic;

                mqttServer.StartAsync(options).Wait();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("MQTT服务启动成功！");
        }


        private static void MqttServer_ClientUnsubscribedTopic(object sender, MqttClientUnsubscribedTopicEventArgs e){
            Console.WriteLine($"客户端[{e.ClientId}] 取消主题：{e.TopicFilter}");
        }

        private static void MqttServer_ClientSubscribedTopic(object sender, MqttClientSubscribedTopicEventArgs e){
            Console.WriteLine($"客户端[{e.ClientId}] 发布主题：{e.TopicFilter}");
        }

        private static void MqttServer_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e){
            Console.WriteLine($"客户端[{e.ClientId}]>> 主题：{e.ApplicationMessage.Topic} 负荷：{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} Qos：{e.ApplicationMessage.QualityOfServiceLevel} 保留：{e.ApplicationMessage.Retain}");
        }

        private static void MqttServer_ClientConnected(object sender, MqttClientConnectedEventArgs e){
            Console.WriteLine($"客户端[{e.ClientId}]已连接");
        }

        private static void MqttServer_ClientDisconnected(object sender, MqttClientDisconnectedEventArgs e){
            Console.WriteLine($"客户端[{e.ClientId}]已断开连接！");
        }

    }
}