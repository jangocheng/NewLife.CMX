﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.CMX;
    using NewLife.CMX.Web;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Article/Info.cshtml")]
    public partial class _Views_Article_Info_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.IInfo>
    {
        public _Views_Article_Info_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Article\Info.cshtml"
  
    var inf = Model;
    this.PushTitle(Model.Category.Name);
    this.PushTitle(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Views\Article\Info.cshtml"
   Write(Html.Partial("_Nav"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\Article\Info.cshtml"
       Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </h2>\r\n        <h3");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n            <em");

WriteLiteral(" class=\"e e1\"");

WriteLiteral(">来源：");

            
            #line 16 "..\..\Views\Article\Info.cshtml"
                           Write(inf.CreateUser);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n            <em");

WriteLiteral(" class=\"e e2\"");

WriteLiteral(">发布时间：");

            
            #line 17 "..\..\Views\Article\Info.cshtml"
                             Write(Model.CreateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n            <em");

WriteLiteral(" class=\"e e3\"");

WriteLiteral(">浏览：");

            
            #line 18 "..\..\Views\Article\Info.cshtml"
                           Write(Model.Views.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n        </h3>\r\n        <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n            <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n                .TRS_Editor P {\r\n                    margin-top: 0;\r\n         " +
"           margin-bottom: 1em;\r\n                    line-height: 2;\r\n           " +
"     }\r\n\r\n                .TRS_Editor DIV {\r\n                    margin-top: 0;\r" +
"\n                    margin-bottom: 1em;\r\n                    line-height: 2;\r\n " +
"               }\r\n\r\n                .TRS_Editor TD {\r\n                    margin" +
"-top: 0;\r\n                    margin-bottom: 1em;\r\n                    line-heig" +
"ht: 2;\r\n                }\r\n\r\n                .TRS_Editor TH {\r\n                 " +
"   margin-top: 0;\r\n                    margin-bottom: 1em;\r\n                    " +
"line-height: 2;\r\n                }\r\n\r\n                .TRS_Editor SPAN {\r\n      " +
"              margin-top: 0;\r\n                    margin-bottom: 1em;\r\n         " +
"           line-height: 2;\r\n                }\r\n\r\n                .TRS_Editor FON" +
"T {\r\n                    margin-top: 0;\r\n                    margin-bottom: 1em;" +
"\r\n                    line-height: 2;\r\n                }\r\n\r\n                .TRS" +
"_Editor UL {\r\n                    margin-top: 0;\r\n                    margin-bot" +
"tom: 1em;\r\n                    line-height: 2;\r\n                }\r\n\r\n           " +
"     .TRS_Editor LI {\r\n                    margin-top: 0;\r\n                    m" +
"argin-bottom: 1em;\r\n                    line-height: 2;\r\n                }\r\n\r\n  " +
"              .TRS_Editor A {\r\n                    margin-top: 0;\r\n             " +
"       margin-bottom: 1em;\r\n                    line-height: 2;\r\n               " +
" }\r\n            </style>\r\n            <div");

WriteLiteral(" class=\"TRS_Editor\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 77 "..\..\Views\Article\Info.cshtml"
           Write(Html.Raw(Model.ContentText));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
