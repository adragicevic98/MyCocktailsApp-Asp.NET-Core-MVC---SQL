#pragma checksum "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\Home\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca703eec357998fa7b5d878211a9f4f3f23a29c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Category), @"mvc.1.0.view", @"/Views/Home/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca703eec357998fa7b5d878211a9f4f3f23a29c", @"/Views/Home/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d30ab3eefc731db78045823bbd8bb8252f73beb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\Home\Category.cshtml"
  
    ViewData["Title"] = "Category";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2 style=""color:#b30000;"">Category<span id=""cat"" style=""font:100; color:#b30000;""></span></h2>
<div class=""text-center"">





    <table class=""table table-hover"" id=""category_cocktails"">

        <thead id=""table-head""></thead>
        <tbody id=""table-body""></tbody>
    </table>
</div>
<script type=""text/javascript"">
    'use strict';
    var objekt;
    var zahtjev3 = new XMLHttpRequest();
    var ime = localStorage.getItem(""Naziv kategorije"");
   
    console.log(ime);
    var tabl = document.getElementById(""category_cocktails"");
    while (tabl.rows.length > 0) {
        tabl.deleteRow(0);
    }
    document.getElementById(""cat"").innerHTML = "" -> "" + ime;
    zahtjev3.onreadystatechange = stanje3;
    zahtjev3.open('GET', `https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=${ime} `, true)
    zahtjev3.send();
    function stanje3() {
        if (zahtjev3.status == 200 && zahtjev3.readyState == 4) {
            var odg = zahtjev3.responseText;
            console.");
            WriteLiteral(@"log(odg);
            objekt = JSON.parse(odg);
            console.log(objekt);
            var strTabl = ""category_cocktails"";
         
            for (var nesto of objekt.drinks) {
                var naziv = nesto.strDrink;
                var slika = nesto.strDrinkThumb;
                var id = nesto.idDrink;
                console.log(slika);


                createOneDrink(id, naziv, slika, strTabl);

            }

        }
    }
    function createOneDrink(id, naz, sl, tab) {
        console.log(""Tablica:"", tab);
        var tablica = document.getElementById(tab);
        console.log(""TABL:"" + tablica);
        let row = tablica.insertRow();
        row.id = id;
        console.log(row);

        let ime_stupac = row.insertCell();
        ime_stupac.id = id;


        let slika_stupac = row.insertCell();
        slika_stupac.id = id;
      
        row.addEventListener(""click"", odabranRed, false);
       

        var ahref = document.createElement('a');
   ");
            WriteLiteral(@"     var ahref1 = document.createElement('a');
        var ahref2 = document.createElement('a');
        ahref.setAttribute('href', '/pmfst/cocktail');
        ahref1.setAttribute('href', '/pmfst/cocktail');
        ahref2.setAttribute('href', '/pmfst/cocktail');
        var div = document.createElement('div');
        div.style.width = ""300px"";

        div.innerHTML = naz;
        ahref.appendChild(div);

        ime_stupac.appendChild(ahref);

        console.log(div);
        console.log(div.parentNode);
        var img = document.createElement('img');
        img.src = `${sl}`;
        img.width = 200;
        img.height = 200;
        ahref1.appendChild(img);

        slika_stupac.appendChild(ahref1);
        ahref2.appendChild(ime_stupac);
        ahref2.appendChild(slika_stupac);
        row.appendChild(ahref2);

        console.log(row);
       

    }
    function odabranRed(event) {
        console.log(event.target.parentNode);
        console.log(event.target.parent");
            WriteLiteral(@"Node.parentNode);
        var id = event.target.parentNode.parentNode.id;
        console.log(""BAS OVAJ ID red:"",id);
        localStorage.setItem(""IdCocktail"", `${id}`);
        localStorage.setItem(""natrag"", ""/pmfst/category"");
    }



    </script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
