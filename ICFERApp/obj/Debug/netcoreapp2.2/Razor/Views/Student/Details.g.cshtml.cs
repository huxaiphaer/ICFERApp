#pragma checksum "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e1d5b343febb6b4905de9ecbf26477cf25209a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Details.cshtml", typeof(AspNetCore.Views_Student_Details))]
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
#line 1 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/_ViewImports.cshtml"
using ICFERApp;

#line default
#line hidden
#line 2 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/_ViewImports.cshtml"
using ICFERApp.Models;

#line default
#line hidden
#line 6 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e1d5b343febb6b4905de9ecbf26477cf25209a", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152b02cde03a3791ee7948d5f6ce31c3e8e3be39", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReportDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(16, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0e1d5b343febb6b4905de9ecbf26477cf25209a4246", async() => {
                BeginContext(125, 12, true);
                WriteLiteral("Print Report");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 3 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
     WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(141, 72, true);
            WriteLiteral("\n\n<br/>\n<br/>\n\n<style>\n    .centerTable { margin: 0px auto; }\n</style>\n\n");
            EndContext();
            BeginContext(245, 321, true);
            WriteLiteral(@"
<h2 class=""text-center"" style=""color: rgb(21, 121, 31)"">Student Details</h2>

    <table cellpadding=""0"" cellspacing=""0"" class=""centerTable"">
              
        <tr>
            <td>
                <div class=""pv-lg""><img class=""center-block img-responsive img-circle img-thumbnail thumb96"" height=""300"" width=""180""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 566, "\"", 595, 2);
            WriteAttributeValue("", 572, "/images/", 572, 8, true);
#line 21 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
WriteAttributeValue("", 580, Model.ImageUrl, 580, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(596, 130, true);
            WriteLiteral(" alt=\"Contact\"></div>\n\n            </td>\n            <td> <h5>Registration Number :</h5>  <i> <h5 style=\"color: rgb(21, 121, 31)\">");
            EndContext();
            BeginContext(727, 18, false);
#line 24 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                                                    Write(Model.StudentRegNo);

#line default
#line hidden
            EndContext();
            BeginContext(745, 210, true);
            WriteLiteral("</h5> </i></td>\n        </tr>\n        <tr>\n            <td>\n                <br/>\n                <br/>\n            </td>\n        </tr>\n        <tr>\n            <td>\n                <img height=\"80\" width=\"150\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 955, "\"", 1001, 2);
            WriteAttributeValue("", 961, "data:image/png;base64,", 961, 22, true);
#line 34 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
WriteAttributeValue("  ", 983, ViewBag.BarCode, 985, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1002, 298, true);
            WriteLiteral(@" alt=""Red dot"" />
                <br/>
                <br/>
            </td>
        </tr>
            <tr>
                <td class=""text-center"" style=""color: rgba(113, 3, 138, 0.99)""><h5>Student's Profile</h5></td>
            </tr>
            <tr>
                <td> <b>Full Names :</b> ");
            EndContext();
            BeginContext(1301, 15, false);
#line 43 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                    Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1318, 16, false);
#line 43 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                     Write(Model.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1336, 14, false);
#line 43 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1350, 47, true);
            WriteLiteral("  </td> \n                <td> <b>Country :</b> ");
            EndContext();
            BeginContext(1398, 17, false);
#line 44 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                 Write(Model.Nationality);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 136, true);
            WriteLiteral("</td>\n\n            </tr>\n\n            <tr>\n\n            </tr>\n            <tr>\n                <td>\n                    <b>Gender :</b> ");
            EndContext();
            BeginContext(1552, 12, false);
#line 53 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                               Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1564, 62, true);
            WriteLiteral("\n                </td>\n                <td> <b>Religion :</b> ");
            EndContext();
            BeginContext(1627, 14, false);
#line 55 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                  Write(Model.Religion);

#line default
#line hidden
            EndContext();
            BeginContext(1641, 85, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Home Address :</b> ");
            EndContext();
            BeginContext(1727, 17, false);
#line 59 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                      Write(Model.HomeAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 56, true);
            WriteLiteral("</td>\n                <td> <b>Country of Residence:</b> ");
            EndContext();
            BeginContext(1801, 24, false);
#line 60 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                             Write(Model.CountryOfResidence);

#line default
#line hidden
            EndContext();
            BeginContext(1825, 92, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Country of Residence:</b> ");
            EndContext();
            BeginContext(1918, 24, false);
#line 64 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                             Write(Model.CountryOfResidence);

#line default
#line hidden
            EndContext();
            BeginContext(1942, 41, true);
            WriteLiteral("</td>\n                <td> <b>City :</b> ");
            EndContext();
            BeginContext(1984, 10, false);
#line 65 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                              Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 86, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Date of Birth :</b> ");
            EndContext();
            BeginContext(2081, 37, false);
#line 69 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                       Write(Model.DateOfBirth.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2118, 54, true);
            WriteLiteral("</td>\n                <td> <b>Medical Condition :</b> ");
            EndContext();
            BeginContext(2173, 22, false);
#line 70 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                           Write(Model.MedicalCondition);

#line default
#line hidden
            EndContext();
            BeginContext(2195, 357, true);
            WriteLiteral(@"</td>
            </tr>
            <tr>
                <td>
                    <br/>
                    <br/>
                </td>
            </tr>
            <tr>
                <td class=""text-center"" style=""color: rgba(113, 3, 138, 0.99)""><h5>Education</h5></td>
            </tr>

            <tr>
                <td> <b>Education Level : </b> ");
            EndContext();
            BeginContext(2553, 30, false);
#line 83 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                          Write(Model.Education.EducationLevel);

#line default
#line hidden
            EndContext();
            BeginContext(2583, 43, true);
            WriteLiteral("</td>\n                <td> <b>School :</b> ");
            EndContext();
            BeginContext(2627, 22, false);
#line 84 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                Write(Model.Education.School);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 90, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Address of School :</b> ");
            EndContext();
            BeginContext(2740, 31, false);
#line 88 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                           Write(Model.Education.AddressOfSchool);

#line default
#line hidden
            EndContext();
            BeginContext(2771, 49, true);
            WriteLiteral("</td>\n                <td> <b>Home Address :</b> ");
            EndContext();
            BeginContext(2821, 17, false);
#line 89 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                      Write(Model.HomeAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2838, 84, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Head Teacher:</b> ");
            EndContext();
            BeginContext(2923, 27, false);
#line 93 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                     Write(Model.Education.HeadTeacher);

#line default
#line hidden
            EndContext();
            BeginContext(2950, 46, true);
            WriteLiteral("</td>\n                <td> <b>Telephone :</b> ");
            EndContext();
            BeginContext(2997, 25, false);
#line 94 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                   Write(Model.Education.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(3022, 374, true);
            WriteLiteral(@"</td>
            </tr>
            <tr>
                <td>
                    <br/>
                    <br/>
                </td>
            </tr>
            <tr>
                <td class=""text-center""><h5 style=""color: rgba(113, 3, 138, 0.99)"">Parents Details.</h5></td>
            </tr>

            <tr>
                <td><b>Religion Of Deceased Father :</b> ");
            EndContext();
            BeginContext(3397, 38, false);
#line 107 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                    Write(Model.Parents.ReligionOfDeceasedFather);

#line default
#line hidden
            EndContext();
            BeginContext(3435, 64, true);
            WriteLiteral("</td>\n                <td> <b>Religion Of Deceased Mother :</b> ");
            EndContext();
            BeginContext(3500, 38, false);
#line 108 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                     Write(Model.Parents.ReligionOfDeceasedMother);

#line default
#line hidden
            EndContext();
            BeginContext(3538, 93, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td> <b>Date Of Demise Father :</b> ");
            EndContext();
            BeginContext(3632, 54, false);
#line 111 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                               Write(Model.Parents.DateOfDemiseOfFather.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3686, 58, true);
            WriteLiteral("</td>\n                <td> <b>Date Of Demise Mother :</b> ");
            EndContext();
            BeginContext(3745, 54, false);
#line 112 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                               Write(Model.Parents.DateOfDemiseOfMother.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3799, 88, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td> <b> Names of Mother :</b> ");
            EndContext();
            BeginContext(3888, 27, false);
#line 115 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                          Write(Model.Parents.NamesOfMother);

#line default
#line hidden
            EndContext();
            BeginContext(3915, 52, true);
            WriteLiteral("</td>\n                <td> <b>Names of Father :</b> ");
            EndContext();
            BeginContext(3968, 27, false);
#line 116 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                         Write(Model.Parents.NamesOfFather);

#line default
#line hidden
            EndContext();
            BeginContext(3995, 90, true);
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td> <b>Religion of Mother :</b> ");
            EndContext();
            BeginContext(4086, 30, false);
#line 119 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                            Write(Model.Parents.ReligionOfMother);

#line default
#line hidden
            EndContext();
            BeginContext(4116, 61, true);
            WriteLiteral("</td>\n                <td> <b>Marital Status of Mother :</b> ");
            EndContext();
            BeginContext(4178, 35, false);
#line 120 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                  Write(Model.Parents.MaritalStatusOfMother);

#line default
#line hidden
            EndContext();
            BeginContext(4213, 84, true);
            WriteLiteral("</td>\n            </tr>\n        <tr>\n            <td> <b>Occupation of Mother :</b> ");
            EndContext();
            BeginContext(4298, 32, false);
#line 123 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                          Write(Model.Parents.OccupationOfMother);

#line default
#line hidden
            EndContext();
            BeginContext(4330, 47, true);
            WriteLiteral("</td>\n            <td> <b>Monthly Income :</b> ");
            EndContext();
            BeginContext(4378, 27, false);
#line 124 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                    Write(Model.Parents.MonthlyIncome);

#line default
#line hidden
            EndContext();
            BeginContext(4405, 354, true);
            WriteLiteral(@"</td>
        </tr>
            <tr>
                <td>
                    <br/>
                    <br/>
                </td>
            </tr>
            <tr>
                <td class=""text-center""><h5 style=""color: rgba(113, 3, 138, 0.99)"">Guardians Details.</h5></td>
            </tr>
            <tr>
                <td> <b>First Name:</b> ");
            EndContext();
            BeginContext(4760, 24, false);
#line 136 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                   Write(Model.Guardian.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4784, 48, true);
            WriteLiteral("</td>\n                <td> <b>Middle Name :</b> ");
            EndContext();
            BeginContext(4833, 25, false);
#line 137 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                     Write(Model.Guardian.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(4858, 82, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Last Name :</b> ");
            EndContext();
            BeginContext(4941, 23, false);
#line 141 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                   Write(Model.Guardian.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(4964, 59, true);
            WriteLiteral("</td>\n                <td> <b>Relationship to Orphan :</b> ");
            EndContext();
            BeginContext(5024, 35, false);
#line 142 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                Write(Model.Guardian.RelationshipToOrphan);

#line default
#line hidden
            EndContext();
            BeginContext(5059, 82, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Occupation:</b> ");
            EndContext();
            BeginContext(5142, 25, false);
#line 146 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                   Write(Model.Guardian.Occupation);

#line default
#line hidden
            EndContext();
            BeginContext(5167, 51, true);
            WriteLiteral("</td>\n                <td> <b>Monthly Income :</b> ");
            EndContext();
            BeginContext(5219, 28, false);
#line 147 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                        Write(Model.Guardian.MonthlyIncome);

#line default
#line hidden
            EndContext();
            BeginContext(5247, 87, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td><b> Employer\'s Name:</b> ");
            EndContext();
            BeginContext(5335, 28, false);
#line 151 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                        Write(Model.Guardian.EmployersName);

#line default
#line hidden
            EndContext();
            BeginContext(5363, 52, true);
            WriteLiteral("</td>\n                <td><b>Worker\'s Address :</b> ");
            EndContext();
            BeginContext(5416, 26, false);
#line 152 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                         Write(Model.Guardian.WorkAddress);

#line default
#line hidden
            EndContext();
            BeginContext(5442, 85, true);
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td> <b>Mobile Number:</b> ");
            EndContext();
            BeginContext(5528, 23, false);
#line 156 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                      Write(Model.Guardian.MobileNo);

#line default
#line hidden
            EndContext();
            BeginContext(5551, 54, true);
            WriteLiteral("</td>\n                <td> <b>Physical Location :</b> ");
            EndContext();
            BeginContext(5606, 31, false);
#line 157 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                           Write(Model.Guardian.PhysicalLocation);

#line default
#line hidden
            EndContext();
            BeginContext(5637, 73, true);
            WriteLiteral("</td>\n            </tr>\n\n        <tr>\n            <td> <b>Comments :</b> ");
            EndContext();
            BeginContext(5711, 23, false);
#line 161 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                              Write(Model.Guardian.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(5734, 373, true);
            WriteLiteral(@"</td>
        </tr>
            <tr>
                <td>
                    <br/>
                    <br/>
                </td>
            </tr>
            <tr>
                <td class=""text-center"" style=""color: rgba(113, 3, 138, 0.99)""><h5>Siblings Information</h5></td>
            </tr>
                <tr>
                    <td> <b>Number of Brothers :</b> ");
            EndContext();
            BeginContext(6108, 31, false);
#line 173 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                                Write(Model.Siblings.NumberOfBrothers);

#line default
#line hidden
            EndContext();
            BeginContext(6139, 58, true);
            WriteLiteral("</td>\n                    <td> <b>Number of Sisters :</b> ");
            EndContext();
            BeginContext(6198, 30, false);
#line 174 "/Users/idrislutaaya/RiderProjects/ICFERApp/ICFERApp/Views/Student/Details.cshtml"
                                               Write(Model.Siblings.NumberOfSisters);

#line default
#line hidden
            EndContext();
            BeginContext(6228, 44, true);
            WriteLiteral("</td>\n             </tr>      \n    </table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
