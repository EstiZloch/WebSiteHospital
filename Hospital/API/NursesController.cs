using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hospital.API
{
    [Route("API/[Controller]")]
    [ApiController]
    public class NursesController : ControllerBase
    {
        [HttpPost("AddNurse")]
        public string Check([FromBody] Nurse p)
        {
            List<Nurse> nurses = data.SELECTNurse();
            nurses = nurses.Where(c => c.idNurse == p.idNurse).ToList();
            var text = JsonConvert.SerializeObject(nurses);
            if (text == "[]")
            {
                @data.AddNurse(p);
                text = "";
            }
            else
            {
                text = "!!!!!!!!!!!!!!!!!אחות זו כבר קיימת";
            }
            return text;
        }
        [HttpGet("{id}")]
        public string ShiftsToNurse(string id)
        {
            List<Shift> shifts = data.SELECTShift(id);
            var text = JsonConvert.SerializeObject(shifts);
            return text;
        }
        [HttpPost("DeleteNurse")]
        public int DeletePatient([FromBody] string id)
        {

            data.DeleteNurse(id);
            var nurses = data.SELECTNurse();
            return nurses.Count;
        }
        [HttpPost("UpdateNurse")]
        public void UpdatePatient([FromBody] Nurse c)
        {
            List<Nurse> nurses = data.SELECTNurse();
            nurses.First(p => p.idNurse == c.idNurse).nameNurse = c.nameNurse;
            nurses.First(p => p.idNurse == c.idNurse).codeCity = c.codeCity;
            nurses.First(p => p.idNurse == c.idNurse).adress = c.adress;
            nurses.First(p => p.idNurse == c.idNurse).price = c.price;
            data.updateNurse(nurses);
        }
        [HttpPost("FreeNurse")]
        public List<Nurse> FreeNurse([FromBody] Shift s)
        {
            List<Shift> shifts = data.SELECTShift();
            List<Nurse> nurses = new List<Nurse>();
            foreach (var p in shifts)
            {
                var date = data.Convert(p.date1);
                if (p.startTime == s.startTime && date == s.date1)
                    nurses.Add(new Nurse() { idNurse = p.codeNurse });
            }
            List<Nurse> nurse = data.SELECTNurse();
            List<Nurse> nurseNew = new List<Nurse>();
            foreach(var n in nurse)
            {
                int flaut = 0;
                foreach(var n1 in nurses)
                {
                    if (n1.idNurse == n.idNurse)
                        flaut = 1;
                }
                if (flaut == 0)
                    nurseNew.Add(new Nurse() { idNurse = n.idNurse ,nameNurse=n.nameNurse});
            }
            return nurseNew;
        }
        [HttpGet("{id}/{status}")]
        public string IfShiftsInNurse(string id,string status)
        {
            var flaut = "";
            List<Shift> shift = data.SELECTShift();
            foreach (var p in shift)
                if (p.codeNurse == id&&DateTime.Parse(p.date1)>=DateTime.Today&&DateTime.Parse(p.finishTime).Hour>DateTime.Today.Hour)
                {
                    flaut = "משמרות";
                    break;
                }
            return flaut;
        }
    }
}

   
