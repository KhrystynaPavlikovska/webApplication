#pragma checksum "C:\Users\Lenovo\Desktop\different\university\LNU3course1term\прогр та підтр ВЕБзастосувань\bookStore\webApplication\Store\WebShop\Views\Roles\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97c1b053bee6e29c6a35e42b44590d502cb8565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_UserList), @"mvc.1.0.view", @"/Views/Roles/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/UserList.cshtml", typeof(AspNetCore.Views_Roles_UserList))]
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
#line 1 "C:\Users\Lenovo\Desktop\different\university\LNU3course1term\прогр та підтр ВЕБзастосувань\bookStore\webApplication\Store\WebShop\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\different\university\LNU3course1term\прогр та підтр ВЕБзастосувань\bookStore\webApplication\Store\WebShop\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97c1b053bee6e29c6a35e42b44590d502cb8565", @"/Views/Roles/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a2d3243e7918bc5943bcc5824e6d1c4a9688f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebShop.Data.Models.ShopUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 43, true);
            WriteLiteral("\n<h2> List user</h2>\n<table class=\"table\">\n");
            EndContext();
#line 5 "C:\Users\Lenovo\Desktop\different\university\LNU3course1term\прогр та підтр ВЕБзастосувань\bookStore\webApplication\Store\WebShop\Views\Roles\UserList.cshtml"
   foreach (var user in Model)
  {

#line default
#line hidden
            BeginContext(127, 19, true);
            WriteLiteral("    <tr>\n      <td>");
            EndContext();
            BeginContext(147, 13, false);
#line 8 "C:\Users\Lenovo\Desktop\different\university\LNU3course1term\прогр та підтр ВЕБзастосувань\bookStore\webApplication\Store\WebShop\Views\Roles\UserList.cshtml"
     Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(160, 25, true);
            WriteLiteral("</td>\n      <td>\n        ");
            EndContext();
            BeginContext(185, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97c1b053bee6e29c6a35e42b44590d502cb85654937", async() => {
                BeginContext(265, 11, true);
                WriteLiteral("Permissions");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Lenovo\Desktop\different\university\LNU3course1term\прогр та підтр ВЕБзастосувань\bookStore\webApplication\Store\WebShop\Views\Roles\UserList.cshtml"
                                                                  WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(280, 23, true);
            WriteLiteral("\n      </td>\n    </tr>\n");
            EndContext();
#line 13 "C:\Users\Lenovo\Desktop\different\university\LNU3course1term\прогр та підтр ВЕБзастосувань\bookStore\webApplication\Store\WebShop\Views\Roles\UserList.cshtml"
  }

#line default
#line hidden
            BeginContext(307, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebShop.Data.Models.ShopUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
