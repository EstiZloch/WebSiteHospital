#pragma checksum "F:\Hospital\Hospital\Pages\AddPatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cdcfff2cb0b0ad248d6cbe6caee45006e5f7635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hospital.Pages.Pages_AddPatient), @"mvc.1.0.razor-page", @"/Pages/AddPatient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AddPatient.cshtml", typeof(Hospital.Pages.Pages_AddPatient), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cdcfff2cb0b0ad248d6cbe6caee45006e5f7635", @"/Pages/AddPatient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d6098626ba32ebedbbbd3b16a27c11bc77ef90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddPatient : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("code", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", " ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("emptyCity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("emptyRoom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("emptyDiag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
   ViewData["Page"] = "Add";
    List<City> cities = data.SELECTCity();
    var max = cities.Max(p => p.codeCity);
    string dateNew = data.Convert(DateTime.Today.ToShortDateString());
    var myindex = "תאונה קשה";

#line default
#line hidden
            BeginContext(232, 458, true);
            WriteLiteral(@"<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
<div id=""tytle"">הוספת לקוח</div>

<div id=""inputDiv"">

    <div>
        <div>תעודת זהות</div>
        <input type=""text"" id=""idPatient"" class=""textbox"" />
    </div>
    <div>
        <div>שם</div>
        <input type=""text"" id=""namePatient"" class=""textbox"" />
    </div>
    <div>
        <div>תאריך לידה</div>
        <input type=""date"" id=""dateBirth"" class=""textbox""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 690, "\"", 706, 1);
#line 23 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
WriteAttributeValue("", 698, dateNew, 698, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 707, "\"", 721, 1);
#line 23 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
WriteAttributeValue("", 713, dateNew, 713, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(722, 119, true);
            WriteLiteral(" />\r\n    </div>\r\n    <div>\r\n        <div>תאריך כניסה</div>\r\n        <input type=\"date\" id=\"dateResived\" class=\"textbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 841, "\"", 857, 1);
#line 27 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
WriteAttributeValue("", 849, dateNew, 849, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(858, 98, true);
            WriteLiteral(" />\r\n    </div>\r\n    <div>\r\n        <div>עיר</div>\r\n        <select id=\"selectCity\">\r\n            ");
            EndContext();
            BeginContext(956, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d827cb0eaa48447da21fad81d9e49687", async() => {
                BeginContext(999, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(1009, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
             foreach (var p in data.SELECTCity())
            {

#line default
#line hidden
            BeginContext(1077, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1093, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07a8a57be4b84b07a6851ca65aff7df7", async() => {
                BeginContext(1141, 10, false);
#line 35 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
                                                          Write(p.nameCity);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "code", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
AddHtmlAttributeValue("", 1107, p.codeCity, 1107, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 35 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
                                      WriteLiteral(p.nameCity);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 36 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
            }

#line default
#line hidden
            BeginContext(1177, 222, true);
            WriteLiteral("        </select>\r\n    </div>\r\n    <div>\r\n        <div>תיאור</div>\r\n        <input type=\"text\" id=\"describe\" class=\"textbox\" />\r\n    </div>\r\n    <div>\r\n        <div>חדר</div>\r\n        <select id=\"selectRoom\">\r\n            ");
            EndContext();
            BeginContext(1399, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6453a812dc21422493337f7f190cd805", async() => {
                BeginContext(1442, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1452, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
             foreach (var p in data.SELECTRoom())
            {

#line default
#line hidden
            BeginContext(1520, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1536, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76eeba6d5ec949a2af5bd405568c378d", async() => {
                BeginContext(1582, 9, false);
#line 49 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
                                                        Write(p.misRoom);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "code", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
AddHtmlAttributeValue("", 1550, p.misRoom, 1550, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 49 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
                                     WriteLiteral(p.misRoom);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1600, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
            }

#line default
#line hidden
            BeginContext(1617, 115, true);
            WriteLiteral("        </select>\r\n    </div>\r\n    <div>\r\n        <div>אבחון</div>\r\n        <select id=\"selectDiag\" >\r\n            ");
            EndContext();
            BeginContext(1732, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7caea3618a4a1a9069b8065650873f", async() => {
                BeginContext(1775, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1785, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
             foreach (var p in data.SELECTDiagnosis())
            {

#line default
#line hidden
            BeginContext(1858, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1874, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3be3cb548e14b88a9199014aa97a8bb", async() => {
                BeginContext(1928, 11, false);
#line 59 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
                                                                Write(p.diagnosis);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "code", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 59 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
AddHtmlAttributeValue("", 1888, p.codeDiagnosis, 1888, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 59 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
                                           WriteLiteral(p.diagnosis);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1948, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "F:\Hospital\Hospital\Pages\AddPatient.cshtml"
            }

#line default
#line hidden
            BeginContext(1965, 2541, true);
            WriteLiteral(@"        </select>
    </div>
</div>
<div id=""linkbtn"">
    <div id=""btn"">
        <div id=""Add"">הוספה</div>
        <div id=""deleteAll"">נקה הכל</div>
    </div>
    <a href=""Patiant"" id=""links"">&lArr;חזרה </a>
</div>
<script>
    document.getElementById(""deleteAll"").addEventListener('click', function (e) {
        location.reload();
    });
    document.getElementById('Add').addEventListener('click', function (e) {
        var data = {};
        data['idPatient'] = document.getElementById(""idPatient"").value;
        data['namePatient'] = document.getElementById(""namePatient"").value;
        data['dateBirth'] = document.getElementById(""dateBirth"").value;
        data['dateResived'] = document.getElementById(""dateResived"").value;
        data['codeCity'] = document.querySelector('#selectCity').options[document.querySelector('#selectCity').selectedIndex].getAttribute(""code"");
        data['describe'] = document.getElementById(""describe"").value;
        data['codeRoom'] = document.querySelec");
            WriteLiteral(@"tor('#selectRoom').options[document.querySelector('#selectRoom').selectedIndex].getAttribute(""code"");
        data['codeDiagnosis'] = document.querySelector('#selectDiag').options[document.querySelector('#selectDiag').selectedIndex].getAttribute(""code"");
        var req = new XMLHttpRequest();
        req.open('POST', 'API/Patients/AddPatient', true);
        req.setRequestHeader('Content-Type', 'application/json; charset=utf-8');
        req.onload = function () {
          
        }
        req.send(JSON.stringify(data));
    });
    document.querySelector('#selectCity').addEventListener('change', myfunction1, false);
    function myfunction1() {
        document.querySelector('#selectCity').remove(document.querySelector('#emptyCity'));
        document.querySelector('#selectCity').removeEventListener('change', myfunction1, false);
    }
    document.querySelector('#selectRoom').addEventListener('change', myfunction2, false);
    function myfunction2() {
        document.querySelector('#se");
            WriteLiteral(@"lectRoom').remove(document.querySelector('#emptyRoom'));
        document.querySelector('#selectRoom').removeEventListener('change', myfunction2, false);
    }
    document.querySelector('#selectDiag').addEventListener('change', myfunction3, false);
    function myfunction3() {
        document.querySelector('#selectDiag').remove(document.querySelector('#emptyDiag'));
        document.querySelector('#selectDiag').removeEventListener('change', myfunction3, false);
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_AddPatient> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_AddPatient> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_AddPatient>)PageContext?.ViewData;
        public Pages_AddPatient Model => ViewData.Model;
    }
}
#pragma warning restore 1591
