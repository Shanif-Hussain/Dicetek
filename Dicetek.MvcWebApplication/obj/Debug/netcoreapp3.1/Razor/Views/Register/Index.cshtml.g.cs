#pragma checksum "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a7c651939a8ec366fc7f67f3204d4319b198bf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\_ViewImports.cshtml"
using Dicetek.MvcWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\_ViewImports.cshtml"
using Dicetek.MvcWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7c651939a8ec366fc7f67f3204d4319b198bf0", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09654719ec8bedac8e6daf49d1dd8629e97a841f", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dicetek.DomainModels.RegisterModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-12 mt-5"">
    <!-- BEGIN SAMPLE TABLE PORTLET-->
    <div class=""portlet box blue"">
        <div class=""portlet-title"">
            <div class=""caption"">
                Registered Users
            </div>
            <div class=""tools mt-1 mb-1"" style=""padding:0px"">

                <a class=""demo-loading-btn btn btn-default"" style=""height:35px;color: #000;""");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\"", 447, "\"", 567, 4);
            WriteAttributeValue("", 477, "showInPopup(\'", 477, 13, true);
#nullable restore
#line 13 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
WriteAttributeValue("", 490, Url.Action("Create","Register",null,Context.Request.Scheme), 490, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 550, "\',\'New", 550, 6, true);
            WriteAttributeValue(" ", 556, "Register\')", 557, 11, true);
            EndWriteAttribute();
            WriteLiteral(@">Create New User </a>
            </div>
        </div>
        <div class=""portlet-body"">
            <div class=""table-scrollable"">
                <table class=""table table-bordered table-striped table-condensed table-hover dataTable "">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 22 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 25 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 28 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.emailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 31 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.mobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 34 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ccExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 37 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ccv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 42 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 46 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 49 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.emailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.mobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ccExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ccv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 64 "E:\Dicetek\DicetekSolution\Dicetek.MvcWebApplication\Views\Register\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>


    <div class=""modal"" tabindex=""-1"" id=""form-modal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content portlet box blue"">
                <div class=""modal-header portlet-title"">
                    <div class=""caption modal-title"">
                        <i class=""fa fa-gift""></i> Registertion Form
                    </div>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"" style=""margin-top: 15px !important;""></button>
                </div>
                <div class=""modal-body portlet-body form"">
                    
                </div>
            </div>
        </div>
    </div>
    <!-- END SAMPLE TABLE PORTLET-->
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dicetek.DomainModels.RegisterModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591