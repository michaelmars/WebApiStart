using System;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace WebApiProj1.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class DronereportController
    {
        [HttpGet("{option}")]
        public object Get(string option)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                };

                string filename = "dronereport_option_" + option + ".json";
                var jsonString = File.ReadAllText("Jsons\\dronereport_option_full.json");
                return jsonString;
            }
            catch
            {
            }

            return "error";
        }
    }
}
