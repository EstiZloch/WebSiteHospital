using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.API
{
    [Route("API/[Controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpPost("AddCity")]
        public string AddCity([FromBody] City p)
        {
            List<City> Cities = data.SELECTCity();
            Cities = Cities.Where(c => c.nameCity == p.nameCity).ToList();
            var text = JsonConvert.SerializeObject(Cities);
            if (text == "[]")
            {
                @data.AddCity(p.nameCity);
                text = "";
            }
            else
            {
                text = " !!!!!!!!!!!!!!!!!עיר זו כבר קיימת";
            }
            return text;
        }
        [HttpGet("")]
        public int GetNext()
        {
            var cities = data.SELECTCity();
            var max = cities.Max(p => p.codeCity);
            return max;
        }
        [HttpPost("DeleteCity")]
        public int deleteCity([FromBody] int code)
        {
           
            data.DeleteCity(code);
           var cities = data.SELECTCity();
            return cities.Count;
        }
        [HttpPost("UpdateCity")]
        public void UpdateCity([FromBody] City c)
        {
            List<City> Cities = data.SELECTCity();
            Cities.First(p => p.codeCity == c.codeCity).nameCity = c.nameCity;
            data.updateCity(Cities);
        }
        [HttpGet("{mis}")]
        public string IfPatientsAndNursesInCity(int mis)
        {
            var flaut = "";
            List<Patient> pat = data.SELECTPatient();
            List<Nurse> nur = data.SELECTNurse();
            foreach (var p in pat)
                if (p.codeCity == mis)
                {
                    flaut = "חולים";
                    break;
                }
            foreach (var n in nur)
            {
                if (n.codeCity == mis)
                {if(flaut=="")
                    flaut += "אחיות";
                else
                        flaut += "  ואחיות ";
                    break;
                }
            }
            return flaut;
        }
    }
}

