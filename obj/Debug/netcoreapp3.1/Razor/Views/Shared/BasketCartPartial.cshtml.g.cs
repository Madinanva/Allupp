#pragma checksum "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6481738467e815e5ff017037573772148f5f16c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BasketCartPartial), @"mvc.1.0.view", @"/Views/Shared/BasketCartPartial.cshtml")]
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
#line 2 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.ShopVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels.Header;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6481738467e815e5ff017037573772148f5f16c", @"/Views/Shared/BasketCartPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d3073d1ef58bc0c076af761e6aee998223e0918", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BasketCartPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<ul class=\"cart-items\">\n");
#nullable restore
#line 4 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
     foreach (BasketVM basketVM in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n            <div class=\"single-cart-item d-flex\">\n                <div class=\"cart-item-thumb\">\n                    <a href=\"single-product.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6481738467e815e5ff017037573772148f5f16c4793", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 271, "~/assets/images/product/", 271, 24, true);
#nullable restore
#line 9 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
AddHtmlAttributeValue("", 295, basketVM.Image, 295, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                    <span class=\"product-quantity\">");
#nullable restore
#line 10 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
                                               Write(basketVM.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("x</span>\n                </div>\n                <div class=\"cart-item-content media-body\">\n                    <h5 class=\"product-name\"><a href=\"single-product.html\">");
#nullable restore
#line 13 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
                                                                      Write(basketVM.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\n                    <span class=\"product-price\">???18.90</span>\n");
            WriteLiteral("                    <a href=\"#\" class=\"product-close\"><i class=\"fal fa-times\"></i></a>\n                </div>\n            </div>\n        </li>\n");
#nullable restore
#line 20 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</ul>\n<div class=\"price_content\">\n    <div class=\"cart-subtotals\">\n        <div class=\"products price_inline\">\n            <span class=\"label\">Subtotal</span>\n            <span class=\"value\">???");
#nullable restore
#line 27 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
                             Write(Model.Sum(b=>b.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n");
            WriteLiteral("        <div class=\"tax price_inline\">\n            <span class=\"label\">Taxes</span>\n            <span class=\"value\">???");
#nullable restore
#line 35 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
                             Write(Model.Sum(b=>b.ExTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n    </div>\n    <div class=\"cart-total price_inline\">\n        <span class=\"label\">Total</span>\n        <span class=\"value\">???");
#nullable restore
#line 40 "C:\Users\Madina Nva\Desktop\Allup\Allup\Views\Shared\BasketCartPartial.cshtml"
                         Write(Model.Sum(b=>b.Price)+ (Model.Sum(b => b.ExTax)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    </div>\n</div> <!-- price content -->\n<div class=\"checkout text-center\">\n    <a href=\"checkout.html\" class=\"main-btn\">Checkout</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
