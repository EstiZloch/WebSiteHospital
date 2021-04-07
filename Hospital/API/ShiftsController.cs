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
    public class ShiftsController : ControllerBase
    {
        [HttpPost("AddShift")]
        public string AddShifs([FromBody] Shift p)
        {
            var text1 = "";
            var text2 = "";
            List<Shift> shifts1 = data.SELECTShift();
            List<Shift> shifts2 = data.SELECTShift();
            shifts1 = shifts1.Where(c => data.Convert(c.date1) == p.date1 && c.startTime == p.startTime&&c.codeRoom==p.codeRoom).ToList();
            shifts2 = shifts2.Where(c => c.codeNurse == p.codeNurse && c.startTime == p.startTime && data.Convert(c.date1) == p.date1).ToList();
            text1 = JsonConvert.SerializeObject(shifts1);
            text2 = JsonConvert.SerializeObject(shifts2);
            if (text1 == "[]"&& text2 == "[]")
            {
                @data.AddShift(p); 
                return "";
            }
            else
            {
                if (text1 == "[]")
                {
                    text1 = "!!!!!!!!!!!!!!משמרת זו כבר קיימת לחדר";
                    return text1;
                }
                else
                {
                    text2 = "!!!!!!!!!!!!!!משמרת זו כבר קיימת לאחות";
                    return text2;
                }
            }
        }
        [HttpGet("")]
        public int GetNext()
        {
            var shifts = data.SELECTShift();
            var max = shifts.Max(p => p.codeShift);
            return max+1;
        }
        [HttpPost("DeleteShift")]
        public int DeleteShift([FromBody] int code)
        {

            data.DeleteShift(code);
            var shifts = data.SELECTShift();
            return shifts.Count;
        }
        [HttpPost("UpdateShift")]
        public void UpdateShift([FromBody] Shift c)
        {
            List<Shift> shifts = data.SELECTShift();
            shifts.First(p => p.codeShift == c.codeShift).codeNurse = c.codeNurse;
            shifts.First(p => p.codeShift == c.codeShift).codeRoom = c.codeRoom;
            shifts.First(p => p.codeShift == c.codeShift).startTime = c.startTime;
            shifts.First(p => p.codeShift == c.codeShift).finishTime = c.finishTime;
            shifts.First(p => p.codeShift == c.codeShift).date1 = DateTime.Parse(c.date1).ToShortDateString();
            data.updateShift(shifts);
        }
        [HttpPost("checkShift")]
        public int checkShift([FromBody] Shift c)
        {
            int flaut = 0;
            List<Shift> shifts = data.SELECTShift();
            foreach (var p in shifts)
            {
                var date = data.Convert(p.date1);
                if (p.codeRoom == c.codeRoom && p.startTime == c.startTime && date == c.date1)
                    flaut = 1;
            }
            return flaut;
        }
    }
}