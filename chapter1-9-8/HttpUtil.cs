using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace chapter1_9_8 {
    public class HttpUtil {

        public static  HttpListener listener = new HttpListener();

        public static async Task Listen(string prefix, int maxConcurrentRequests, CancellationToken token) {
            if (listener.IsListening) return;
            try {
                listener.Prefixes.Add(prefix);
                listener.Start();
                Debug.Print("开启监听");
                var requests = new HashSet<Task>();
                for (int i = 0; i < maxConcurrentRequests; i++) {
                    requests.Add(listener.GetContextAsync());
                }
                while (!token.IsCancellationRequested) {
                    Task t = await Task.WhenAny(requests);
                    requests.Remove(t);
                    if (t is Task<HttpListenerContext>) {
                        var context = (t as Task<HttpListenerContext>).Result;
                        requests.Add(ProcessRequestAsync(context));
                        requests.Add(listener.GetContextAsync());
                    }
                }
            } catch (Exception ex) {
                Debug.Print(ex.Message);
            }
        }

        public static void StopListen() {
            if (!listener.IsListening) return;
            listener.Stop();
            Debug.Print("关闭监听");
        }


        public static async Task ProcessRequestAsync(HttpListenerContext context) {
            StreamReader sr = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
            var data = sr.ReadToEnd();
            Debug.Print(data);
            string Output = "<html><body><h1>Hello world</h1><div>Time is: " + DateTime.Now + "</div></body></html>";
            byte[] bOutput = System.Text.Encoding.UTF8.GetBytes(Output);
            context.Response.ContentType = "application/json"; // "text/html"
            context.Response.ContentLength64 = bOutput.Length;
            Stream OutputStream = context.Response.OutputStream;
            OutputStream.Write(bOutput, 0, bOutput.Length);
            OutputStream.Close();
        }
    }
}