

#region Imports

using System.Collections;
using System.Diagnostics;
using chapter4_3_2.Model;

#endregion

namespace chapter4_3_2.MovieFinder.Impl{

    // 内存存储 实现类
	public class SimpleMovieFinder : IMovieFinder {

        private readonly ArrayList _list = new ArrayList();

        /// 构造函数
        public SimpleMovieFinder(){
            Debug.Print("SimpleMovieFinder 实例化！");
            InitList();
        }

        /// <summary>
        /// Add a movie to the list.
        /// </summary>
        /// <param name="m">The movie.</param>
        public void AddMovie(Movie m){
            _list.Add(m);
        }

        /// <summary>
        /// Finds all of the movies stored in this
        /// <see cref="IMovieFinder"/> implementation.
        /// </summary>
        /// <returns>
        /// All of the movies stored in this
        /// <see cref="IMovieFinder"/> implementation.
        /// </returns>
        public IList FindAll(){
            return new ArrayList (_list);
        }

        /// <summary>
        /// Initialises the in-mememory list of stored movies.
        /// </summary>
        private void InitList (){
            _list.Add (new Movie ("La vita e bella", "Roberto Benigni"));
        }
	}
}
