using System;
using System.Diagnostics;
using System.Xml;

namespace chapter3_6_1 {

    public class Xml1 {

        public static void parse(String filename) {
            XmlDocument doc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            // 忽略xml中的注释节点
            settings.IgnoreComments = true;
            XmlReader reader = XmlReader.Create(filename, settings);
            try {
                doc.Load(reader);
            }
            catch (Exception e) {
                Debug.Print(e.Message);
                Debug.Print(e.StackTrace);
            }
            XmlNode root = doc.DocumentElement;
            Debug.Print("根节点名称：" + root.Name);
            XmlNodeList rootChildren = root.ChildNodes;
            getChild(rootChildren);
        }


        public static void getChild(XmlNodeList xmlNodeList){
            if (xmlNodeList.Count <= 0) return;
            foreach (XmlNode child in xmlNodeList) {
                switch (child.NodeType) {
                    case XmlNodeType.Text:
                        Debug.Print("文本名称：" + child.Name + "文本内容：" + child.InnerText);
                        break;
                    case XmlNodeType.Element:
                        Debug.Print("子节点名称：" + child.Name + "子节点内容：" + child.InnerText);
                        getChild(child.ChildNodes);
                        break;
                }
            }
        }



    }
}