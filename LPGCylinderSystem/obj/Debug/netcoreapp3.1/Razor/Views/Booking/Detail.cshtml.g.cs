#pragma checksum "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cadda980b00645792adcd75a8afae97208eb027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Detail), @"mvc.1.0.view", @"/Views/Booking/Detail.cshtml")]
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
#line 1 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cadda980b00645792adcd75a8afae97208eb027", @"/Views/Booking/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62efaadd6ea989c58047208d60664bfac5ab79be", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LPGCylinderSystem.Models.Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/assets/css/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/assets/css/templatemo-softy-pinko.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:15px;margin-bottom:15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Complaint", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:15px;margin-top:15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Resolved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
   ViewData["Title"] = "Your Bookings"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0cadda980b00645792adcd75a8afae97208eb0277462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0cadda980b00645792adcd75a8afae97208eb0278658", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0cadda980b00645792adcd75a8afae97208eb0279854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<div style=\"background-color: #F2F2FE \">\n");
#nullable restore
#line 8 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
     if (ViewBag.Error == "Eroor")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>No bookings yet!!!!</h1> ");
#nullable restore
#line 10 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                             }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
                <br />
                                <br />
                                                <br />
                                                                <br />
                                                                                <br />
                                                                                                <h1 style=""        padding-left: 180px"">Your Bookings</h1>
                                                                                                                <hr />
");
#nullable restore
#line 21 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                                 foreach (var item in Model)
                                                                                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                                                <div style="" padding-left: 200px"">
                                                                                                                    <br />
                                                                                                                    <h4>Booking</h4>
                                                                                                                    <hr />

                                                                                                                    <dl class=""row"">
                                                                                                                        <dt class=""col-sm-2"">
                                                                                                                            ");
#nullable restore
#line 30 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(Html.DisplayNameFor(item => item.Booking_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dt>
                                                                                                                        <dd class=""col-sm-10"">
                                                                                                                            ");
#nullable restore
#line 33 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(item.Booking_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dd>
                                                                                                                        <dt class=""col-sm-2"">
                                                                                                                            ");
#nullable restore
#line 36 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(Html.DisplayNameFor(item => item.PaymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dt>
                                                                                                                        <dd class=""col-sm-10"">
                                                                                                                            ");
#nullable restore
#line 39 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dd>
                                                                                                                        <dt class=""col-sm-2"">
                                                                                                                            ");
#nullable restore
#line 42 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(Html.DisplayNameFor(item => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dt>
                                                                                                                        <dd class=""col-sm-10"">
                                                                                                                            ");
#nullable restore
#line 45 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" INR
                                                                                                                        </dd>
                                                                                                                        <dt class=""col-sm-2"">
                                                                                                                            ");
#nullable restore
#line 48 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(Html.DisplayNameFor(item => item.SubsidyAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dt>
                                                                                                                        <dd class=""col-sm-10"">
                                                                                                                            ");
#nullable restore
#line 51 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(item.SubsidyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dd>
                                                                                                                        <dt class=""col-sm-2"">
                                                                                                                            ");
#nullable restore
#line 54 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(Html.DisplayNameFor(item => item.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dt>
                                                                                                                        <dd class=""col-sm-10"">
                                                                                                                            ");
#nullable restore
#line 57 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(item.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dd>
                                                                                                                        <dt class=""col-sm-2"">
                                                                                                                            ");
#nullable restore
#line 60 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(Html.DisplayNameFor(item => item.DAC));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dt>
                                                                                                                        <dd class=""col-sm-10"">
                                                                                                                            ");
#nullable restore
#line 63 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(item.DAC);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dd>
                                                                                                                        <dt class=""col-sm-2"">
                                                                                                                            ");
#nullable restore
#line 66 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(Html.DisplayNameFor(item => item.BookingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dt>
                                                                                                                        <dd class=""col-sm-10"">
                                                                                                                            ");
#nullable restore
#line 69 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       Write(item.BookingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                                        </dd>
                                                                                                                        <dd>
                                                                                                                            <br />
                                                                                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cadda980b00645792adcd75a8afae97208eb02724653", async() => {
                WriteLiteral("Make Complaint for Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                                                                                                                                              WriteLiteral(item.Booking_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;&nbsp;&nbsp;\n                                                                                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cadda980b00645792adcd75a8afae97208eb02727578", async() => {
                WriteLiteral("Resolved Complaint for Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                                                                                                                                                 WriteLiteral(item.Booking_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                                                                        </dd>
                                                                                                                    </dl>
                                                                                                                </div>
                                                                                                                <br />");
#nullable restore
#line 78 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "E:\Latest W UI (1)\Latest W UI\Latest With UI\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LPGCylinderSystem.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
