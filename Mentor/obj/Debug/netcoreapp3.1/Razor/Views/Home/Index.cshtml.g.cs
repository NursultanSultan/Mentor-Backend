#pragma checksum "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c17fdaca36c100a6e203c58207013511c39f45ae"
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
#line 1 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\_ViewImports.cshtml"
using Mentor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\_ViewImports.cshtml"
using Mentor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\_ViewImports.cshtml"
using Mentor.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\_ViewImports.cshtml"
using Mentor.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c17fdaca36c100a6e203c58207013511c39f45ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2166aa91e29ddffa40d3b5c2937fafd6a8df2618", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hero-background-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("about-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Dictionary<string, string> settings = service.GetSetting();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Main statr -->\r\n<main>\r\n\r\n    <!-- Hero start -->\r\n    <section id=\"hero\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c17fdaca36c100a6e203c58207013511c39f45ae6361", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 286, "~/assets/image/", 286, 15, true);
#nullable restore
#line 13 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 301, settings["hero-background-img"], 301, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"container-fluid\">\r\n            <div class=\"hero-items\">\r\n                <h1>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
               Write(Html.Raw(settings["hero-title"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h1>\r\n                <h2>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
               Write(settings["hero-SubTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <a href=\"#\" class=\"hero-started-btn\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
               Write(settings["hero-started-btn"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </a>
            </div>
        </div>
    </section>
    <!-- Hero end -->
    <!-- About start -->
    <section id=""about"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-12"">
                    <div class=""about-text-items"">
                        <h2>
                            Voluptatem dignissimos provident quasi corporis voluptates sit assumenda.
                        </h2>
                        <p class=""about-content italic-text"">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit,
                            sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        </p>
                        <ul class=""about-check-lists"">
                            <li class=""about-content"">
                                <i class=""far fa-check-circle""></i>
                                Ullamco laboris nisi ut aliquip ex ea commodo con");
            WriteLiteral(@"sequat.
                            </li>
                            <li class=""about-content"">
                                <i class=""far fa-check-circle""></i>
                                voluptate trideta storacalaperda mastiro
                            </li>
                            <li class=""about-content"">
                                <i class=""far fa-check-circle""></i>
                                Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit
                                in voluptate trideta storacalaperda mastiro dolore eu fugiat nulla pariatur.
                            </li>
                        </ul>
                        <p class=""about-content"">
                            Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate
                        </p>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-1");
            WriteLiteral("2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c17fdaca36c100a6e203c58207013511c39f45ae11308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>
    <!-- About end -->
    <!-- why us start -->

    <section id=""why_us"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-12"">

                    <div class=""why-us-content"">
                        <h2>
                            Why Choose Mentor?
                        </h2>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Duis aute irure dolor in reprehenderit Asperiores dolores sed et.
                            Tenetur quia eos. Autem tempore quibusdam vel necessitatibus optio ad corporis.
                        </p>
                        <div class=""more-btn"">
                            <a href=""#"" class=""more-link"">
                                Learn More
                            </a>
            ");
            WriteLiteral(@"            </div>
                    </div>

                </div>
                <div class=""col-lg-8 col-md-12"">
                    <div class=""boxes"">
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-12 d-flex flex-colomn"">
                                <div class=""card-items"">
                                    <i class=""fas fa-file-invoice""></i>
                                    <h3>
                                        Corporis voluptates sit
                                    </h3>
                                    <p>
                                        Consequuntur sunt aut quasi enim aliquam quae harum pariatur laboris nisi ut aliquip
                                    </p>
                                </div>
                            </div>
                            <div class=""col-lg-4 col-md-12 d-flex flex-colomn"">
                                <div class=""card-items"">
                              ");
            WriteLiteral(@"      <i class=""far fa-square""></i>
                                    <h3>
                                        Ullamco laboris ladore pan
                                    </h3>
                                    <p>
                                        Consequuntur sunt aut quasi enim aliquam quae harum pariatur laboris nisi ut aliquip
                                    </p>
                                </div>
                            </div>
                            <div class=""col-lg-4 col-md-12 d-flex flex-colomn"">
                                <div class=""card-items"">
                                    <i class=""far fa-images""></i>
                                    <h3>
                                        Labore consequatur
                                    </h3>
                                    <p>
                                        Lorem ipsum dolor sit amet consectetur adipisicing elit.
                                        Expedita, soluta of");
            WriteLiteral(@"ficiis et libero distinctio dolores?
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- why us end -->
    <!-- Features start -->

    <section id=""feature"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div style=""color:#ffbb2c;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items"">
                        <i class=""fas fa-store""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div>

                <div style=""color: #5578ff;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items"">
                        <i class=""fas fa-store""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div");
            WriteLiteral(@">

                <div style=""color: #e80368;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items"">
                        <i class=""far fa-calendar-alt""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div>
                <div style=""color: #e361ff;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items"">
                        <i class=""fas fa-paint-roller""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div>

                <div style=""color: #5578ff;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items"">
                        <i class=""fas fa-store""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div>
                <div style=""color: #e361ff;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items");
            WriteLiteral(@""">
                        <i class=""fas fa-paint-roller""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div>
                <div style=""color:#ffbb2c;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items"">
                        <i class=""fas fa-store""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div>
                <div style=""color: #e80368;"" class=""col-lg-3 col-md-6 col-sm-12 mt-4"">
                    <div class=""feature-items"">
                        <i class=""far fa-calendar-alt""></i>
                        <h5>Lorem Impsum</h5>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- feature end -->
    <!-- ======= Popular Courses Section ======= -->
    <section id=""popular-courses"" class=""courses"">
        <div class=""container-fluid"" data-aos=""fade-up"">

            <div class=""sectio");
            WriteLiteral("n-title\">\r\n                <h2>Courses</h2>\r\n                <p>Popular Courses</p>\r\n            </div>\r\n\r\n            <div class=\"row\" data-aos=\"zoom-in\" data-aos-delay=\"100\">\r\n\r\n\r\n");
#nullable restore
#line 208 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
                 foreach (var course in Model.Courses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-md-0\">\r\n                        <div class=\"course-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c17fdaca36c100a6e203c58207013511c39f45ae19625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9442, "~/assets/image/", 9442, 15, true);
#nullable restore
#line 212 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9457, course.CourseImage, 9457, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"course-content\">\r\n                                <div class=\"d-flex justify-content-between align-items-center mb-3\">\r\n                                    <h4>");
#nullable restore
#line 215 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
                                   Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p class=\"price\">$ ");
#nullable restore
#line 216 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
                                                  Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n\r\n                                <h3><a href=\"course-details.html\">");
#nullable restore
#line 219 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
                                                             Write(course.CourseDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 221 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
                               Write(course.CourseContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <div class=""trainer d-flex justify-content-between align-items-center"">
                                    <div class=""trainer-profile d-flex align-items-center"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c17fdaca36c100a6e203c58207013511c39f45ae23187", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10328, "~/assets/image/", 10328, 15, true);
#nullable restore
#line 225 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10343, course.TrainerPhoto, 10343, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <span>");
#nullable restore
#line 226 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
                                         Write(course.TrainerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    \r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 233 "C:\Users\Home\Desktop\ExaminationPractise\Backend\Mentor\Mentor\Mentor\Views\Home\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Popular Courses Section -->\r\n\r\n</main>\r\n<!-- main end -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public HomeService service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
