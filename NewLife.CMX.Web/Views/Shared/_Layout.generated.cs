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
    
    #line 1 "..\..\Views\Shared\_Layout.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Layout.cshtml"
  
    var menu = ManageProvider.Menu.Current;
    HttpContext.Current.Items["Title"] = ViewBag.Title + "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(" />\r\n\r\n    <title>");

            
            #line 13 "..\..\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 13 "..\..\Views\Shared\_Layout.cshtml"
                       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"新生命开发团队\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" content=\"新生命开发团队\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"author\"");

WriteLiteral(" content=\"新生命开发团队\"");

WriteLiteral(">\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 567), Tuple.Create("\"", 587)
, Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 574), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n\r\n    <!-- 基本样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 680), Tuple.Create("\"", 728)
, Tuple.Create(Tuple.Create("", 687), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 687), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 760), Tuple.Create("\"", 811)
, Tuple.Create(Tuple.Create("", 767), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/font-awesome.min.css")
, 767), false)
);

WriteLiteral(" />\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 845), Tuple.Create("\"", 899)
, Tuple.Create(Tuple.Create("", 852), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-theme.min.css")
, 852), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 947), Tuple.Create("\"", 1006)
, Tuple.Create(Tuple.Create("", 954), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-responsive.min.css")
, 954), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n\r\n    <!-- 页面内联样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1077), Tuple.Create("\"", 1099)
, Tuple.Create(Tuple.Create("", 1084), Tuple.Create<System.Object, System.Int32>(Href("~/Content/x.css")
, 1084), false)
);

WriteLiteral(" />\r\n</head>\r\n<body>\r\n");

WriteLiteral("    ");

            
            #line 30 "..\..\Views\Shared\_Layout.cshtml"
Write(Html.Partial("_Header"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"content-wrapper main-content clear-fix\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 32 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <footer");

WriteLiteral(" class=\"footer\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Views\Shared\_Layout.cshtml"
   Write(Html.Partial("_Footer"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </footer>\r\n    <!-- JQuery作为一等公民，页面内部随时可能使用 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1372), Tuple.Create("\"", 1410)
, Tuple.Create(Tuple.Create("", 1378), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 1378), false)
);

WriteLiteral("></script>\r\n    <!-- 最早引入基本脚本 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1457), Tuple.Create("\"", 1502)
, Tuple.Create(Tuple.Create("", 1463), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 1463), false)
);

WriteLiteral(@"></script>

    <!-- HTML5shiv and Respond.js for IE8 to support HTML5 elements and media queries -->
    <!--[if lte IE 8]>
    <script src=""~/Content/js/html5shiv.min.js""></script>
    <script src=""~/Content/js/respond.min.js""></script>
    <![endif]-->
");

WriteLiteral("    ");

            
            #line 47 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591