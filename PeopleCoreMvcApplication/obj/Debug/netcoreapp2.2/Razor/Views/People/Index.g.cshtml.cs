#pragma checksum "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc12042f7f18aa5ed5f11489b3bda74ae2cdfe19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Index.cshtml", typeof(AspNetCore.Views_People_Index))]
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
#line 1 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\_ViewImports.cshtml"
using PeopleCoreMvcApplication;

#line default
#line hidden
#line 2 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\_ViewImports.cshtml"
using PeopleCoreMvcApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc12042f7f18aa5ed5f11489b3bda74ae2cdfe19", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069309938466db9c6fc4c21ee74a7ffe81dde4bb", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PeopleCoreMvcApplication.Models.Person>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(103, 20, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
 if (@TempData["Result"] != null && @TempData["Result"].ToString() != "")
{

#line default
#line hidden
            BeginContext(201, 239, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\" id=\"success-alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        <strong>Success!</strong> ");
            EndContext();
            BeginContext(441, 29, false);
#line 13 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
                             Write(TempData["Result"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(470, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
}

#line default
#line hidden
            BeginContext(487, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(498, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc12042f7f18aa5ed5f11489b3bda74ae2cdfe195216", async() => {
                BeginContext(521, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(535, 58, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(699, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(734, 40, false);
#line 27 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(774, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(830, 41, false);
#line 30 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(871, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(927, 41, false);
#line 33 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(968, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1103, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
            BeginContext(1238, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1281, 39, false);
#line 46 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1388, 40, false);
#line 49 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1496, 40, false);
#line 52 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1536, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1604, 53, false);
#line 55 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1682, 59, false);
#line 56 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1766, 57, false);
#line 57 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1823, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Developer\source\repos\PeopleCoreMvcApplication\PeopleCoreMvcApplication\Views\People\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1878, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1922, 238, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        window.setTimeout(function() {\r\n            $(\"#success-alert\").fadeTo(500, 0).slideUp(500, function(){\r\n                $(this).remove();\r\n            });\r\n        }, 4000);\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PeopleCoreMvcApplication.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591