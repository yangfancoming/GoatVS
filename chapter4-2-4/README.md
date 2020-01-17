#  Spring.Net 

    引入步骤
    1. 3个 dll  Common.Logging.dll | Spring.Core.dll | Spring.Data.dll
    
    2. App.config 文件 加入 配置
            <configSections>
                <sectionGroup name="spring">
                    <section name="context" type="Spring.Context.Support.ContextHandler, Spring.Core" />
                    <section name="objects" type="Spring.Context.Support.DefaultSectionHandler, Spring.Core" />
                </sectionGroup>
            </configSections>
        
            <spring>
        
                <context>
                    <resource uri="config://spring/objects" />
                </context>
        
                <objects xmlns="http://www.springframework.net">
                    <description>一个简单的控制反转例子</description>
                    <object id="Person" type="控制反转.Person,01控制反转(基础篇)" />
                </objects>
        
            </spring>

#   目录
    item01 控制反转
   