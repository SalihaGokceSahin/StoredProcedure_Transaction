#pragma checksum "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa9b6285ab787b8b4b537dbc12230c5bdde71504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Add), @"mvc.1.0.view", @"/Views/Customer/Add.cshtml")]
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
#line 1 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\_ViewImports.cshtml"
using Basic_Crm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\_ViewImports.cshtml"
using Basic_Crm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9b6285ab787b8b4b537dbc12230c5bdde71504", @"/Views/Customer/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce76cce3ab6fcb60a0739581f5581b60449bb5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Customer>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa9b6285ab787b8b4b537dbc12230c5bdde715043306", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
     using (Html.BeginForm("Add", "Customer", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-md-12\">\r\n            <div class=\"col-sm-6\">\r\n                <label><strong>Name</strong></label>\r\n                ");
#nullable restore
#line 13 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { @class = "form form-control input-sm" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n            </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <label><strong>Surname</strong></label>\r\n                ");
#nullable restore
#line 19 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
           Write(Html.TextBoxFor(m => m.Surname, new { @class = "form form-control input-sm" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <div class=\"col-sm-4\">\r\n                <label><strong>Gender</strong></label>\r\n                <div class=\"radio\">\r\n                    <label>");
#nullable restore
#line 27 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
                      Write(Html.RadioButtonFor(m => m.Gender, true));

#line default
#line hidden
#nullable disable
                WriteLiteral("Female</label>\r\n                    <label>");
#nullable restore
#line 28 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
                      Write(Html.RadioButtonFor(m => m.Gender, false));

#line default
#line hidden
#nullable disable
                WriteLiteral("Male</label>\r\n                </div>\r\n                <br />\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <div class=\"col-md-6\">\r\n                <label><strong>Phone</strong></label>\r\n                ");
#nullable restore
#line 37 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
           Write(Html.TextBoxFor(m => m.Phone, new { @class = "form form-control input-sm" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n            </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <label><strong>Address</strong></label>\r\n                ");
#nullable restore
#line 43 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
           Write(Html.TextBoxFor(m => m.Adress, new { @class = "form form-control input-sm" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("        <div class=\"col-md-12\">\r\n\r\n            <div class=\"col-sm-6\">\r\n                <button type=\"submit\" class=\"btn btn-info btn-block btn-lg\">Save</button>\r\n            </div>\r\n            ");
#nullable restore
#line 53 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 54 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"
       Write(Html.HiddenFor(m => m.UserSession));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\gb141\source\repos\Basic-Crm\Basic-Crm\Views\Customer\Add.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n<!--<body>\r\n    <div class=\"form-group\">\r\n        <form action=\"/Customer/Add\" method=\"post\" runat=\"server\">\r\n\r\n            <div class=\"form-group\">-->\r\n");
            WriteLiteral("<!--<input type=\"text\" class=\"form-control\" id=\"Name\" name=\"Name\" placeholder=\"Please insert your name\" required=\"required\">-->\r\n");
            WriteLiteral(@"<!--</div>
            <div class=""form-group"">
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"" id=""Surname"" name=""Surname"" placeholder=""Please insert your surname"" required=""required"">
                </div>
            </div>
            <div class=""form-group"">
                <div class=""input-group"">
                    <label>Female</label>
                    <input type=""radio"" id=""Gender"" name=""Gender"" value=""true"" />
                    <br />
                    <label>Male</label>
                    <input type=""radio"" id=""Gender"" name=""Gender"" value=""false"" />
                </div>
            </div>
            <div class=""form-group"">
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"" id=""Phone"" name=""Phone"" placeholder=""Please insert your phone number"" required=""required"">
                </div>
            </div>
            <div class=""form-group"">
                <");
            WriteLiteral(@"div class=""input-group"">
                    <input type=""text"" class=""form-control"" id=""Adress"" name=""Adress"" placeholder=""Please insert your address"" required=""required"">
                </div>
            </div>
            <div class=""form-group"">
                <button type=""submit"" id=""SaveButton"" name=""SaveButton"" class=""btn btn-block btn-info btn-lg"">Save</button>
            </div>
        </form>
    </div>
</body>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
