#pragma checksum "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18350b824ee5c7089ab371d2ebd98cc3a180e4c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Details.cshtml", typeof(AspNetCore.Views_Order_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18350b824ee5c7089ab371d2ebd98cc3a180e4c1", @"/Views/Order/Details.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.App.Models.DomainModels.Order>
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
#line 2 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(66, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(91, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e95a0af3df6440980de01e566fc534d", async() => {
                BeginContext(97, 86, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Details</title>\n");
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
            BeginContext(190, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(191, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762e0ff1a7164d5e946d29eacd50abe5", async() => {
                BeginContext(197, 9, true);
                WriteLiteral("\n    <h1>");
                EndContext();
                BeginContext(207, 17, false);
#line 14 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(224, 33, true);
                WriteLiteral("</h1>\n    <ul>\n        <li>Name: ");
                EndContext();
                BeginContext(258, 20, false);
#line 16 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
             Write(Model.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(278, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(280, 19, false);
#line 16 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
                                   Write(Model.User.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(299, 27, true);
                WriteLiteral("</li>\n        <li>Address: ");
                EndContext();
                BeginContext(327, 18, false);
#line 17 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
                Write(Model.User.Address);

#line default
#line hidden
                EndContext();
                BeginContext(345, 25, true);
                WriteLiteral("</li>\n        <li>Phone: ");
                EndContext();
                BeginContext(371, 16, false);
#line 18 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
              Write(Model.User.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(387, 25, true);
                WriteLiteral("</li>\n        <li>Pizza: ");
                EndContext();
                BeginContext(413, 11, false);
#line 19 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
              Write(Model.Pizza);

#line default
#line hidden
                EndContext();
                BeginContext(424, 25, true);
                WriteLiteral("</li>\n        <li>Price: ");
                EndContext();
                BeginContext(450, 11, false);
#line 20 "C:\Users\Kate\Desktop\ASP.NET\SEDC.PizzApp\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
              Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(461, 16, true);
                WriteLiteral("</li>\n    </ul>\n");
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
            BeginContext(484, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.App.Models.DomainModels.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
