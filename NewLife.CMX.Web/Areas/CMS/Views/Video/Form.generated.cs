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
    
    #line 2 "..\..\Areas\CMS\Views\Video\Form.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\Areas\CMS\Views\Video\Form.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\CMS\Views\Video\Form.cshtml"
    using NewLife.CMX.Web;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 3 "..\..\Areas\CMS\Views\Video\Form.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\CMS\Views\Video\Form.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Video/Form.cshtml")]
    public partial class _Areas_CMS_Views_Video_Form_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.IInfo>
    {
        public _Areas_CMS_Views_Video_Form_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Areas\CMS\Views\Video\Form.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var entity = Model as IEntity;
    var isNew = entity.IsNullKey;
    var inf = Model as IInfo;
    var text = inf.Ext as IText;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Areas\CMS\Views\Video\Form.cshtml"
   Write(Html.Partial("_Form_Header", entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Areas\CMS\Views\Video\Form.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\CMS\Views\Video\Form.cshtml"
         using (Html.BeginForm((isNew ? "Add" : "Edit"), null, new { id = Model[fact.Unique.Name] }))
        {
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\CMS\Views\Video\Form.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\CMS\Views\Video\Form.cshtml"
                                    
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\CMS\Views\Video\Form.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\CMS\Views\Video\Form.cshtml"
                                     
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\CMS\Views\Video\Form.cshtml"
       Write(Html.Partial("_Form_Title", entity));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\CMS\Views\Video\Form.cshtml"
                                                

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">内容</label>\r\n                <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Areas\CMS\Views\Video\Form.cshtml"
               Write(Html.Partial("_Form_Content", entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 28 "..\..\Areas\CMS\Views\Video\Form.cshtml"
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\CMS\Views\Video\Form.cshtml"
       Write(Html.Partial("_Form_Footer", entity));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\CMS\Views\Video\Form.cshtml"
                                                 
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\CMS\Views\Video\Form.cshtml"
       Write(Html.Partial("_Form_Action", entity));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\CMS\Views\Video\Form.cshtml"
                                                 
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
