
namespace chapter4_3_2.Model
{
	/// <summary>
	/// An object that describes a movie.
	/// </summary>
	public class Movie
	{
        private string _title;
        private string _director;

        /// <summary>
        /// Creates a new instance of the
        /// <see cref="Spring.IocQuickStart.MovieFinder.Movie"/> class.
        /// </summary>
        /// <param name="title">The title of the movie.</param>
        /// <param name="director">The director of the movie.</param>
		public Movie (string title, string director)
		{
            _title = title;
            _director = director;
		}

        /// <summary>
        /// Property Title (string).
        /// </summary>
        public string Title => _title;

        /// <summary>
        /// Property Director (string).
        /// </summary>
        public string Director => _director;
    }
}
