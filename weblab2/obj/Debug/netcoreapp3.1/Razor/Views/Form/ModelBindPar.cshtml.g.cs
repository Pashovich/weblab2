#pragma checksum "C:\Users\USER\source\repos\weblab2\weblab2\Views\Form\ModelBindPar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bb0d49ae6468638e9b8ce17c8cac5afb9609a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_ModelBindPar), @"mvc.1.0.view", @"/Views/Form/ModelBindPar.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\weblab2\weblab2\Views\_ViewImports.cshtml"
using weblab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\weblab2\weblab2\Views\_ViewImports.cshtml"
using weblab2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bb0d49ae6468638e9b8ce17c8cac5afb9609a0", @"/Views/Form/ModelBindPar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea764a1b1a694c9db46ce13af76281336cb03f14", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_ModelBindPar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<weblab2.Models.FormModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "first", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "operation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "second", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::weblab2.TagHelpers.FieldTagHelper __weblab2_TagHelpers_FieldTagHelper;
        private global::weblab2.TagHelpers.SelectorTagHelper __weblab2_TagHelpers_SelectorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\USER\source\repos\weblab2\weblab2\Views\Form\ModelBindPar.cshtml"
  
    ViewData["Title"] = "ModelBind";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ModelBind</h1>\r\n\r\n");
            WriteLiteral("<h1>Index</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3bb0d49ae6468638e9b8ce17c8cac5afb9609a04910", async() => {
                WriteLiteral("\r\n    <div>\r\n        <div>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3bb0d49ae6468638e9b8ce17c8cac5afb9609a05194", async() => {
                }
                );
                __weblab2_TagHelpers_FieldTagHelper = CreateTagHelper<global::weblab2.TagHelpers.FieldTagHelper>();
                __tagHelperExecutionContext.Add(__weblab2_TagHelpers_FieldTagHelper);
                __weblab2_TagHelpers_FieldTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\USER\source\repos\weblab2\weblab2\Views\Form\ModelBindPar.cshtml"
                            WriteLiteral(Model.first);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __weblab2_TagHelpers_FieldTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __weblab2_TagHelpers_FieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n        <div>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("selector", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3bb0d49ae6468638e9b8ce17c8cac5afb9609a06944", async() => {
                }
                );
                __weblab2_TagHelpers_SelectorTagHelper = CreateTagHelper<global::weblab2.TagHelpers.SelectorTagHelper>();
                __tagHelperExecutionContext.Add(__weblab2_TagHelpers_SelectorTagHelper);
                __weblab2_TagHelpers_SelectorTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\USER\source\repos\weblab2\weblab2\Views\Form\ModelBindPar.cshtml"
                                     WriteLiteral(Model.operation);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __weblab2_TagHelpers_SelectorTagHelper.Default = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("default", __weblab2_TagHelpers_SelectorTagHelper.Default, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n        <div>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3bb0d49ae6468638e9b8ce17c8cac5afb9609a08740", async() => {
                }
                );
                __weblab2_TagHelpers_FieldTagHelper = CreateTagHelper<global::weblab2.TagHelpers.FieldTagHelper>();
                __tagHelperExecutionContext.Add(__weblab2_TagHelpers_FieldTagHelper);
                __weblab2_TagHelpers_FieldTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\USER\source\repos\weblab2\weblab2\Views\Form\ModelBindPar.cshtml"
                             WriteLiteral(Model.second);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __weblab2_TagHelpers_FieldTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __weblab2_TagHelpers_FieldTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n    </div>\r\n    <input type=\"submit\" value=\"cals\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<weblab2.Models.FormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
