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
    
    #line 5 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Nav/ListTree.cshtml")]
    public partial class _Areas_CMS_Views_Nav_ListTree_cshtml : System.Web.Mvc.WebViewPage<IList<Nav>>
    {
        public _Areas_CMS_Views_Nav_ListTree_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
   Write(Html.Partial("_List_Toolbar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>编号</th>
                    <th>名称</th>
                    <th>分类</th>
                    <th>链接</th>
                    <th>排序</th>
                    <th>启用</th>
                    <th>升</th>
                    <th>降</th>
                    <th>操作</th>
                </tr>
            </thead>
            <tbody>
");

            
            #line 30 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                
            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                 foreach (var entity in Nav.Root.AllChilds)
                {
                    var p = entity.Parent;
                    if (p == null)
                    {
                        p = Nav.Root;
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>");

            
            #line 38 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                       Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 39 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                       Write(entity.TreeNodeName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 40 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                       Write(entity.CategoryName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 41 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                       Write(entity.Url);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 42 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                       Write(entity.Sort);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        ");

            
            #line 43 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                   Write(Html.Partial("_List_Data_Item", new Pair(entity, fact.Table.FindByName("Enable"))));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <td>\r\n");

            
            #line 45 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 45 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                             if (p != null && entity != p.Childs[0])
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1642), Tuple.Create("\"", 1690)
            
            #line 47 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
, Tuple.Create(Tuple.Create("", 1649), Tuple.Create<System.Object, System.Int32>(Url.Action("Up", new { id = entity.ID })
            
            #line default
            #line hidden
, 1649), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-up\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 48 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

            
            #line 51 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                             if (p != null && entity != p.Childs[p.Childs.Count - 1])
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2014), Tuple.Create("\"", 2064)
            
            #line 53 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
, Tuple.Create(Tuple.Create("", 2021), Tuple.Create<System.Object, System.Int32>(Url.Action("Down", new { id = entity.ID })
            
            #line default
            #line hidden
, 2021), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-down\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 54 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 57 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                       Write(Html.Partial("_List_Data_Action", entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");

            
            #line 60 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n        <p>\r\n");

WriteLiteral("            ");

            
            #line 66 "..\..\Areas\CMS\Views\Nav\ListTree.cshtml"
       Write(Html.Partial("_List_Pager"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
