#pragma checksum "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbfe219151e43245592c09a6202b78b502cb6029"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\_ViewImports.cshtml"
using TomarUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\_ViewImports.cshtml"
using TomarUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbfe219151e43245592c09a6202b78b502cb6029", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00aafc5a72db4d81d654fa4be0fef412adc6c92c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/profile_img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("You cannot see my profile photo for now:/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/toros-university-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo_pwsz_jaroslaw.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/temsa-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/kardelen-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";
    ViewData["HeaderImage"] = $"../../img/blur-city.jpg";
    ViewData["HeaderTitle"] = $"About";
    ViewData["SubHeader"] = "Thank you for feeling a need to know me :)";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral(@"
    <style type=""text/css"">
        body {
            /* Center and scale the image nicely */
            background-image: url('../../img/white-hexagonal-line-pattern.jpg');
            background-position: center;
            background-repeat: repeat-y;
            background-size: cover;
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<div class=""content"">
    <div id=""main"">
        <div class=""tab-wrap"">
            <div class=""tab-menu"">
                <button class=""tab-links"" onclick=""openTab(event, 'profile')"" id=""defaultOpen"">PROFILE</button>
                <button class=""tab-links"" onclick=""openTab(event, 'education')"">EDUCATION</button>
                <button class=""tab-links"" onclick=""openTab(event, 'experience')"">EXPERIENCE</button>
                <button class=""tab-links"" onclick=""openTab(event, 'skills')"">SKILLS</button>
            </div>
            <div class=""tab-content-about"" id=""profile"">
                <div class=""div-profile"">
                    <figure>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bbfe219151e43245592c09a6202b78b502cb60297702", async() => {
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
            WriteLiteral(@"
                    </figure>
                    <h1 class=""header-owner"">Mete Kaba</h1>
                    <center><p>A software engineer with a desire to build stable and powerful applications for people. Working as a team is one of the primary goals. Extensive collaboration ability to work with a team. Got experience in local and web applications using C # WPF, ASP.Net, Java, PHP, and MSSQL database technologies. Experience in GitHub version control system to work remotely and collaboratively. Love learning new things and tools.</p></center>
                </div>
                <div class=""div-experience"">
                    <div class=""sub-div-experience"">
                        <h1 class=""experience-year"">1</h1>
                    </div>
                    <div class=""sub-div-experience"">
                        <h3 class=""experience-text"">Years of experience in Web Programming</h3>
                    </div>
                </div>
                <div class=""div-experience"">
     ");
            WriteLiteral(@"               <div class=""sub-div-experience"">
                        <h1 class=""experience-year"">3</h1>
                    </div>
                    <div class=""sub-div-experience"">
                        <h3 class=""experience-text"">Years of experience in Desktop Programming (especially C# WPF)</h3>
                    </div>
                </div>
                <div class=""div-experience-sum"">
                    <small>Sorry for my years of experience:/ As a new graduated student, let's talk frankly :)</small>
                </div>
                <div class=""div-social"">
                    <ul id=""list-social"">
                        <li><a href=""https://www.instagram.com/metekaba"" title=""Instagram""><i class=""fab fa-instagram""></i></a></li>
                        <li><a href=""https://www.youtube.com/channel/UC5Xq8BrAJPB86Tzl42oKa3g"" title=""YouTube""><i class=""fab fa-youtube""></i></a></li>
                        <li><a href=""https://www.linkedin.com/in/mete-kaba-89b5221b8/"" title=""");
            WriteLiteral(@"Linkedin""><i class=""fab fa-linkedin""></i></a></li>
                        <li><a href=""https://github.com/MeteK7"" title=""Github""><i class=""fab fa-github""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""tab-content-about"" id=""education"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <p>Here is my low-level education.</p>
                        <div class=""div-corporation"">
                            <div class=""div-logo"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbfe219151e43245592c09a6202b78b502cb602911657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                            <div class=""div-text"">
                                <h3 class=""corporation"">Toros University</h3>
                                <small>2015-2020</small>
                                <p class=""topic"">Computer and Software Engineering in Bachelor's Degree</p>
                            </div>
                        </div>
                        <div class=""div-corporation"">
                            <div class=""div-logo"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbfe219151e43245592c09a6202b78b502cb602913321", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""div-text"">
                                <h3 class=""corporation"">PWSTE w Jarosławiu</h3>
                                <small>2018-2018</small>
                                <p class=""topic"">Erasmus+ Programme</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""tab-content-about"" id=""experience"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <p>I had chance to work with these cool companies.</p>
                        <div class=""div-corporation"">
                            <div class=""div-logo"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbfe219151e43245592c09a6202b78b502cb602915252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""div-text"">
                                <h3 class=""corporation"">Temsa Global</h3>
                                <small>03/02/2020-15/05/2020</small>
                                <p class=""topic"">Long-Term Internship</p>
                            </div>
                        </div>
                        <div class=""div-corporation"">
                            <div class=""div-logo"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbfe219151e43245592c09a6202b78b502cb602916890", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""div-text"">
                                <h3 class=""corporation"">Kardelen Software</h3>
                                <small>06/24/2019-07/24/2019</small>
                                <p class=""topic"">Summer Internship</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""tab-content-about"" id=""skills"">
                <div class=""col-md-12"">
                    <p>Have a look at my skills. Someone must have used a special device to identify my knowledge in percentage:)</p>
                </div>
                <div class=""row-skills"">
                    <div class=""skill-container"">
                        <span><strong>C#</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage c-sharp"">50%</div>
                        </div>
 ");
            WriteLiteral(@"                       <span><strong>MVC</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage mvc"">60%</div>
                        </div>
                        <span><strong>Java</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage java"">30%</div>
                        </div>
                    </div>
                    <div class=""skill-container"">
                        <span><strong>Arduino</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage arduino"">80%</div>
                        </div>
                        <span><strong>HTML</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage html"">70%</div>
                        </div>
                        <span><strong>CSS</strong></span>
   ");
            WriteLiteral(@"                     <div class=""skill-progress"">
                            <div class=""skill-percentage css"">70%</div>
                        </div>
                    </div>
                    <div class=""skill-container"">
                        <span><strong>JavaScript</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage java-script"">50%</div>
                        </div>
                        <span><strong>PHP</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage php"">40%</div>
                        </div>
                        <span><strong>MySQL</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage mysql"">50%</div>
                        </div>
                    </div>
                    <div class=""skill-container"">
                        <span><strong");
            WriteLiteral(@">MSSQL</strong></span>
                        <div class=""skill-progress"">
                            <div class=""skill-percentage mssql"">55%</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
