

using System.Collections;


namespace chapter4_3_2.MovieFinder {
	/// <summary>
	/// Describes the interface for finding a list of movies independent of <i>how</i>
	/// said movies are actually stored (text file, database, etc).
	/// </summary>
	public interface IMovieFinder {

        /// <summary>Finds all of the stored movies.</summary>
        /// <returns>All of the stored movies.</returns>
		IList FindAll ();
	}
}
