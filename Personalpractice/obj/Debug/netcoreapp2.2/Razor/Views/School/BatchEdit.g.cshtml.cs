#pragma checksum "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2078a55ae7aafbe0289d6e518b3e9d79b8650da5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_BatchEdit), @"mvc.1.0.view", @"/Views/School/BatchEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/School/BatchEdit.cshtml", typeof(AspNetCore.Views_School_BatchEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2078a55ae7aafbe0289d6e518b3e9d79b8650da5", @"/Views/School/BatchEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_School_BatchEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Personalpractice.ViewModels.SchoolVMs.SchoolBatchVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden-panel", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.DataTableTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2078a55ae7aafbe0289d6e518b3e9d79b8650da54286", async() => {
                BeginContext(81, 55, true);
                WriteLiteral("\n    <div style=\"margin-bottom:10px\">批量修改以下数据: </div>\r\n");
                EndContext();
                BeginContext(136, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2078a55ae7aafbe0289d6e518b3e9d79b8650da54727", async() => {
                    BeginContext(180, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(182, 43, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:combobox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2078a55ae7aafbe0289d6e518b3e9d79b8650da55130", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper);
#line 6 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.SchoolType);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(225, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#line 5 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow = ItemsPerRowEnum.Two;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("items-per-row", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(236, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(241, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2078a55ae7aafbe0289d6e518b3e9d79b8650da58136", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#line 8 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Ids);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(266, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(271, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2078a55ae7aafbe0289d6e518b3e9d79b8650da59755", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DataTableTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper);
#line 9 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ListVM);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.UseLocalData = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("use-local-data", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.UseLocalData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Height = 300;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.HiddenCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("hidden-checkbox", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.HiddenCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(372, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(377, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2078a55ae7aafbe0289d6e518b3e9d79b8650da512829", async() => {
                    BeginContext(410, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(419, 19, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:submitbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2078a55ae7aafbe0289d6e518b3e9d79b8650da513239", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(438, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(447, 18, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2078a55ae7aafbe0289d6e518b3e9d79b8650da514449", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(465, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#line 10 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align =  AlignEnum.Right;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("align", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(479, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper);
#line 3 "E:\lhy\Personal-practice\layui\Personal-practice-layui-\Personalpractice\Views\School\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Personalpractice.ViewModels.SchoolVMs.SchoolBatchVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
