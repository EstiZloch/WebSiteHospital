#pragma checksum "F:\Hospital\Hospital\Pages\City.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "868ee0643227a36fcf99b8e84f4e862764e303e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hospital.Pages.Pages_City), @"mvc.1.0.razor-page", @"/Pages/City.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/City.cshtml", typeof(Hospital.Pages.Pages_City), null)]
namespace Hospital.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Hospital\Hospital\Pages\_ViewImports.cshtml"
using Hospital;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"868ee0643227a36fcf99b8e84f4e862764e303e3", @"/Pages/City.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d6098626ba32ebedbbbd3b16a27c11bc77ef90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_City : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Hospital\Hospital\Pages\City.cshtml"
  
    ViewData["Page"] = "Display";
    ViewData["City"] = true;
    var d = 0;
    List<City> Cities = data.SELECTCity();

    //var data = DataBase.SELECTCity("select * from City");

#line default
#line hidden
            BeginContext(202, 380, true);
            WriteLiteral(@"<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
<div>
    <div id=""tytle"">:ערים</div>
    <table id=""table"">
        <thead>
            <tr>
                <th>קוד</th>
                <th>שם</th>
                <th class=""delete"">מחיקה</th>
                <th class=""update"">עדכון</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "F:\Hospital\Hospital\Pages\City.cshtml"
             foreach (var p in Cities)
            {

#line default
#line hidden
            BeginContext(637, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("city", " city=\"", 656, "\"", 674, 1);
#line 25 "F:\Hospital\Hospital\Pages\City.cshtml"
WriteAttributeValue("", 663, p.codeCity, 663, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 675, "\"", 712, 1);
#line 25 "F:\Hospital\Hospital\Pages\City.cshtml"
WriteAttributeValue("", 683, d < 5 ? "start" : "finish", 683, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(713, 27, true);
            WriteLiteral(">\r\n                    <td>");
            EndContext();
            BeginContext(741, 10, false);
#line 26 "F:\Hospital\Hospital\Pages\City.cshtml"
                   Write(p.codeCity);

#line default
#line hidden
            EndContext();
            BeginContext(751, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(783, 10, false);
#line 27 "F:\Hospital\Hospital\Pages\City.cshtml"
                   Write(p.nameCity);

#line default
#line hidden
            EndContext();
            BeginContext(793, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"deleteBtn\"");
            EndContext();
            BeginWriteAttribute("type", " type=\"", 841, "\"", 859, 1);
#line 28 "F:\Hospital\Hospital\Pages\City.cshtml"
WriteAttributeValue("", 848, p.codeCity, 848, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(860, 75, true);
            WriteLiteral(" onclick=\"func(this)\" ;>מחק</td>\r\n                    <td class=\"updateBtn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 935, "\"", 1134, 11);
            WriteAttributeValue("", 945, "document.getElementById(\'upDateRow\').classList.toggle(\'popupAct\',", 945, 65, true);
            WriteAttributeValue(" ", 1010, "true);", 1011, 7, true);
            WriteAttributeValue(" ", 1017, "document.getElementById(\'update1\').innerHTML", 1018, 45, true);
            WriteAttributeValue(" ", 1062, "=", 1063, 2, true);
#line 29 "F:\Hospital\Hospital\Pages\City.cshtml"
WriteAttributeValue("", 1064, p.codeCity, 1064, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1075, ";", 1075, 1, true);
            WriteAttributeValue(" ", 1076, "document.getElementById(\'update2\').value", 1077, 41, true);
            WriteAttributeValue(" ", 1117, "=", 1118, 2, true);
            WriteAttributeValue(" ", 1119, "\'", 1120, 2, true);
#line 29 "F:\Hospital\Hospital\Pages\City.cshtml"
WriteAttributeValue("", 1121, p.nameCity, 1121, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1132, "\';", 1132, 2, true);
            EndWriteAttribute();
            BeginContext(1135, 43, true);
            WriteLiteral(" ;>עדכן פרטים</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "F:\Hospital\Hospital\Pages\City.cshtml"
                d++;
            }

#line default
#line hidden
            BeginContext(1215, 3650, true);
            WriteLiteral(@"        </tbody>
    </table>
    <div class=""popup"" id=""deleteRow"">
        <div>
            <h3>?האם ברצונך למחוק את העיר</h3>
            <h4>קוד העיר למחיקה:<span id=""delete""></span></h4>
            <div id=""Act"">
                <span id=""deleteAll"">מחק</span>
                <span id=""cancelBtn"" onclick=""document.getElementById('deleteRow').classList.toggle('popupAct', false)"">בטל</span>
            </div>
        </div>
    </div>
    <div class=""popup"" id=""notdeleteRow"">
        <div>
            <h3>אין אפשרות למחוק את עיר מספר:</h3>
            <h4><span id=""notdelete""></span></h4>
            <h3 id=""if"">משום שיש ממנה </h3>
            <div id=""Act"">
                <span id=""cancelBtn"" onclick=""document.getElementById('notdeleteRow').classList.toggle('popupAct', false)"">בטל</span>
            </div>
        </div>
    </div>
    <div class=""popup"" id=""upDateRow"">
        <div>
            <h3>?האם ברצונך לעדכן את העיר</h3>
            <h4>
                <span>קוד</spa");
            WriteLiteral(@"n>
                <span id=""update1""></span>
            </h4>
            <h4>
                <span>שם</span>
                <input id=""update2"">
            </h4>
            <div id=""Act"">
                <span id=""deleteBtn"">עדכן</span>
                <span id=""cancelBtn"" onclick=""document.getElementById('upDateRow').classList.toggle('popupAct', false)"">בטל</span>
            </div>

        </div>
    </div>
</div>
<div class=""link"">
    <a href=""AddCity"">להוספת עיר</a>
</div>
<script>
    function func(element) {
        var code = element.getAttribute(""type"");
        var req = new XMLHttpRequest();
        req.open('GET', 'API/Cities/' + code , true);
        req.onload = function () {
            document.getElementById('if').innerHTML = ""משום שיש ממנה "";
            if (req.responseText == '') {
                document.getElementById('deleteRow').classList.toggle('popupAct', true); document.getElementById('delete').innerHTML = element.getAttribute(""type"");
           ");
            WriteLiteral(@" }
            else {
                document.getElementById('notdeleteRow').classList.toggle('popupAct', true); document.getElementById('notdelete').innerHTML = element.getAttribute(""type"");
                document.getElementById('if').innerHTML += req.responseText;
            }
        }
        req.send();
    }
    document.getElementById(""deleteAll"").addEventListener('click', function (e) {
        var req = new XMLHttpRequest();
        req.open('POST', 'API/Cities/DeleteCity', true);
        req.setRequestHeader('Content-Type', 'application/json; charset=utf-8');
        document.getElementById('deleteRow').classList.toggle('popupAct', false);
        req.onload = function () {
            document.getElementById('table').innerHTML = '';
            if (req.responseText>0)
                location.reload();
            }
        req.send(document.getElementById('delete').innerHTML);
    });
    document.getElementById(""deleteBtn"").addEventListener('click', function (e) {
       ");
            WriteLiteral(@" var data = {};
        data['codeCity'] = document.getElementById('update1').innerHTML;
            data['nameCity'] = document.getElementById('update2').value;
        var req = new XMLHttpRequest();
        req.open('POST', 'API/Cities/UpdateCity', true);
        req.setRequestHeader('Content-Type','application/json; charset=utf-8');
        req.onload = function () {
            document.getElementById('upDateRow').classList.toggle('popupAct', false);
                location.reload();
        }
        req.send(JSON.stringify(data));
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_City> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_City> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_City>)PageContext?.ViewData;
        public Pages_City Model => ViewData.Model;
    }
}
#pragma warning restore 1591
