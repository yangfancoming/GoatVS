using System;
using System.Diagnostics;
using System.Windows.Forms;
using chapter4_3_2.Model;
using chapter4_3_2.MovieFinder;
using Spring.Context;
using Spring.Context.Support;

namespace chapter4_3_2 {
    public partial class Form1 : Form {

        readonly IApplicationContext ctx = ContextRegistry.GetContext();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MovieLister lister = (MovieLister) ctx.GetObject("MyMovieLister");
            Movie[] movies = lister.MoviesDirectedBy("Roberto Benigni");
            Debug.Print("Searching for movie...");
            foreach (Movie movie in movies){
                Debug.Print($"Movie Title = '{movie.Title}', Director = '{movie.Director}'.");
            }
            Debug.Print("MovieApp Done.");
        }

        // 构造函数测试
        private void button2_Click(object sender, EventArgs e) {
            IMovieFinder finder = (IMovieFinder) ctx.GetObject ("AnotherMovieFinder");
            var findAll = finder.FindAll();
        }
    }
}