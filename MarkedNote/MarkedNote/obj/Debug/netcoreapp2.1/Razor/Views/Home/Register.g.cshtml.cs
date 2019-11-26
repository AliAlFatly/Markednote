#pragma checksum "C:\Users\aeazh_000\Desktop\MarkedNote\MarkedNote\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e65d3823cdd6298d867d420e3f6bcd46ccb2495b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e65d3823cdd6298d867d420e3f6bcd46ccb2495b", @"/Views/Home/Register.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:lightblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 17, true);
            WriteLiteral("<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(17, 676, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade1ead0e4414b4e911741f8dfd3d166", async() => {
                BeginContext(23, 663, true);
                WriteLiteral(@"
    <title>MarkedNote</title>


    <link rel=""stylesheet"" href=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css"">
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>

");
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
            BeginContext(693, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(695, 3324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5f6c54ec9244224bd8813616abb2344", async() => {
                BeginContext(754, 3258, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-sm bg-primary navbar-dark"">
        <ul class=""navbar-nav"">
            <li class=""nav-item active"">
                <a class=""nav-link"" id=""home"">Home</a>
            </li>
            <li class=""nav-item"" id=""loginLi"">

            </li>
        </ul>
    </nav>

    <div class=""container"">
        <h2>Register</h2>
        <form>
            <p id=""RegisterationErrors""></p>
            <div class=""form-group"">
                <label for=""uname"">Username:</label>
                <input type=""text"" class=""form-control"" id=""username"" placeholder=""Enter username"">
            </div>
            <div class=""form-group"">
                <label for=""pwd"">Password:</label>
                <input type=""password"" class=""form-control"" id=""password"" placeholder=""Enter password"">
            </div>

        </form>
        <input type=""submit"" name=""Register"" value=""Register"" onclick=""register()"" class=""btn btn-primary"" />
        <button class=""d-inline-");
                WriteLiteral(@"block btn btn-black float-right text-primary"" id=""loginRedirect"">Login</button>
    </div>


    <script type=""text/javascript"">

        $(document).ready(function () {
            loadNavigationBar()

            $(""#home"").click(function () {
                document.location.href = ""/"";
            })

            $(""#register"").click(function () {
                document.location.href = ""/register""
            })

            $(""#loginRedirect"").click(function () {
                document.location.href = ""/login""
            })

            $(""#logout"").click(function () {
                sessionStorage.removeItem(""Token"");
            })

            $(""#login"").click(function () {
                document.location.href = ""/login""
            })

        })

        function register() {
            let Data = JSON.stringify({
                Email: $(""#username"").val(),
                Password: $(""#password"").val()
            })
            console.log(Data);
  ");
                WriteLiteral(@"          $.ajax({
                type: ""POST"",
                url: ""/identity/register"",
                data: Data,
                contentType: ""application/json"",
                success: function (res) {
                    if (res.status == 400) {
                        console.log(res);
                    }
                    console.log(res)
                    if (res.jwtToken != null) {
                        sessionStorage.setItem(""Token"", res.jwtToken);
                        document.location.href = ""/"";
                    }
                    else {
                        document.getElementById(""RegisterationErrors"").innerHTML = res.Errors;
                    }
                }
            })
        }


        function loadNavigationBar() {
            let defaultNavBar = `???`
            if (sessionStorage.getItem(""Token"") == null) {
                defaultNavBar = `<a class=""nav-link"" id=""login"">Login</a>`
            }
            else {
           ");
                WriteLiteral("     defaultNavBar = `<a class=\"nav-link\" id=\"logout\">Logout</a>`\r\n\r\n            }\r\n            document.getElementById(\"loginLi\").innerHTML = defaultNavBar\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4019, 22, true);
            WriteLiteral("\r\n\r\n<footer> </footer>");
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
