#pragma checksum "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\Admin\adminHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08051a1c5a5d7a2d6f6e37d3c5d3abb8edb47156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_adminHome), @"mvc.1.0.view", @"/Views/Admin/adminHome.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\_ViewImports.cshtml"
using MyCocktails;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\_ViewImports.cshtml"
using MyCocktails.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08051a1c5a5d7a2d6f6e37d3c5d3abb8edb47156", @"/Views/Admin/adminHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d30ab3eefc731db78045823bbd8bb8252f73beb", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_adminHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\Admin\adminHome.cshtml"
  
    ViewData["Title"] = "adminHome";
    ViewBag.Title = "adminHome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Welcome admin!</h2>\r\n\r\n<div>\r\n\r\n</div>\r\n<table id=\"tabl\">\r\n    <tr>\r\n        <th>Firstname</th>\r\n        <th>Lastname</th>\r\n        <th>Email</th>\r\n        <th>Username</th>\r\n        <th>Password</th>\r\n    </tr>\r\n</table>\r\n\r\n");
            WriteLiteral("<br />\r\n<div id=\"forma\" style=\"visibility:hidden;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08051a1c5a5d7a2d6f6e37d3c5d3abb8edb471564077", async() => {
                WriteLiteral(@"
            <label for=""firstname"">First name:</label>
            <input type=""text""
                   placeholder=""First name""
                   id=""firstname"" />
            <label for=""lastname"">Last name:</label>
            <input type=""text""
                   placeholder=""Last name""
                   id=""lastname"" />
            <label for=""email"">Email:</label>
            <input type=""text""");
                BeginWriteAttribute("cols", "\r\n                   cols=\"", 818, "\"", 845, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                   rows=""10""
                   placeholder=""Email""
                   id=""email"" />
            <label for=""username"">Username:</label>
            <input type=""text""
                   placeholder=""Username""
                   id=""username"" />
            <label for=""password"">Password:</label>
            <input id=""password"" placeholder=""password""  type=""text"" maxlength=""10"" />

            <input type=""button"" value=""Save"" id=""saveButton"" style=""background-color:green; color: white; "" onclick=""dodaj()"" />
            <input type=""button"" value=""Close"" id=""closeButton"" style=""background-color:red; color: white; "" onclick=""zatvori()"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
        <style>
            input[type=text]{
              width:70%;
                padding: 6px 10px;
                margin: 4px 0;
                display: inline-block;
                border: 1px solid #ccc;
                border-radius: 4px;
                /*box-sizing: border-box;*/
            }
            label{
                display:inline-block;
                width:25%;
            }
            input[type=button] {
                width: 47%;
                padding: 6px 10px;
                margin: 4px 0;
                border: none;
                border-radius: 4px;
                cursor: pointer;
            }

                input[type=button]:hover {
                    background-color: #b30000;
                }
              
            #forma {
                width: 40%;
                border-radius: 5px;
                background-color: #f2f2f2;
                padding: 20px;
                margin: auto;
                ");
            WriteLiteral(@"float:left;
                height:330px;
            }
            table {
                border-collapse: collapse;
                width: 100%;
            }

            th, td {
                text-align: left;
                padding: 8px;
            }

            tr:nth-child(even) {
                /*background-color: #f2f2f2*/
            }

            th {
                background-color: darkred;
                color: white;
            }
        </style>
        <script type=""text/javascript"">
            'use strict';
            function appendTableHead(single) {

                let header = domHelper.createTableHeader(single);
                let thead = document.getElementById('table-head');
                console.log(header)
                thead.appendChild(header);
            }

            function appendToTable(data) {

                let rows = data.map(x => domHelper.createTableRow(x));
                let tableBody = document.getElementById");
            WriteLiteral(@"('table-body');

                appendTableHead(data[0]);

                for (let row of rows) {
                    tableBody.appendChild(row);
                }
            }
            function timedRefresh(time) {
                setTimeout(""location.reload(true);"", time);
            }

            var iduser;
            var uredi = false;
            function dodaj() {
                if (uredi) {
                    let userEdit = {
                        ""id"": `${iduser}`,
                        ""username"": `${document.getElementById(""username"").value}`,
                        ""password"": `${document.getElementById(""password"").value}`,
                        ""firstName"": `${document.getElementById(""firstname"").value}`,
                        ""lastName"": `${document.getElementById(""lastname"").value}`,
                        ""email"": `${document.getElementById(""email"").value}`
                    }
                    axios.put(""/api/admin/useredit"", userEdit);
      ");
            WriteLiteral(@"              timedRefresh(200);
                }
                timedRefresh(200);
            }
            //async function Save(id) {
            //    console.log(""Saving changes...."")
            //    let userEdit = {
            //        ""id"": id,
            //        ""username"": `${document.getElementById(""selectedUsername"").value}`,
            //        ""email"": `${document.getElementById(""selectedEmail"").value}`,
            //        ""password"": `${document.getElementById(""selectedPassword"").value}`
            //    }
            //    axios.put(""/api/admin/useredit"", userEdit);
            //    timedRefresh(500);
            //}
            function removeUser(id) {
                axios.delete(`/api/admin/delete/${id}`, id);
                timedRefresh(500);
            }
           
            axios.get('/api/admin/allusers').then(response => (spremanje(response)));
            function timedRefresh(time) {
                setTimeout(""location.reload(true);"", time");
            WriteLiteral(@");
            }
            function spremanje(odg) {
                console.log(odg);
                var tablica = document.getElementById(""tabl"");

                for (let i = 0; i < odg.data.length; i++) {
                    var red = tablica.insertRow();
                    var naz_stupac = red.insertCell();
                    var prez_stupac = red.insertCell();
                    var em_stupac = red.insertCell();
                    var un_stupac = red.insertCell();
                    var ps_stupac = red.insertCell();
                    var del_stupac = red.insertCell();
                    var edit_stupac = red.insertCell();
                    var btn_del = document.createElement(""button"");
                    var btn_edit = document.createElement(""button"");
                    btn_del.style = "" margin: 4px 0; border: none; border-radius: 6px; cursor: pointer; width: 60px; color:white; background-color:red;""
                    btn_del.innerHTML = ""Delete"";
                 ");
            WriteLiteral(@"   btn_edit.style = ""background-color:#1a8cff; color:white; margin: 4px 0; border: none; border-radius: 6px; cursor: pointer; width: 60px;"";
                    btn_edit.innerHTML = ""Edit"";
                    del_stupac.appendChild(btn_del);
                    edit_stupac.appendChild(btn_edit);
                    naz_stupac.innerHTML = odg.data[i].firstName;
                    prez_stupac.innerHTML = odg.data[i].lastName;
                    em_stupac.innerHTML = odg.data[i].email;
                    un_stupac.innerHTML = odg.data[i].username;
                    ps_stupac.innerHTML = odg.data[i].password;
                    btn_del.id = odg.data[i].id;
                    btn_del.addEventListener(""click"", brisi, false);
                    btn_edit.id = odg.data[i].id;
                    btn_edit.addEventListener(""click"", promjeni, false);
                }
            }
            function brisi(event) {
                console.log(event.target.id);
                var iduser = even");
            WriteLiteral(@"t.target.id;
                axios.delete(`/api/admin/delete/${iduser}`, iduser);

                timedRefresh(100);
            }
            function promjeni(event) {
                document.getElementById(""forma"").style.visibility = ""visible"";
                console.log(event.target.id);
                iduser = event.target.id;
                axios.get(`/api/admin/user/${iduser}`).then(response => (dohvat(response)));

            }
            function dohvat(odg) {
                uredi = true;

                document.getElementById(""firstname"").value = odg.data.firstName;
                document.getElementById(""lastname"").value = odg.data.lastName;
                document.getElementById(""email"").value = odg.data.email;
                document.getElementById(""username"").value = odg.data.username;
                document.getElementById(""password"").value = odg.data.password;

            }
            function zatvori(event) {
                document.getElementById(""form");
            WriteLiteral("a\").style.visibility = \"hidden\";\r\n            }\r\n\r\n\r\n\r\n        </script>\r\n");
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
