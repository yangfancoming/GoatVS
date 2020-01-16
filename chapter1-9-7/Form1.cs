using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpClientSample;

namespace chapter1_9_7 {
    public partial class Form1 : Form {

        public static readonly HttpClient client = new HttpClient();


        public Form1() {
            InitializeComponent();

            client.BaseAddress = new Uri("http://localhost:8290/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void button1_Click(object sender, EventArgs e) {
            Product product = new Product { name = "Gizmo", price = 100, category = "Widgets" };
            var res = CreateProductAsync(product);
            Debug.Print($"what at {res}");
        }

        private void button2_Click(object sender, EventArgs e) {
            var task = get(0);
            Debug.Print($"task is {task.Result}");
        }

        public static async Task<Product> get(int id){
            Product product = null;
            HttpResponseMessage response = await client.GetAsync("test/get?id=0");
            if (response.IsSuccessStatusCode){
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }

        // doit  这个post 为啥总是不好使？？？  还有 这是什么瘠薄HTTPClient 框架啊？  请求后  软件总瘠薄卡死呢？？？？
        private static async Task<Uri> CreateProductAsync(Product product) {
            HttpResponseMessage response = await client.PostAsJsonAsync("test/error2", product);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }



        static async Task<Product> UpdateProductAsync(Product product){
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/products/{product.id}", product);
            response.EnsureSuccessStatusCode();
            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }


        static async Task<HttpStatusCode> DeleteProductAsync(string id){
            HttpResponseMessage response = await client.DeleteAsync($"api/products/{id}");
            return response.StatusCode;
        }


    }
}