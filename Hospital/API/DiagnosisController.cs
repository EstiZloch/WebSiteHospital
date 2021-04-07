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
        public class DiagnosisController : ControllerBase
        {
        [HttpPost("AddDiag")]
        public string AddDiag([FromBody] Diagnosis p)
        {
            List<Diagnosis> diag = data.SELECTDiagnosis();
            diag = diag.Where(c => c.diagnosis == p.diagnosis&&c.codeDepartment==p.codeDepartment).ToList();
            var text = JsonConvert.SerializeObject(diag);
            if (text == "[]")
            {
                @data.AddDiag(p.codeDepartment,p.diagnosis,p.misDays);
                text = "";
            }
            else
            {
                text = "!!!!!!!!!!!!!! אבחון זה כבר קיים";
            }
            return text;
        }
        [HttpGet("{mis}")]
            public string DiagnosisByCodeDepartment(int mis)
            {
                List<Diagnosis> diag = data.SELECTDiagnosis(mis);
                var text = JsonConvert.SerializeObject(diag);
                return text;
            }
        [HttpPost("DeleteDiag")]
        public int DeleteRoom([FromBody] int code)
        {
            data.DeleteDiag(code);
            var diag = data.SELECTDiagnosis();
            return diag.Count;
        }
        [HttpGet("")]
        public int GetNext()
        {
            var diag = data.SELECTDiagnosis();
            var max = diag.Max(p => p.codeDiagnosis);
            return max;
        }
        [HttpPost("UpdateDiag")]
        public void UpdateRoom([FromBody] Diagnosis c)
        {
            List<Diagnosis> diag = data.SELECTDiagnosis();
            diag.First(p => p.codeDiagnosis == c.codeDiagnosis).codeDepartment = c.codeDepartment;
            diag.First(p => p.codeDiagnosis == c.codeDiagnosis).diagnosis = c.diagnosis;
            diag.First(p => p.codeDiagnosis == c.codeDiagnosis).misDays = c.misDays;
            data.updateDiag(diag);
        }
        [HttpGet("{mis}/{status}")]
        public string IfPatientsInDiagnosis(int mis, string status)
        {
            var flaut = "";
            List<Patient> pat = data.SELECTPatient();
            foreach (var p in pat)
                if (p.codeDiagnosis == mis)
                {
                    flaut = "חולים";
                    break;
                }
            return flaut;
        }
    }
    }

