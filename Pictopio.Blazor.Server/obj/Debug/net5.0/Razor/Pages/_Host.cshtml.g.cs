#pragma checksum "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d9e3292ada3b890fc9ef7b03d27ef352c49033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pictopio.Blazor.Server.Pages__Host), @"mvc.1.0.razor-page", @"/Pages/_Host.cshtml")]
namespace Pictopio.Blazor.Server
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
#line 4 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
using DevExpress.ExpressApp.Blazor.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d9e3292ada3b890fc9ef7b03d27ef352c49033", @"/Pages/_Host.cshtml")]
    public class Pages__Host : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d9e3292ada3b890fc9ef7b03d27ef352c490333716", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, shrink-to-fit=no"" />
    <meta name=""apple-mobile-web-app-capable"" content=""yes"" />
    <!-- meta name=""theme-color"" content=""#000000"" -->
    <title>Pictopio</title>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d9e3292ada3b890fc9ef7b03d27ef352c490334285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d9e3292ada3b890fc9ef7b03d27ef352c490335376", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 16 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(BootstrapThemeLink);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Static;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d9e3292ada3b890fc9ef7b03d27ef352c490338120", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
      
        string userAgent = Request.Headers["User-Agent"];
        bool isIE = userAgent.Contains("MSIE") || userAgent.Contains("Trident");
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
     if(isIE) {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <link href=""css/site.css"" rel=""stylesheet"" />
        <div class=""d-flex flex-column justify-content-center align-items-center h-100"">
            <div class=""d-flex"">
                <img class=""mt-2 mr-4"" src=""_content/DevExpress.ExpressApp.Blazor/images/Sad.svg"" width=""60"" height=""60"" />
                <div>
                    <div class=""h1"">Internet Explorer is not supported.</div>
                    <p style=""font-size: 1rem; opacity: 0.75;"" class=""m-0"">Pictopio cannot be loaded in Internet Explorer.<br>Please use a different browser.</p>
                </div>
            </div>
        </div>
");
#nullable restore
#line 34 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
    }
    else {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d9e3292ada3b890fc9ef7b03d27ef352c490339836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 36 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(SplashScreen);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Static;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("param-Caption", "Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper", "Parameters"));
                }
#nullable restore
#line 36 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Caption"] = "Pictopio";

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("param-Caption", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Caption"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 36 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["ImagePath"] = "images/SplashScreen.svg";

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("param-ImagePath", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["ImagePath"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"        <link href=""_content/DevExpress.Blazor/dx-blazor.css"" rel=""stylesheet"" />
        <link href=""_content/DevExpress.ExpressApp.Blazor/styles.css"" rel=""stylesheet"" />
        <link href=""css/site.css"" rel=""stylesheet"" />
        <script src=""_content/DevExpress.ExpressApp.Blazor/scripts.js""></script>
");
                WriteLiteral("        <app class=\"d-none\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d9e3292ada3b890fc9ef7b03d27ef352c4903313691", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 44 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(App);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Server;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </app>\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d9e3292ada3b890fc9ef7b03d27ef352c4903315774", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 47 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(AlertsHandler);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Server;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("        <div id=\"blazor-error-ui\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d9e3292ada3b890fc9ef7b03d27ef352c4903317893", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 50 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(BlazorError);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Static;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n");
                WriteLiteral("        <script src=\"_framework/blazor.server.js\"></script>\r\n");
#nullable restore
#line 54 "C:\Users\Gerard\Documents\GitHub\Pictopio.Web.github.io\Pictopio.Blazor.Server\Pages\_Host.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages__Host> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages__Host> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages__Host>)PageContext?.ViewData;
        public Pages__Host Model => ViewData.Model;
    }
}
#pragma warning restore 1591
