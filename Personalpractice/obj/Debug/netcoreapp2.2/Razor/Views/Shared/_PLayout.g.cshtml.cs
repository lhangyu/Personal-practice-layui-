#pragma checksum "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\Shared\_PLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2df2e71f8a639d08fc1a32bb69ac853910d2d328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PLayout), @"mvc.1.0.view", @"/Views/Shared/_PLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PLayout.cshtml", typeof(AspNetCore.Views_Shared__PLayout))]
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
#line 1 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df2e71f8a639d08fc1a32bb69ac853910d2d328", @"/Views/Shared/_PLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 2266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df2e71f8a639d08fc1a32bb69ac853910d2d3283641", async() => {
                BeginContext(29, 129, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\n    <title>");
                EndContext();
                BeginContext(159, 17, false);
#line 6 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\Shared\_PLayout.cshtml"
      Write(ViewData["title"]);

#line default
#line hidden
                EndContext();
                BeginContext(176, 363, true);
                WriteLiteral(@"</title>
    <link rel=""stylesheet"" href=""/layui/css/layui.css"">
    <script src=""/jquery.min.js""></script>
    <script src=""/jquery.haschange.js""></script>
    <script src=""/jquery.cookie.js""></script>
    <script src=""/layui/layui.all.js""></script>
    <script src=""/layui/formSelects.js""></script>
    <script src=""/layui/autocomplete.js""></script>
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 539, "\"", 593, 2);
                WriteAttributeValue("", 545, "/_js/framework_layui.js?time=", 545, 29, true);
#line 14 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\Shared\_PLayout.cshtml"
WriteAttributeValue("", 574, DateTime.Now.Ticks, 574, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(594, 154, true);
                WriteLiteral("></script>\n    <script src=\"/_js/echarts.common.min.js\"></script>\n    <script>\n        var DONOTUSE_IGNOREHASH = false;\n        var DONOTUSE_COOKIEPRE = \'");
                EndContext();
                BeginContext(749, 30, false);
#line 18 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\Shared\_PLayout.cshtml"
                             Write(ViewData["DONOTUSE_COOKIEPRE"]);

#line default
#line hidden
                EndContext();
                BeginContext(779, 38, true);
                WriteLiteral("\';\n        var DONOTUSE_WINDOWGUID = \'");
                EndContext();
                BeginContext(818, 42, false);
#line 19 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\Shared\_PLayout.cshtml"
                              Write(Guid.NewGuid().ToString().Replace("-", ""));

#line default
#line hidden
                EndContext();
                BeginContext(860, 1422, true);
                WriteLiteral(@"';
        $(function () {
            $(window).hashchange(function () {
                if (DONOTUSE_IGNOREHASH == true) {
                    DONOTUSE_IGNOREHASH = false;
                    return;
                }
                var hash = window.location.hash;
                if (hash == null || hash == '') {
                    hash = '/Home/FrontPage';
                }
                hash = hash.replace('#', '');
                ff.CloseAllDialog();
                ff.LoadPage(encodeURIComponent(hash));
            });
            $(window).hashchange();
        });
    </script>
    <style>
        .donotuse_pdiv {
            height: 100%;
            display: -webkit-box;
            display: -webkit-flex;
            display: -moz-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -webkit-flex-direction: column;
            -moz-box-orient: vertical;
            -moz-box-direction: n");
                WriteLiteral(@"ormal;
            -ms-flex-direction: column;
            flex-direction: column;
        }

        .donotuse_fill {
            -webkit-box-flex: 1;
            -webkit-flex: auto;
            -moz-box-flex: 1;
            -ms-flex: auto;
            flex: auto;
        }
         [lay-skin=primary].layui-form-checkbox span {
            padding-left:22px !important
        }   
    </style>
");
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
            BeginContext(2289, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2290, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df2e71f8a639d08fc1a32bb69ac853910d2d3288722", async() => {
                BeginContext(2322, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2328, 12, false);
#line 67 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\Shared\_PLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2340, 58, true);
                WriteLiteral("\n    <script>\n        layui.element.init();\n    </script>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2405, 7, true);
            WriteLiteral("</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591