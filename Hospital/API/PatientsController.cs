using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;

namespace Hospital.API
{
    [Route("API/[Controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        [HttpPost("AddPatient")]
        public string AddPatient([FromBody] Patient p)
        {
            List<Patient> patinet = data.SELECTPatient();
            patinet = patinet.Where(c => c.idPatient == p.idPatient).ToList();
            var text = JsonConvert.SerializeObject(patinet);
                @data.AddPatient(p);
                text = "";
            return text;
        }

        [HttpGet("{mis}/{status}")]
        public List<Patient> PatientsInRoom(int mis,string status)
        {
            return data.PatientsInRoom(mis);
        }
        [HttpGet("{id}")]
        public string PatientDetail(string id)
        {
            List<string> str = new List<string>();
            List<Patient> patients = data.SELECTPatient();
            Patient pat = new Patient();
           pat.namePatient= patients.First(p => p.idPatient == id).namePatient;
           pat.dateBirth= patients.First(p => p.idPatient == id).dateBirth ;
           pat.dateResived= patients.First(p => p.idPatient ==id).dateResived ;
           pat.codeCity= patients.First(p => p.idPatient == id).codeCity;
           pat.describe= patients.First(p => p.idPatient == id).describe ;
           pat.codeRoom= patients.First(p => p.idPatient == id).codeRoom ;
            pat.codeDiagnosis = patients.First(p => p.idPatient == id).codeDiagnosis;
            str.Add(pat.namePatient);
            str.Add((DateTime.Today.Year - DateTime.Parse(pat.dateBirth).Year).ToString());
            var d = data.SELECTDiagnosisByCode(pat.codeDiagnosis);
            str.Add(d.diagnosis);
            var num = data.SELECTRoom(pat.codeRoom);
            str.Add(data.SELECTDepartment(num));
            str.Add(pat.dateResived);
            str.Add((DateTime.Parse(pat.dateResived).AddDays(d.misDays)).ToShortDateString());
            if ((DateTime.Parse(pat.dateResived).AddDays(d.misDays)) < DateTime.Today)
                str.Add("הלקוח כבר שוחרר מבית החולים");
            else
            str.Add(data.SELECNurseToShift(pat.codeRoom));
            str.Add(pat.codeRoom.ToString());

            var text = JsonConvert.SerializeObject(str);
            return text;
        }
        [HttpGet("{mis}/{status1}/{status2}")]
        public int IfPatientsInRoom(int mis,string status1,string status2)
        {
            return data.Patients(mis);
        }
        [HttpPost("DeletePatient")]
        public int DeletePatient([FromBody] string id)
        {

            data.DeletePatient(id);
            var patients = data.SELECTPatient();
            return patients.Count;
        }
        [HttpPost("UpdatePatient")]
        public void UpdatePatient([FromBody] Patient c)
        {
            List<Patient> patients = data.SELECTPatient();
            patients.First(p => p.idPatient == c.idPatient).namePatient = c.namePatient;
            patients.First(p => p.idPatient == c.idPatient).dateBirth = DateTime.Parse( c.dateBirth).ToShortDateString();
            patients.First(p => p.idPatient == c.idPatient).dateResived = DateTime.Parse(c.dateResived).ToShortDateString();
            patients.First(p => p.idPatient == c.idPatient).codeCity = c.codeCity;
            patients.First(p => p.idPatient == c.idPatient).describe = c.describe;
            patients.First(p => p.idPatient == c.idPatient).codeRoom = c.codeRoom;
            patients.First(p => p.idPatient == c.idPatient).codeDiagnosis = c.codeDiagnosis;
            data.updatePatient(patients);
        }
    }
}

