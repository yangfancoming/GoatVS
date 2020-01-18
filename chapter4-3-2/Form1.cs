using System;
using System.Windows.Forms;
using chapter4_3_2.Model;
using chapter4_3_2.MovieFinder;
using Common.Logging;
using Spring.Context;
using Spring.Context.Support;

namespace chapter4_3_2 {
    public partial class Form1 : Form {
        private static readonly ILog LOG = LogManager.GetLogger(typeof(Program));
        readonly IApplicationContext ctx = ContextRegistry.GetContext();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MovieLister lister = (MovieLister) ctx.GetObject("MyMovieLister");
            Movie[] movies = lister.MoviesDirectedBy("Roberto Benigni");
            LOG.Debug("Searching for movie...");
            foreach (Movie movie in movies){
                LOG.Debug(string.Format("Movie Title = '{0}', Director = '{1}'.",movie.Title, movie.Director));
            }
            LOG.Debug("MovieApp Done.");
        }
    }
}