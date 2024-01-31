using KendoBarPocAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KendoBarPocAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarChartController : ControllerBase
    {
        string chartData = @"
        {
            ""series"":[               
                {
                    ""data"":[
                        {""x"":""P1"", ""value"":""128.14""},
                        {""x"":""P2"", ""value"":""112.61""},
                        {""x"":""P3"", ""value"":""163.21""},
                        {""x"":""P4"", ""value"":""229.98""},
                        {""x"":""P5"", ""value"":""90.54""}
                    ]
                },
                {
                    ""data"":[
                        {""x"":""P1"", ""value"":""90.54""},
                        {""x"":""P2"", ""value"":""104.19""},
                        {""x"":""P3"", ""value"":""150.67""},
                        {""x"":""P4"", ""value"":""120.43""},
                        {""x"":""P5"", ""value"":""200.34""}
                    ]
                }               
            ]
        }";
        public BarChartController() { }

        [HttpGet]
        [Route("GetBarChartData")]
        public IActionResult GetBarChartData()
        {
            var chartDataJson = JsonConvert.DeserializeObject<Root>(chartData);
            return Ok(chartDataJson);
        }
    }
}
