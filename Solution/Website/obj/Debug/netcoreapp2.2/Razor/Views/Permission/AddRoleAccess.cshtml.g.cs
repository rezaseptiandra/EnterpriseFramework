#pragma checksum "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Permission\AddRoleAccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c699844bc0d996f5a63375693235a6892cc09b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Permission_AddRoleAccess), @"mvc.1.0.view", @"/Views/Permission/AddRoleAccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Permission/AddRoleAccess.cshtml", typeof(AspNetCore.Views_Permission_AddRoleAccess))]
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
#line 1 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\_ViewImports.cshtml"
using Website;

#line default
#line hidden
#line 2 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\_ViewImports.cshtml"
using Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c699844bc0d996f5a63375693235a6892cc09b6", @"/Views/Permission/AddRoleAccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Permission_AddRoleAccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formulol"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Permission\AddRoleAccess.cshtml"
  
    ViewData["Title"] = "Add Permission";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(55, 17, false);
#line 4 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Permission\AddRoleAccess.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(72, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(100, 1064, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function(){            
            $(""#formulol"").on(""submit"", function () {
                var _obj = {
                    ControllerName: $(""#controllername"").val(),
                    RoleID: $(""#roleid"").val(),
                    AllowCreate: $(""#create"").is("":checked""),
                    AllowEdit: $(""#edit"").is("":checked""),
                    AllowDelete: $(""#delete"").is("":checked""),
                    AllowView: $(""#view"").is("":checked"")
                };  
                debugger;
                _obj = JSON.stringify(_obj);
                $.ajax({ 
                    url: ""SubmitAddRoleAccess"",
                    type: 'post',
                    datatype: 'application/json',
                    data: { obj: _obj },
                    success: function (data) {},
                    error: function () {
                        alert('Ajax error!');
                    } 
                });
            return false;
     ");
                WriteLiteral("       });\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1167, 17, true);
            WriteLiteral("<p>Register</p>\r\n");
            EndContext();
            BeginContext(1184, 466, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c699844bc0d996f5a63375693235a6892cc09b65871", async() => {
                BeginContext(1204, 439, true);
                WriteLiteral(@"
    ControllerName: <input type=""text"" id=""controllername"" /> <br />
    RoleID: <input type=""text"" id=""roleid"" /> <br />
    Allow Create: <input type=""checkbox"" id=""create"" /> <br />
    Allow Edit: <input type=""checkbox"" id=""edit"" /> <br />
    Allow Delete: <input type=""checkbox"" id=""delete"" /> <br />
    Allow View: <input type=""checkbox"" id=""view"" /> <br />
    <input type=""submit"" value=""Submit"" class=""submit"" /><br />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1650, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
