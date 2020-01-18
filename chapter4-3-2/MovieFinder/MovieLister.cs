

using System.Collections;
using System.Diagnostics;
using chapter4_3_2.Model;
using Spring.Objects.Factory.Attributes;

namespace chapter4_3_2.MovieFinder {

	/// <summary>
	/// A class that provides a list of movies directed by a particular director.
    /// </summary>
	public class MovieLister {

        private IMovieFinder _movieFinder;

        public MovieLister() {
            Debug.Print("MovieLister 实例化！");
        }

        /// <summary>
        /// Property MovieFinder (IMovieFinder).
        /// </summary>
//        [Required]
        public IMovieFinder MovieFinder {
            get => _movieFinder;
            set => _movieFinder = value;
        }

        /// 根据导演名称查询出其导演的电影集合
        public Movie [] MoviesDirectedBy (string director){
            IList allMovies = _movieFinder.FindAll ();
            IList movies = new ArrayList ();
            foreach (Movie m in allMovies){
                if (director.Equals (m.Director)){
                    movies.Add (m);
                }
            }
            return (Movie []) ArrayList.Adapter(movies).ToArray (typeof(Movie));
        }
	}
}
