#pragma checksum "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a4e90fe43a4a20fad93f1dd9e2d55ffbee96eb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\_ViewImports.cshtml"
using newtask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\_ViewImports.cshtml"
using newtask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a4e90fe43a4a20fad93f1dd9e2d55ffbee96eb5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb1e73f50df9aa4c3523f5881ffae551665c09f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
  
        ViewData["Title"] = "Home Page";
        string[] TableHeaders = new string[]
        {
            
            "Order No"
           ,"Order Date"
           ,"Customer Name"
           ,"Total Amount"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h4>List of Orders</h4>
</div>
    <div class=""text-center"">
        <div class="" table "" align=""center"">
            <table class="" table table-bordered table-hover "">
                <thead>
                    <tr>
");
#nullable restore
#line 21 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                         foreach (var head in TableHeaders)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 24 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                           Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 26 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n                </thead>\r\n               \r\n\r\n                <tbody>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a4e90fe43a4a20fad93f1dd9e2d55ffbee96eb55420", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                          
                            if (Model != null)
                            {
                                foreach (var data in Model)
                                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n\r\n                                    <td><a id=\" id_a\"");
                BeginWriteAttribute("href", " href=\"", 1161, "\"", 1197, 2);
                WriteAttributeValue("", 1168, "Home/Privacy?id=", 1168, 16, true);
#nullable restore
#line 41 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
WriteAttributeValue("", 1184, data.orderno, 1184, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"btnClick()\" >");
#nullable restore
#line 41 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                                                                                                            Write(data.orderno);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\r\n                                    <td>");
#nullable restore
#line 43 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                                   Write(data.orderdate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                                   Write(data.customername);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 45 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                                   Write(data.totalamount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\SD - Staff\Desktop\TASK\newtask\newtask\Views\Home\Index.cshtml"
                            }
                        }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591