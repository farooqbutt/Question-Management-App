#pragma checksum "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f51e3330d48d24a57b64fab8053958946565277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SeeAnswer), @"mvc.1.0.view", @"/Views/Home/SeeAnswer.cshtml")]
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
#line 1 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\_ViewImports.cshtml"
using QuestionsManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\_ViewImports.cshtml"
using QuestionsManagementApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f51e3330d48d24a57b64fab8053958946565277", @"/Views/Home/SeeAnswer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4010a59236c04fb7e49754f0b1aaa556e3735b1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SeeAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionsManagementApp.Models.Questions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyQuestions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
  
    ViewData["Title"] = "SeeAnswer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Answer of Question</h1>\r\n\r\n<div>\r\n    <h4>Answer and Details of your Question</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            Case No. :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.CaseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Member Name :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayNameFor(model => model.Urgent));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.Urgent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Submission Date :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
        <dt class = ""col-sm-2"">
            Asked By : 
        </dt>
        <dd class = ""col-sm-10"">
            You
        </dd>
        <dt class = ""col-sm-2"">
            Answer of Question :
        </dt>
        <dd class = ""col-sm-10"">
            ");
#nullable restore
#line 53 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.AnswertoQuestion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Answered By :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.Answeredby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Question Type :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\SeeAnswer.cshtml"
       Write(Html.DisplayFor(model => model.QuestionType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f51e3330d48d24a57b64fab80539589465652778424", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionsManagementApp.Models.Questions> Html { get; private set; }
    }
}
#pragma warning restore 1591
