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
    public class DepartmentsController : ControllerBase
    {
        [HttpPost("{AddDepartment}")]
        public string AddDepartment([FromBody] Department d)
        {
            List<Department> Dep = data.SELECTDepartment();
            Dep = Dep.Where(c => c.nameDepartment == d.nameDepartment).ToList();
            //var text = "";
            //Cities.ForEach(p =>
            //{
            //    text = text + ' ' + p.ToString();
            //});
            var text = JsonConvert.SerializeObject(Dep);
            if (text == "[]")
            {
                @data.AddDepartment(d.nameDepartment);
                text = "";
            }
            else
            {
                text = "!!!!!!!!!!!! מחלקה זו כבר קיימת";
            }
            return text;
        }
        [HttpGet("")]
        public int GetNext()
        {
            var dep = data.SELECTDepartment();
            var max = dep.Max(p => p.codeDepartment);
            return max+1;
        }
        [HttpGet("{mis}")]
        public string RoomsInDepartment(int mis)
    {
            List<Room> rooms = data.SELECTRoom(mis,"");
            var text = JsonConvert.SerializeObject(rooms);
            return text;
    }
        [HttpPost("DeleteDepartment")]
        public int DeleteDepartment([FromBody] int code)
        {

            data.DeleteDepartment(code);
            var dep = data.SELECTDepartment();
            return dep.Count;
        }
        [HttpPost("UpdateDepartment")]
        public void UpdateDepartment([FromBody] Department c)
        {
            List<Department> dep = data.SELECTDepartment();
            dep.First(p => p.codeDepartment == c.codeDepartment).nameDepartment = c.nameDepartment;
            data.updateDepartment(dep);
        }
        [HttpGet("{mis}/{status}")]
        public string IfRoomsAndDiadnosisesInDepartment(int mis,string status)
        {
            var flaut = "";
            List<Room> room = data.SELECTRoom();
            List<Diagnosis> diag = data.SELECTDiagnosis();
            foreach (var p in room)
                if (p.codeDepartment == mis)
                {
                    flaut = "חדרים";
                    break;
                }
            foreach (var n in diag)
            {
                if (n.codeDepartment == mis)
                {
                    if (flaut == "")
                        flaut += "אבחונים";
                    else
                        flaut += "  ואבחונים ";
                    break;
                }
            }
            return flaut;
        }
    }
}
