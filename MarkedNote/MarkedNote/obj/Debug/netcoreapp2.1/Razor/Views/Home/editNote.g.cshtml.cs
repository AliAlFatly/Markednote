#pragma checksum "C:\Users\aeazh_000\Desktop\MarkedNote\MarkedNote\Views\Home\editNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fbd297bd8577000c1cd1aba637862ed9720a61d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_editNote), @"mvc.1.0.view", @"/Views/Home/editNote.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/editNote.cshtml", typeof(AspNetCore.Views_Home_editNote))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbd297bd8577000c1cd1aba637862ed9720a61d", @"/Views/Home/editNote.cshtml")]
    public class Views_Home_editNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e67b784216844d9aac7a6555831dc181", async() => {
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
            BeginContext(695, 5296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002011d44047496b850566877f2daefa", async() => {
                BeginContext(754, 1264, true);
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



    <div id=""ContentBody"" class=""afternav container"" style=""padding-top: 20px"">

    </div>

    <script type=""text/javascript"">

        $(document).ready(function () {
            loadNavigationBar()
            getNotes();

            $(""#home"").click(function () {
                document.location.href = ""/"";
            })

            $(""#register"").click(function () {
                document.location.href = ""/register""
            })

            $(""#login"").click(function () {
                document.location.href = ""/login""
            })

            $(""#logout"").click(function () {
                sessionStorage.removeItem(""Token"");
                document.");
                WriteLiteral("location.href = \"/\";\r\n            })\r\n\r\n\r\n        })\r\n\r\n        function getNotes() {\r\n            if (sessionStorage.getItem(\"Token\") != null) {\r\n                $.ajax({\r\n                    type: \"GET\",\r\n                    url: \"/notes/");
                EndContext();
                BeginContext(2019, 10, false);
#line 63 "C:\Users\aeazh_000\Desktop\MarkedNote\MarkedNote\Views\Home\editNote.cshtml"
                            Write(ViewBag.id);

#line default
#line hidden
                EndContext();
                BeginContext(2029, 2655, true);
                WriteLiteral(@""",
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader('Authorization', ""bearer "" + sessionStorage.getItem(""Token""));
                    },
                    contentType: ""application/json"",
                    success: function (res) {
                        let content = res.note;
                        $(""#ContentBody"").prepend(`<button class=""btn btn-primary border border-dark"" onClick=""sumbitNoteEdit()"">Sumbit edit</button>`)
                        let link = ""Link:"";
                        if (content.link != null) {
                            link += ` <input id=""noteLink"" value=""${content.link}"" style=""color: blue; width: 50%; background-color:rgb(116, 120, 197); margin-top:5px"" class=""border border-dark rounded"" ></input>`;
                        }
                        else {
                            link += ` <input id=""noteLink"" value=""no link saved"" style=""color: blue; width: 50%; background-color:rgb(116, 120, 197); margin-top:");
                WriteLiteral(@"5px"" class=""border border-dark rounded"" ></input>`;
                        }
                        let input =  `<input id=""content"" style=""background-color:blue;color:yellow; padding:5px; display:block; width:100%; margin-bottom:3px"" class=""rounded border border-dark"" value=""${content.content}""></input>`
                        $(""#ContentBody"").prepend(`
                            <div class=""container rounded border border-dark"" style=""background-color:rgb(116, 120, 197);padding:5px"">
                            <input id=""title"" style=""background-color: #92a8d1; padding:10px; width:100%; margin-bottom:3px; font-size: 1.5em; font-weight: bold; display:block"" class=""rounded border border-dark"" value=${content.title}></input>

                            <textarea id=""content"" cols=""40"" rows=""5"" style=""background-color:blue;color:yellow; padding:5px; display:block; width:100%; margin-bottom:3px"" class=""rounded border border-dark"" >${content.content}""</textarea>
                            <em><p ");
                WriteLiteral(@"class=""float-right"">Author: ${content.email}  [${parseDate(content.date)}]<p></em>
                            ${link}

                            </div>
                            <br>
                            `)
                    },
                    error: function (err) {
                        alert(err)
                    }
                })
            }
            else {
                document.location.href = ""/login"";
            }

        }

        function sumbitNoteEdit(){
            $.ajax({
                type: ""PUT"",
                url: ""/notes/");
                EndContext();
                BeginContext(4685, 10, false);
#line 105 "C:\Users\aeazh_000\Desktop\MarkedNote\MarkedNote\Views\Home\editNote.cshtml"
                        Write(ViewBag.id);

#line default
#line hidden
                EndContext();
                BeginContext(4695, 1289, true);
                WriteLiteral(@""",
                data: JSON.stringify({
                    title: $(""#title"").val(),
                    content: $(""#content"").val(),
                    links: $(""#noteLink"").val(),
                    tags: []
                }),
                beforeSend: function (xhr) {
                    xhr.setRequestHeader('Authorization', ""bearer "" + sessionStorage.getItem(""Token""));
                },
                contentType: ""application/json"",
                success: function (res) {
                    document.location.href = ""/""
                },
                error: function (err) {
                    alert(err);
                }
            })
        }

        function parseDate(date) {
            let index = date.indexOf(""T"");
            return date.substring(0, index);
        }



        function loadNavigationBar() {
            let defaultNavBar = `???`
            if (sessionStorage.getItem(""Token"") == null) {
                defaultNavBar = `<a class=""");
                WriteLiteral(@"nav-link"" id=""login"">Login</a>`
            }
            else {
                defaultNavBar = `<a class=""nav-link"" id=""logout"">Logout</a>`

            }
            document.getElementById(""loginLi"").innerHTML = defaultNavBar
        }

    </script>
");
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
            BeginContext(5991, 22, true);
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