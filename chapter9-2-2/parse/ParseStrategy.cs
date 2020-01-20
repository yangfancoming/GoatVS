using System.Collections.Generic;
using chapter9_2_2.constant;

namespace chapter9_2_2.parse {



    // 解析策略类
    public static class ParseStrategy {

        // 解析策略实现类集合
        public static readonly Dictionary<FileType,IParse<string,string>> mParses = new Dictionary<FileType,IParse<string,string>>();

        // 填充策略实现类集合
        static ParseStrategy() {
            IParse<string,string> csv  = new ParseCsv();
            IParse<string,string> json = new ParseJson();
            IParse<string,string> xml  = new ParseXml();
            mParses.Add(csv.fileType(),csv);
            mParses.Add(json.fileType(),json);
            mParses.Add(xml.fileType(),xml);
        }
    }
}