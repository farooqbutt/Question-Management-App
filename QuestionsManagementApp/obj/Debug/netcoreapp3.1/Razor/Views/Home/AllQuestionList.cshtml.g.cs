#pragma checksum "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bea197fde7b343e1780c1ee510bd2ab1c519c671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllQuestionList), @"mvc.1.0.view", @"/Views/Home/AllQuestionList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bea197fde7b343e1780c1ee510bd2ab1c519c671", @"/Views/Home/AllQuestionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4010a59236c04fb7e49754f0b1aaa556e3735b1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllQuestionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuestionsManagementApp.Models.Questions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("QType"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("FilterQuestions()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("QStatus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
  
    ViewData["Title"] = "All Question";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of All Questions</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea197fde7b343e1780c1ee510bd2ab1c519c6716312", async() => {
                WriteLiteral("Submit New Question");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <span>Total Questions : ");
#nullable restore
#line 12 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                       Write(Model.ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <span style=\"float:right\">Answered Questions : ");
#nullable restore
#line 13 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                                              Write(Model.ToList().Where(a => a.AnswertoQuestion != "").Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n<p>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea197fde7b343e1780c1ee510bd2ab1c519c6718426", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea197fde7b343e1780c1ee510bd2ab1c519c6718702", async() => {
                    WriteLiteral("Select Question Type");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 19 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.types;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea197fde7b343e1780c1ee510bd2ab1c519c67111802", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea197fde7b343e1780c1ee510bd2ab1c519c67112079", async() => {
                    WriteLiteral("Select Question Status");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 24 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Status;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <a class=\"btn btn-sm btn-success\" style=\"float:right\" href=\"/Home/AllQuestionList\" title=\"Load All Questions\">Load All</a>\r\n");
#nullable restore
#line 30 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
             if (User.IsInRole("Supervisor"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button onclick=\"ExportToExcel()\" style=\"float:right;margin-right:5px\" class=\"btn btn-sm btn-outline-info\" title=\"Export All Question to Excel\">Export Questions</button>\r\n");
#nullable restore
#line 33 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Case No.\r\n            </th>\r\n            <th>\r\n                Member Name\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
           Write(Html.DisplayNameFor(model => model.Urgent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Submit Date
            </th>
            <th>
                Asked By
            </th>
            <th>
                Answer By
            </th>
            <th>
                Question Type
            </th>
            <th>
                Department
            </th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 72 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CaseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Html.DisplayFor(modelItem => item.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Urgent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"white-space:initial\" title=\"Add Answer to This Question\">\r\n");
#nullable restore
#line 85 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                     if (item.Description.Length > 50)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                   Write(item.Description.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 2830, "\"", 2861, 2);
            WriteAttributeValue("", 2837, "/Home/AddAnswer/", 2837, 16, true);
#nullable restore
#line 87 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
WriteAttributeValue("", 2853, item.Id, 2853, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2862, "\"", 2955, 6);
            WriteAttributeValue("", 2870, "Answer", 2870, 6, true);
            WriteAttributeValue(" ", 2876, "this", 2877, 5, true);
            WriteAttributeValue(" ", 2881, "Question.", 2882, 10, true);
            WriteAttributeValue("\r\n                           ", 2891, "Full", 2920, 33, true);
            WriteAttributeValue(" ", 2924, "Description:", 2925, 13, true);
#nullable restore
#line 88 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
WriteAttributeValue(" ", 2937, item.Description, 2938, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">...see more</a>\r\n");
#nullable restore
#line 89 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 3072, "\"", 3103, 2);
            WriteAttributeValue("", 3079, "/Home/AddAnswer/", 3079, 16, true);
#nullable restore
#line 92 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
WriteAttributeValue("", 3095, item.Id, 3095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Answer this Question\">");
#nullable restore
#line 92 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                                                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 93 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Convert.ToDateTime(item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Askedby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Answeredby));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Html.DisplayFor(modelItem => item.QuestionType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
               Write(Html.DisplayFor(modelItem => item.QuestionDepartment.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3865, "\"", 3901, 3);
            WriteAttributeValue("", 3875, "DeleteQuestion(\'", 3875, 16, true);
#nullable restore
#line 111 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
WriteAttributeValue("", 3891, item.Id, 3891, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3899, "\')", 3899, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete this Question\">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 114 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<script>
    function ExportToExcel() {
        if (confirm(""Are you sure to Export these question to Excel File?"")) {
            location.href = ""/Home/PrintReport"";
        }
    }

    function FilterQuestions() {
        window.location.href = ""/Home/AllQuestionList?Qtype="" + $(""#QType"").val() + ""&Qstatus="" + $(""#QStatus"").val() + """";
        //alert(");
#nullable restore
#line 128 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
           Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        //document.getElementById(\"QStatus\").value = ");
#nullable restore
#line 129 "C:\Online Drives\OneDrive\Fiverr Tasks Completed\dblow1\QuestionsManagementApp\QuestionsManagementApp\Views\Home\AllQuestionList.cshtml"
                                                Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    }



    function DeleteQuestion(questionid) {
        //console.log(questionid);
        if (confirm(""Are you sure to Delete this Question?"")) {
            $.ajax({
                type: ""POST"",
                url: ""/Home/DeleteQuestion"",
                data: {
                    QId: questionid
                },
                success: function () {
                    alert('Question Deleted Successfully!\nClick on ""Load All"" button to see changes');
                }
            });
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuestionsManagementApp.Models.Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
