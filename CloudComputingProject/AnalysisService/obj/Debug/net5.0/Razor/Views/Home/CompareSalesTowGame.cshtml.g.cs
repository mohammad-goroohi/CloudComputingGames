#pragma checksum "D:\Users\Lenovo\Document\Visual Dtudio 2019\Project\CloudComputingProject\CloudComputingProject\AnalysisService\Views\Home\CompareSalesTowGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f33187e88a2434696259e6ad0026fc18cba0b259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CompareSalesTowGame), @"mvc.1.0.view", @"/Views/Home/CompareSalesTowGame.cshtml")]
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
#line 2 "D:\Users\Lenovo\Document\Visual Dtudio 2019\Project\CloudComputingProject\CloudComputingProject\AnalysisService\Views\Home\CompareSalesTowGame.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f33187e88a2434696259e6ad0026fc18cba0b259", @"/Views/Home/CompareSalesTowGame.cshtml")]
    public class Views_Home_CompareSalesTowGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnalysisService.Models.vmCompareTowGame>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n    am4core.ready(function () {\r\n        let chart = am4core.createFromConfig({\r\n                \"type\": \"XYChart3D\",\r\n            \"data\": ");
#nullable restore
#line 7 "D:\Users\Lenovo\Document\Visual Dtudio 2019\Project\CloudComputingProject\CloudComputingProject\AnalysisService\Views\Home\CompareSalesTowGame.cshtml"
               Write(Html.Raw(JsonConvert.SerializeObject(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                ""xAxes"": [{
                        ""type"": ""CategoryAxis"",
                    ""dataFields"": {
                            ""category"": ""Platform""
                    },
                    ""renderer"": {
                            ""grid"": {
                                ""template"": {
                                    ""type"": ""Grid"",
                                ""location"": 0
                                }
                            },
                        ""minGridDistance"": 30,
                        ""cellStartLocation"": 0.2,
                        ""cellEndLocation"": 0.8
                    }
                    }],
                ""yAxes"": [{
                        ""type"": ""ValueAxis"",
                    ""min"": 0,
                    ""renderer"": {
                            ""maxLabelPosition"": 0.98
                    }
                    }],
                ""series"": [{
                    ""type"": ""ColumnSeries3D"",
                    ""name"":");
            WriteLiteral(@" ""NA_Sales"",
                    ""columns"": {
                            ""template"": {
                                ""type"": ""Column3D"",
                            ""strokeOpacity"": 0,
                            ""tooltipText"": ""{categoryX}\n{valueY}"",
                            ""tooltipPosition"": ""pointer""
                            }
                        },
                    ""dataFields"": {
                            ""valueY"": ""NA_Sales"",
                        ""categoryX"": ""Platform""
                    },
                    ""sequencedInterpolation"": true,
                    ""sequencedInterpolationDelay"": 100
                }, {
                        ""type"": ""ColumnSeries3D"",
                        ""name"": ""EU_Sales"",
                    ""columns"": {
                            ""template"": {
                                ""type"": ""Column3D"",
                            ""strokeOpacity"": 0,
                            ""tooltipText"": ""{categoryX}\n{valueY}"",
         ");
            WriteLiteral(@"                   ""tooltipPosition"": ""pointer""
                            }
                        },
                    ""dataFields"": {
                            ""valueY"": ""EU_Sales"",
                        ""categoryX"": ""Platform""
                    },
                    ""sequencedInterpolation"": true,
                    ""sequencedInterpolationDelay"": 100
                },
                {
                    ""type"": ""ColumnSeries3D"",
                    ""name"": ""JP_Sales"",
                    ""columns"": {
                            ""template"": {
                                ""type"": ""Column3D"",
                            ""strokeOpacity"": 0,
                            ""tooltipText"": ""{categoryX}\n{valueY}"",
                            ""tooltipPosition"": ""pointer""
                            }
                        },
                    ""dataFields"": {
                            ""valueY"": ""JP_Sales"",
                        ""categoryX"": ""Platform""
                 ");
            WriteLiteral(@"   },
                    ""sequencedInterpolation"": true,
                    ""sequencedInterpolationDelay"": 100
                },
                {
                    ""type"": ""ColumnSeries3D"",
                    ""name"": ""Other_Sales"",
                    ""columns"": {
                            ""template"": {
                                ""type"": ""Column3D"",
                            ""strokeOpacity"": 0,
                            ""tooltipText"": ""{categoryX}\n{valueY}"",
                            ""tooltipPosition"": ""pointer""
                            }
                        },
                    ""dataFields"": {
                            ""valueY"": ""Other_Sales"",
                        ""categoryX"": ""Platform""
                    },
                    ""sequencedInterpolation"": true,
                    ""sequencedInterpolationDelay"": 100
                },
                {
                    ""type"": ""ColumnSeries3D"",
                    ""name"": ""Global_Sales"",
         ");
            WriteLiteral(@"           ""columns"": {
                            ""template"": {
                                ""type"": ""Column3D"",
                            ""strokeOpacity"": 0,
                            ""tooltipText"": ""{categoryX}\n{valueY}"",
                            ""tooltipPosition"": ""pointer""
                            }
                        },
                    ""dataFields"": {
                            ""valueY"": ""Global_Sales"",
                        ""categoryX"": ""Platform""
                    },
                    ""sequencedInterpolation"": true,
                    ""sequencedInterpolationDelay"": 100
                }],
            ""legend"": {
                ""type"": ""Legend"",
                ""position"": ""right""
            }
            },
            document.getElementById('chartdiv')
        );
    });
</script>
<div id=""chartdiv"" style=""width:100%; height:500px;margin-top:150px""></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnalysisService.Models.vmCompareTowGame>> Html { get; private set; }
    }
}
#pragma warning restore 1591
