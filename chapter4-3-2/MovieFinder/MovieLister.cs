

using System.Collections;
using chapter4_3_2.Model;
using Spring.Objects.Factory.Attributes;

namespace chapter4_3_2.MovieFinder
{
	/// <summary>
	/// A class that provides a list of movies directed by a particular director.
    /// </summary>
	public class MovieLister
	{
        private IMovieFinder _movieFinder;

        /// <summary>
        /// Creates a new instance of the
        /// <see cref="MovieLister"/> class.
        /// </summary>
		public MovieLister ()
		{
		}

        /// <summary>
        /// Property MovieFinder (IMovieFinder).
        /// </summary>
        [Required]
        public IMovieFinder MovieFinder
        {
            get
            {
                return _movieFinder;
            }
            set
            {
                _movieFinder = value;
            }
        }

        /// <summary>
        /// Returns a list of those movies directed by the supplied
        /// <paramref name="director"/>
        /// </summary>
        /// <param name="director">
        /// The name of the director whose movies we are to return.
        /// </param>
        /// <returns>
        /// A list of those movies directed by the supplied
        /// <paramref name="director"/>.
        /// </returns>
        public Movie [] MoviesDirectedBy (string director)
        {
            IList allMovies = _movieFinder.FindAll ();
            IList movies = new ArrayList ();
            foreach (Movie m in allMovies){
                if (director.Equals (m.Director)){
                    movies.Add (m);
                }
            }
            return (Movie []) ArrayList.Adapter (movies).ToArray (typeof (Movie));
        }
	}
}
