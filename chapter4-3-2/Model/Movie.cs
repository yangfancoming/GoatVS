
namespace chapter4_3_2.Model {

	public class Movie{

        // 电影名称
        public string Title { get; }

        // 电影导演
        public string Director { get; }
        // 导演

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="title">电影名称</param>
        /// <param name="director">电影导演</param>
		public Movie (string title, string director) {
            Title = title;
            Director = director;
		}

    }
}
