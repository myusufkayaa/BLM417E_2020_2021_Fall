#pragma checksum "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dbdacceb91c918128810517e78c53317849ecc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbdacceb91c918128810517e78c53317849ecc8", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lesson5App1.Models.Department>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(78, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(105, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eff9d0d4569406ca412989d76d48633", async() => {
                BeginContext(111, 92, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n   \r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(212, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c4d79491d84ae2a9a90b65185e0bb1", async() => {
                BeginContext(218, 12, true);
                WriteLiteral("\r\n    <div> ");
                EndContext();
                BeginContext(231, 12, false);
#line 17 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
     Write(Model.DeptId);

#line default
#line hidden
                EndContext();
                BeginContext(243, 4, true);
                WriteLiteral("  - ");
                EndContext();
                BeginContext(248, 10, false);
#line 17 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
                      Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(258, 23, true);
                WriteLiteral("  </div>\r\n    <p></p>\r\n");
                EndContext();
#line 19 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
     foreach (var e in Model.employees){

#line default
#line hidden
                BeginContext(323, 18, true);
                WriteLiteral("        <div> Id: ");
                EndContext();
                BeginContext(342, 4, false);
#line 20 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
             Write(e.Id);

#line default
#line hidden
                EndContext();
                BeginContext(346, 13, true);
                WriteLiteral("  FirstName: ");
                EndContext();
                BeginContext(360, 11, false);
#line 20 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
                               Write(e.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(371, 12, true);
                WriteLiteral("  LastName: ");
                EndContext();
                BeginContext(384, 10, false);
#line 20 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
                                                       Write(e.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(394, 10, true);
                WriteLiteral("</div>  \r\n");
                EndContext();
#line 21 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(411, 9, true);
                WriteLiteral("    <div>");
                EndContext();
                BeginContext(421, 13, false);
#line 22 "C:\Users\alinizam\source\repos\Lesson5App1\Lesson5App1\Views\Home\Index.cshtml"
    Write(ViewBag.title);

#line default
#line hidden
                EndContext();
                BeginContext(434, 11, true);
                WriteLiteral(" </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lesson5App1.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
