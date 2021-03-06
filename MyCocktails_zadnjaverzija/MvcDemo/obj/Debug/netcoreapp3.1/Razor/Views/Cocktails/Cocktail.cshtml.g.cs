#pragma checksum "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\Cocktails\Cocktail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512a82605d2a11a7cac2d214e8a7ab4e4b9d81b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cocktails_Cocktail), @"mvc.1.0.view", @"/Views/Cocktails/Cocktail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512a82605d2a11a7cac2d214e8a7ab4e4b9d81b7", @"/Views/Cocktails/Cocktail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d30ab3eefc731db78045823bbd8bb8252f73beb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cocktails_Cocktail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Jasna_projekt\MyCocktails_zadnjaverzija\MyCocktails_zadnjaverzija\MvcDemo\Views\Cocktails\Cocktail.cshtml"
  
    ViewData["Title"] = "Cocktail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<a id=""linkk"" class=""btn btn-secondary btn-sm"" role=""button"" aria-pressed=""true"">Natrag</a>

<div class=""text-center"">
    <table class=""table table-hover"" id=""table_cocktail"">
    </table>

</div>
<script type=""text/javascript"">
    document.getElementById(""linkk"").href = `${localStorage.getItem(""natrag"")}`;
    var id;
    var naziv;
    var slika;
    var opis;
    var vrsta;
    let sastojcii = new Array(15);
    let kolicinee = new Array(15);
    var comment = ""ingredients"";
    var zahtjev4 = new XMLHttpRequest();

    id = localStorage.getItem(""IdCocktail"");
    var tabl = document.getElementById(""table_cocktail"");
    console.log(tabl);
    while (tabl.rows.length > 0) {
        tabl.deleteRow(0);
    }
    zahtjev4.onreadystatechange = stanje4;
    zahtjev4.open('GET', `https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=${id} `, true)
    zahtjev4.send();
    function stanje4() {
        if (zahtjev4.status == 200 && zahtjev4.readyState == 4) {
            var ");
            WriteLiteral(@"odg = zahtjev4.responseText;
            console.log(""Response:"" + odg);
            objekt = JSON.parse(odg);
            console.log(objekt);
            var tablica = document.getElementById(""table_cocktail"");

            var nesto = objekt.drinks[0];
            console.log(nesto);
            naziv = nesto.strDrink;
            console.log(naziv);
            slika = nesto.strDrinkThumb;
            opis = nesto.strInstructions;
            vrsta = nesto.strAlcoholic;
            var sastojci = ""<b>Ingredients:</b>"" + ""<br>"";
            for (let i = 1; i < 16; i++) {
                const elemnt = `strIngredient${i}`;
                console.log(nesto[elemnt]);
                console.log(typeof (elemnt));
                console.log(nesto.elemnt);
                console.log(nesto.strIngredient1);
                if (nesto[elemnt] != """" && nesto[elemnt] != null) {
                    sastojcii[i - 1] = nesto[elemnt];
                    kolicinee[i - 1] = nesto[`strMeasure${i}`];");
            WriteLiteral(@"
                    sastojci += ""-"" + nesto[`strMeasure${i}`] + "" "" + nesto[elemnt] + ""<br>"";
                }
                else {
                    sastojcii[i - 1] = null;
                    kolicinee[i - 1] = null;
                }

            }
            console.log(sastojcii);
            console.log(kolicinee);


            DetaljniIspis(naziv, slika, sastojci, opis, vrsta);
            console.log(""INGREDIENTSS"");
            axios.get('/api/ingredients').then(response => spremanje(response));
          
        }
    }
    var svi = [];
    var change = false;
    function spremanje(odg) {
        console.log(odg);
        for (let i = 0; i < odg.data.length; i++) {
            
            var identifikator = odg.data[i].id;
            console.log(""KOJI:"", identifikator);
            svi.push(identifikator);
        }
        setTimeout(savefunc, 100);
        function savefunc() {
            if (!(svi.includes(parseInt(id)))) {
                console.l");
            WriteLiteral(@"og(svi, id);
                axios.post('/api/ingredients/savecourse', {
                    ""id"": id,
                    ""name"": naziv,
                    ""type"": vrsta,
                    ""instructions"": opis,
                    ""image"": slika,
                    ""ingredient1"": sastojcii[0],
                    ""ingredient2"": sastojcii[1],
                    ""ingredient3"": sastojcii[2],
                    ""ingredient4"": sastojcii[3],
                    ""ingredient5"": sastojcii[4],
                    ""ingredient6"": sastojcii[5],
                    ""ingredient7"": sastojcii[6],
                    ""ingredient8"": sastojcii[7],
                    ""ingredient9"": sastojcii[8],
                    ""ingredient10"": sastojcii[9],
                    ""ingredient11"": sastojcii[10],
                    ""ingredient12"": sastojcii[11],
                    ""ingredient13"": sastojcii[12],
                    ""ingredient14"": sastojcii[13],
                    ""ingredient15"": sastojcii[14],
     ");
            WriteLiteral(@"               ""measure1"": kolicinee[0],
                    ""measure2"": kolicinee[1],
                    ""measure3"": kolicinee[2],
                    ""measure4"": kolicinee[3],
                    ""measure5"": kolicinee[4],
                    ""measure6"": kolicinee[5],
                    ""measure7"": kolicinee[6],
                    ""measure8"": kolicinee[7],
                    ""measure9"": kolicinee[8],
                    ""measure10"": kolicinee[9],
                    ""measure11"": kolicinee[10],
                    ""measure12"": kolicinee[11],
                    ""measure13"": kolicinee[12],
                    ""measure14"": kolicinee[13],
                    ""measure15"": kolicinee[14]

                });
                console.log(""ZA POST:-----"" + id, naziv, slika, opis);
                change = false;
            } else { change = true; }


        }
        
    }
    var osobnikokteli = [];
    function postavi() {
        axios.get('/api/usercocktail').then(response => spre");
            WriteLiteral(@"manje2(response));
        function spremanje2(odg) {
            console.log(odg);
            for (let i = 0; i < odg.data.length; i++) {

                var identity = odg.data[i].idCocktail.id;
                console.log(""KOJI:"", identity);
                osobnikokteli.push(identity);
            } setTimeout(nastavi, 0);
            
            
        }
        function nastavi() {
            console.log(""CHANGE"", change);
            console.log(id);
            console.log(osobnikokteli);
            console.log(osobnikokteli[1]);
            console.log(typeof (id));
            var jel = osobnikokteli.includes(parseInt(id));
            console.log(""JEL"", jel);
            if (change && osobnikokteli.includes(parseInt(id))) {
                localStorage.setItem(""uredi"", ""da"");
            } else {
                console.log(change, osobnikokteli.includes(parseInt(id)));
                localStorage.setItem(""uredi"", ""ne"");
            }
            setTimeout(prebaci");
            WriteLiteral(@", 0);
            function prebaci() {
                window.location = '/pmfst/addcocktail';
            }

        }

    }
    var ahref;
    function DetaljniIspis(naz, sl, sas, op, vrs) {

        var tablica = document.getElementById(""table_cocktail"");
        let row = tablica.insertRow();

        let ime_stupac = row.insertCell();
        var div = document.createElement('h2');

        var t_naziv = document.createTextNode(naz);
        div.appendChild(t_naziv);
        div.style.color = ""darkred"";
        var botun = document.createElement('button');

        botun.class = ""button button3"";
        botun.style.backgroundColor = ""#4d94ff"";
        botun.style.border = ""3px solid #4d94ff"";
        botun.style.borderRadius = ""6px"";
        botun.style.color = ""white"";

        botun.cursor = ""pointer"";
       
        localStorage.setItem(""IdCocktail"", `${id}`);
        botun.innerHTML = ""<b>Add to my list!</b>"";
        ahref = document.createElement('a');
        ah");
            WriteLiteral(@"ref.appendChild(botun);
        botun.addEventListener(""click"", postavi, false);


        ime_stupac.appendChild(div);
        ime_stupac.appendChild(ahref);
        ime_stupac.display = ""inline-block"";
        let row1 = tablica.insertRow();
        let slika_stupac = row1.insertCell();
        let row2 = tablica.insertRow();
        let vrsta_stupac = row2.insertCell();
        let row3 = tablica.insertRow();
        let sastojci_stupac = row3.insertCell();
        let row4 = tablica.insertRow();
        let opis_stupac = row4.insertCell();


        var img = document.createElement('img');
        img.src = `${sl}`;
        img.width = 330;
        img.height = 330;

        slika_stupac.appendChild(img);

        sastojci_stupac.innerHTML = sas;
        opis_stupac.innerHTML = ""<b>Instructions:</b> <br>"" + op;
        vrsta_stupac.innerHTML = ""<b>Type: </b>"" + vrs;




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
