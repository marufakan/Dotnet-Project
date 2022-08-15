#pragma checksum "C:\Users\90553\source\repos\DataApi\CurrencyWebSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84587b860bb39f4ab1f1b141814178d7be83909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\90553\source\repos\DataApi\CurrencyWebSite\Views\_ViewImports.cshtml"
using CurrencyWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90553\source\repos\DataApi\CurrencyWebSite\Views\_ViewImports.cshtml"
using CurrencyWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84587b860bb39f4ab1f1b141814178d7be83909", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"606d570b2c3d12d97b60950eb59b86889dcb665b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\90553\source\repos\DataApi\CurrencyWebSite\Views\Home\Index.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84587b860bb39f4ab1f1b141814178d7be839093933", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.11.3/css/jquery.dataTables.min.css"">
    <link href='https://unpkg.com/boxicons@2.0.9/css/boxicons.min.css' rel='stylesheet'>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx"" crossorigin=""anonymous"">
    <script>
        $(document).ready(function () {
            var liste = [""US DOLLAR"", ""AUSTRALIAN DOLLAR"", ""DANISH KRONE"", ""EURO"", ""POUND STERLING"", ""SWISS FRANK"",
                ""SWEDISH KRONA"", ""CANADIAN DOLLAR"", ""KUWAITI DINAR"", ""NORWEGIAN KRONE"", ""SAUDI RIYAL"", ""JAPENESE YEN"",
                ""BULGARIAN LEV"", ""NEW LEU"", ""RUSSIAN ROUBLE"", ""IRANIAN RIAL"", ""CHINESE RENMINBI"", ""PAKISTANI RUPEE"",
                ""QATARI RIAL"", ""SOUTH KOREAN WON"", ""AZERBAIJANI NEW MANAT"", ""UNITED ARAB EMIRATES DIR");
                WriteLiteral(@"HAM"",
                ""SPECIAL DRAWING RIGHT (SDR)""
            ];
            for (let i = 0; i < liste.length; i++) {
                let options = `<option value=""${liste[i]}"">${liste[i]}</option>`
                $(""#currencyName"").append(options);
            }

            var searchWord;
            $('#currencyName').change(function () {
                searchWord = $(this).val();
            })

            var myChart = echarts.init(document.getElementById('main'));
            let historyDates = [];
            let historyPrices = [];
            $(""button"").click(function () {
                historyDates.splice(0, historyDates.length);
                historyPrices.splice(0, historyPrices.length);
                $.ajax({
                    type: ""GET"",
                    url: ""http://localhost:1236/api/Default/CurrencyList"",
                    beforeSend: function () {
                        $(""#main"").attr(""hidden"", true);
                    },
                    ");
                WriteLiteral(@"success: function (response) {
                        $(""#main"").removeAttr(""hidden"");
                        $.each(response.filter(x => x.currencyName === searchWord), function (k, v) {
                            historyPrices.push(parseFloat(v.forexBuying));
                            historyDates.push(v.date);
                            //console.log(v.currencyName)
                            //console.log(searchWord);
                        });
                        option = {
                            tooltip: {
                                trigger: 'axis'
                            },
                            xAxis: [{
                                type: 'category',
                                data: historyDates,
                                axisLine: {
                                    lineStyle: {
                                        color: ""#999""
                                    }
                                },
                              ");
                WriteLiteral(@"  axisLabel: {
                                    rotate: 60
                                }
                            }],
                            yAxis: [{
                                type: 'value',
                                splitNumber: 4,
                                splitLine: {
                                    lineStyle: {
                                        type: 'dashed',
                                        color: '#DDD'
                                    }
                                },
                                axisLine: {
                                    show: false,
                                    lineStyle: {
                                        color: ""#333""
                                    },
                                },
                                nameTextStyle: {
                                    color: ""#999""
                                },
                                splitArea: {
              ");
                WriteLiteral(@"                      show: false
                                }
                            }],
                            series: [{
                                name: 'price',
                                type: 'line',
                                data: historyPrices,
                                lineStyle: {
                                    normal: {
                                        width: 2,
                                        color: {
                                            type: 'linear',
                                            colorStops: [{

                                                offset: 0,
                                                color: 'orange'
                                            }],
                                            globalCoord: false
                                        },
                                        shadowColor: 'rgba(72,216,191, 0.3)',
                                    }
               ");
                WriteLiteral(@"                 },
                                itemStyle: {
                                    normal: {
                                        color: 'black',
                                        borderWidth: 12,
                                        borderColor: ""black""
                                    }
                                },
                                smooth: true
                            }]
                        };
                        myChart.setOption(option);
                    },
                    error: function () {
                        console.log(""error"")
                    },
                });
            });
        });
    </script>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84587b860bb39f4ab1f1b141814178d7be8390911014", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col\"></div>\r\n        <div class=\"col\">\r\n            <select id=\"currencyName\" class=\"form-select\" aria-label=\"Default select example\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84587b860bb39f4ab1f1b141814178d7be8390911488", async() => {
                    WriteLiteral("Please select a currency");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>
        <div class=""col""><button class=""btn btn-primary"">Click</button></div>
    </div>
    <div hidden id=""main"" style=""width: 800px;height:550px;""></div>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/echarts/5.2.1/echarts.min.js""
            integrity=""sha512-17GGcT5BjSbaXG+4Fk3Z1HS1ATXH5oEH060GS3WvSEqGGpkSbRV/amkIWpqOJOIwkBW13QMOBblj8DXnlN7bEA==""
            crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-A3rJD856KowSb7dwlZdYEkO39Gagi7vIsF0jrRAoQmDKKtQBHUuLZ9AsSv4jD4Xa"" crossorigin=""anonymous"">
    </script>

");
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
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
