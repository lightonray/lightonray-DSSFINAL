#pragma checksum "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b42873aed7508a2f3dbf5bc392ecdb60164881de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Detail), @"mvc.1.0.view", @"/Views/Branch/Detail.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\_ViewImports.cshtml"
using LibraryData.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42873aed7508a2f3dbf5bc392ecdb60164881de", @"/Views/Branch/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c721947eaca4891655febc0107430cc3163cab", @"/Views/_ViewImports.cshtml")]
    public class Views_Branch_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Branch.BranchDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid d-block mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
  
    ViewBag.Title = "Branch details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"clearfix detailHeading\">\n        <h2 class=\"text-center my-4\">");
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    </div>\n\n    <div class=\"jumbotron\">\n        <div class=\"row branchInfo\">\n            <div class=\"col-sm-7 mx-auto text-dark text-center\">\n                <div>\n                    <p>");
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n        </div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b42873aed7508a2f3dbf5bc392ecdb60164881de5315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                        WriteLiteral(Model.ImageUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n        <div class=\"detailInfo mt-4\">\n            <table style=\"margin-left: auto; margin-right: auto\">\n                <tr class=\"text-center\">\n                    <td class=\"itemLabel\">Address: </td>\n                    <td class=\"itemValue\">");
#nullable restore
#line 27 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                     Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr class=\"text-center\">\n                    <td class=\"itemLabel\">Telephone: </td>\n                    <td class=\"itemValue\">");
#nullable restore
#line 31 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                     Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr class=\"text-center\">\n                    <td class=\"itemLabel\">Date Opened: </td>\n                    <td class=\"itemValue\">");
#nullable restore
#line 35 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                     Write(Model.OpenDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr class=\"text-center\">\n                    <td class=\"itemLabel\">Number Of Patrons: </td>\n                    <td class=\"itemValue\">");
#nullable restore
#line 39 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                     Write(Model.NumberOfPatrons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr class=\"text-center\">\n                    <td class=\"itemLabel\">Number Of Assets: </td>\n                    <td class=\"itemValue\">");
#nullable restore
#line 43 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                     Write(Model.NumberOfAssets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr class=\"text-center\">\n                    <td class=\"itemLabel\">Value Of Assets: </td>\n                    <td class=\"itemValue\">");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                     Write(Model.TotalAssetValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n            </table>\n        </div>\n\n        <div class=\"row branchInfo mt-4\">\n            <div class=\"col-md-6 mx-auto text-dark text-center\">\n                <ul class=\"list-group\">\n");
#nullable restore
#line 55 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                     foreach (var day in Model.HoursOpen)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item border-0\" style=\"background-color: #e9ecef\">");
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                                                                                          Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 58 "C:\Users\Administrator\Desktop\Library-Management-System-master\Library\Views\Branch\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n                <div class=\"mt-4\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b42873aed7508a2f3dbf5bc392ecdb60164881de11570", async() => {
                WriteLiteral("Back to list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Branch.BranchDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
