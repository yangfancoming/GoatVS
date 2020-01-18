

using System.Collections;
using System.Diagnostics;
using System.IO;
using chapter4_3_2.Model;

namespace chapter4_3_2.MovieFinder.Impl {



    // 文件存储 实现类
    public class ColonDelimitedMovieFinder : IMovieFinder{

        private static readonly char [] Delimeter = {':'};
        private FileInfo _movieFile;
        private IList _movies;


        // 构造函数
        public ColonDelimitedMovieFinder (FileInfo file) {
            Debug.Print("ColonDelimitedMovieFinder 实例化！");
            MovieFile = file;
        }

        // 分号 分隔符的文件
        public FileInfo MovieFile  {
            get => _movieFile;
            set {
                _movieFile = value;
                if (_movieFile != null && _movieFile.Exists) {
                    InitList ();
                } else {
                    Debug.Print($"文件没找到 = '{value}'");
                }
            }
        }

        /// <summary>
        /// Finds all of the movies stored in this
        /// <see cref="IMovieFinder"/> implementation.
        /// </summary>
        /// <returns>
        /// All of the movies stored in this
        /// <see cref="IMovieFinder"/> implementation.
        /// </returns>
        public IList FindAll () {
            return _movies;
        }

        /// <summary>
        /// Loads all of the movies in the file referred to by <c>MovieFile</c>.
        /// </summary>
        private void InitList () {
            _movies = new ArrayList ();
            using (StreamReader reader = MovieFile.OpenText ()) {
                string line;
                while ((line = reader.ReadLine ()) != null) {
                    string [] tuple = line.Split (Delimeter);
                    Movie movie = new Movie (tuple [0], tuple [1]);
                    _movies.Add(movie);
                }
            }
        }
    }
}
