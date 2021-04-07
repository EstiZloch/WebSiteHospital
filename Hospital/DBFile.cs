using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Hospital
{
    public class DBFile
    {
        public int NurseIndex(string id)
        {
            List<Nurse> nurses = data.SELECTNurse();
            var counter = 0;
            foreach (var n in nurses)
            {
                if (n.idNurse != id)
                    counter++;
                else
                    break;
            }
            return counter;
        }
    }

    public static class data
    {
        static string  nameDepartment;
        static int numDepartment;
        public static int CreateDB()
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory+"Hospital");
            return 1;
        }
        public static int CreateCity()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Cities.txt";
            List<City> Cities = new List<City>() {
        new City(){codeCity=1,nameCity="ירושלים"},
         new City(){codeCity=2,nameCity="רכסים"},
          new City(){codeCity=3,nameCity="תל אביב"},
           new City(){codeCity=4,nameCity="בני ברק"},
            new City(){codeCity=5,nameCity="חיפה"},
             new City(){codeCity=6,nameCity="צפת"},
              new City(){codeCity=7,nameCity="מירון"},
               new City(){codeCity=8,nameCity="באר שבע"},
                new City(){codeCity=9,nameCity="רמת גן"},
                 new City(){codeCity=10,nameCity="אילת"}
    };
            using (StreamWriter sw = File.CreateText(path))
            {
                Cities.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static int CreateDepartment()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Departments.txt";
            List<Department> Departments = new List<Department>() {

        new Department(){codeDepartment=1,nameDepartment="יולדות"},
      new Department(){codeDepartment=2,nameDepartment="מיון"},
       new Department(){codeDepartment=3,nameDepartment="ילודים"},
        new Department(){codeDepartment=4,nameDepartment="ילדים"},
         new Department(){codeDepartment=5,nameDepartment="פנימית"},
      new Department(){codeDepartment=6,nameDepartment="נוירולוגיה"},
       new Department(){codeDepartment=7,nameDepartment="עיניים"},
        new Department(){codeDepartment=8,nameDepartment="אף אוזן גרון"},
         new Department(){codeDepartment=9,nameDepartment="כירוגיה"},
               new Department(){codeDepartment=10,nameDepartment="אונקולוגיה"},
        };
            using (StreamWriter sw = File.CreateText(path))
            {
                Departments.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static int CreateRoom()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            List<Room> Rooms = new List<Room>()
{
   new Room(){misRoom=300,codeDepartment=4,amountBeds=2},
     new Room(){misRoom=301,codeDepartment=2,amountBeds=1},
       new Room(){misRoom=302,codeDepartment=4,amountBeds=3},
         new Room(){misRoom=303,codeDepartment=5,amountBeds=10},
         new Room(){misRoom=304,codeDepartment=4,amountBeds=2},
     new Room(){misRoom=305,codeDepartment=2,amountBeds=1},
       new Room(){misRoom=306,codeDepartment=4,amountBeds=3},
         new Room(){misRoom=307,codeDepartment=8,amountBeds=10},
                new Room(){misRoom=308,codeDepartment=6,amountBeds=3},
         new Room(){misRoom=309,codeDepartment=9,amountBeds=10}
    };
            using (StreamWriter sw = File.CreateText(path))
            {
                Rooms.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static int CreateDiagnosis()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Diagnosises.txt";
            List<Diagnosis> diag = new List<Diagnosis>()
{
   new Diagnosis(){codeDiagnosis=1,codeDepartment=4,diagnosis="התייבשות",misDays=2},
   new Diagnosis(){codeDiagnosis=2,codeDepartment=1,diagnosis="לידה",misDays=3},
   new Diagnosis(){codeDiagnosis=3,codeDepartment=1,diagnosis="לידה",misDays=3},
   new Diagnosis(){codeDiagnosis=4,codeDepartment=4,diagnosis="תאונה קשה",misDays=39},
   new Diagnosis(){codeDiagnosis=5,codeDepartment=7,diagnosis="דלקת",misDays=1},
   new Diagnosis(){codeDiagnosis=6,codeDepartment=7,diagnosis="עוורון צבעים",misDays=4},
   new Diagnosis(){codeDiagnosis=7,codeDepartment=10,diagnosis="טיפולים",misDays=4},
   new Diagnosis(){codeDiagnosis=8,codeDepartment=3,diagnosis="צהבת",misDays=3},
   new Diagnosis(){codeDiagnosis=9,codeDepartment=9,diagnosis="בעיה לבבית",misDays=20},
   new Diagnosis(){codeDiagnosis=10,codeDepartment=5,diagnosis="שבר באגן",misDays=20},
   new Diagnosis(){codeDiagnosis=11,codeDepartment=6,diagnosis="קריש דם",misDays=30},
   new Diagnosis(){codeDiagnosis=12,codeDepartment=8,diagnosis="ניתוח",misDays=3},
   new Diagnosis(){codeDiagnosis=13,codeDepartment=4,diagnosis="כוויות קשות",misDays=50},
   new Diagnosis(){codeDiagnosis=14,codeDepartment=2,diagnosis="נפילה",misDays=8},
   new Diagnosis(){codeDiagnosis=15,codeDepartment=2,diagnosis="חום גבוה מאד",misDays=2}
    };
            using (StreamWriter sw = File.CreateText(path))
            {
                diag.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static int CreatePatient()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Patients.txt";
            List<Patient> Patients = new List<Patient>() {
         new Patient() { idPatient = "111111111", namePatient = "יפה", dateBirth = DateTime.Parse("02/02/2000").ToShortDateString(), dateResived = DateTime.Parse("02/02/2020").ToShortDateString(), codeRoom = 300,describe = "",codeCity = 1 },
           new Patient() { idPatient = "222222222", namePatient = "ציפי", dateBirth = DateTime.Parse("02/02/1990").ToShortDateString(), dateResived = DateTime.Parse("02/06/2020").ToShortDateString(), codeRoom = 301,describe = "",codeCity = 2 },
             new Patient() { idPatient = "333333333", namePatient = "חוה", dateBirth = DateTime.Parse("02/02/1940").ToShortDateString(), dateResived = DateTime.Parse("02/07/2020").ToShortDateString(), codeRoom = 302,describe = "",codeCity = 3 },
                      new Patient() { idPatient = "444444444", namePatient = "יעל", dateBirth = DateTime.Parse("04/04/2000").ToShortDateString(), dateResived = DateTime.Parse("02/02/2020").ToShortDateString(), codeRoom = 309,describe = "",codeCity = 2 },
           new Patient() { idPatient = "555555555", namePatient = "תהילה", dateBirth = DateTime.Parse("22/12/1990").ToShortDateString(), dateResived = DateTime.Parse("02/06/2020").ToShortDateString(), codeRoom = 303,describe = "",codeCity = 8 },
             new Patient() { idPatient = "666666666", namePatient = "מרים", dateBirth = DateTime.Parse("02/02/2002").ToShortDateString(), dateResived = DateTime.Parse("02/07/2020").ToShortDateString(), codeRoom = 308,describe = "",codeCity = 5 },         new Patient() { idPatient = "111111111", namePatient = "יפה", dateBirth = DateTime.Parse("02/02/2000").ToShortDateString(), dateResived = DateTime.Parse("02/02/2020").ToShortDateString(), codeRoom = 300,describe = "",codeCity = 1 },
           new Patient() { idPatient = "777777777", namePatient = "אילת", dateBirth = DateTime.Parse("13/07/1879").ToShortDateString(), dateResived = DateTime.Parse("02/06/2020").ToShortDateString(), codeRoom = 305,describe = "",codeCity = 4 },
             new Patient() { idPatient = "888888888", namePatient = "טליה", dateBirth = DateTime.Parse("01/02/2003").ToShortDateString(), dateResived = DateTime.Parse("02/07/2020").ToShortDateString(), codeRoom = 305,describe = "",codeCity = 9 },
                      new Patient() { idPatient = "999999999", namePatient = "נוגה", dateBirth = DateTime.Parse("18/02/1976").ToShortDateString(), dateResived = DateTime.Parse("02/02/2020").ToShortDateString(), codeRoom = 300,describe = "",codeCity = 6 },
    };
            using (StreamWriter sw = File.CreateText(path))
            {
                Patients.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static int CreateNurse()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Nurses.txt";
            List<Nurse> Nurses = new List<Nurse>()
{
    new Nurse() { idNurse = "207426074", nameNurse = "שרית",adress = "עוזיאל",codeCity = 1,price = 1000 },
    new Nurse() { idNurse = "033396235", nameNurse = "נעמה",adress = "נרקיסים",codeCity = 2,price = 1150 },
             new Nurse() { idNurse = "025547787", nameNurse = "אירית",adress = "ורדים",codeCity = 3,price = 2000 },
                 new Nurse() { idNurse = "212345670", nameNurse = "מינה",adress = "שמעונוביץ",codeCity = 4,price = 8000 },
                     new Nurse() { idNurse = "234567890", nameNurse = "חיה",adress = "לב אליהו",codeCity = 5,price = 5090 },
                         new Nurse() { idNurse = "823714596", nameNurse = "נעמי",adress = "כלניות",codeCity = 6,price = 3546 },
                             new Nurse() { idNurse = "378944356", nameNurse = "לייקי",adress = "חצב",codeCity = 1,price = 2765 },
                                                  new Nurse() { idNurse = "121218763", nameNurse = "מלכי",adress = "קבלן",codeCity = 9,price = 10000 },
                         new Nurse() { idNurse = "243536172", nameNurse = "מילה",adress = "ראם",codeCity = 7,price = 8000 },
                             new Nurse() { idNurse = "182736534", nameNurse = "אהובה",adress = "קצנלבוגן",codeCity = 1,price = 3000 }
    };
            using (StreamWriter sw = File.CreateText(path))
            {
                Nurses.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static int CreateShift()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Shifts.txt";
            List<Shift> Shifts = new List<Shift>() {
     new Shift() { codeShift = 1, codeNurse = "207426974",codeRoom = 300,startTime = DateTime.Parse("09:00").ToShortTimeString(),finishTime = DateTime.Parse("13:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
          new Shift() { codeShift = 2, codeNurse = "207426974",codeRoom = 301,startTime = DateTime.Parse("14:00").ToShortTimeString(),finishTime = DateTime.Parse("18:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
               new Shift() { codeShift = 3, codeNurse = "03396235",codeRoom = 302,startTime = DateTime.Parse("18:00").ToShortTimeString(),finishTime = DateTime.Parse("22:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
                new Shift() { codeShift = 4, codeNurse = "025547787",codeRoom = 305,startTime = DateTime.Parse("18:00").ToShortTimeString(),finishTime = DateTime.Parse("22:00").ToShortTimeString() ,date1= DateTime.Parse("12/07/2020").ToShortDateString()},
                 new Shift() { codeShift = 5, codeNurse = "03396235",codeRoom = 401,startTime = DateTime.Parse("18:00").ToShortTimeString(),finishTime = DateTime.Parse("22:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
                      new Shift() { codeShift = 6, codeNurse = "182736534",codeRoom = 300,startTime = DateTime.Parse("09:00").ToShortTimeString(),finishTime = DateTime.Parse("13:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
          new Shift() { codeShift = 7, codeNurse = "207426974",codeRoom = 301,startTime = DateTime.Parse("14:00").ToShortTimeString(),finishTime = DateTime.Parse("18:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
               new Shift() { codeShift = 8, codeNurse = "243536172",codeRoom = 302,startTime = DateTime.Parse("18:00").ToShortTimeString(),finishTime = DateTime.Parse("22:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
                new Shift() { codeShift = 9, codeNurse = "182736534",codeRoom = 309,startTime = DateTime.Parse("18:00").ToShortTimeString(),finishTime = DateTime.Parse("22:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() },
                 new Shift() { codeShift = 10, codeNurse = "243536172",codeRoom = 308,startTime = DateTime.Parse("18:00").ToShortTimeString(),finishTime = DateTime.Parse("22:00").ToShortTimeString(),date1= DateTime.Parse("12/07/2020").ToShortDateString() }
    };
            using (StreamWriter sw = File.CreateText(path))
            {
                Shifts.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                    
                });
            }
            return 1;
        }
        public static List<City> SELECTCity()
        {
            List<City> Cities = new List<City>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Cities.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    Cities.Add(new City() { codeCity = int.Parse(data[0]), nameCity = data[1] });
                }
            }
            return Cities;
        }
        public static List<Department> SELECTDepartment()
        {
            List<Department> departments = new List<Department>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Departments.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    departments.Add(new Department() { codeDepartment = int.Parse(data[0]), nameDepartment = data[1] });
                }
            }
            return departments;
        }
        public static string SELECTDepartment(int mis)
        {
            List<Department> departments = new List<Department>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Departments.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (int.Parse(data[0]) == mis)
                        nameDepartment = data[1];
                }
            }
            return nameDepartment;
        }
        public static List<Diagnosis> SELECTDiagnosis()
        {
            List<Diagnosis> diag = new List<Diagnosis>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Diagnosises.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    diag.Add(new Diagnosis() { codeDiagnosis = int.Parse(data[0]), codeDepartment = int.Parse(data[1]), diagnosis = data[2], misDays = int.Parse(data[3]) });
                }
            }
            return diag;
        }
        public static List<Diagnosis> SELECTDiagnosis(int mis)
        {
            List<Diagnosis> diag = new List<Diagnosis>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Diagnosises.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (int.Parse(data[1]) == mis)
                        diag.Add(new Diagnosis() { codeDiagnosis = int.Parse(data[0]), codeDepartment =mis, diagnosis = data[2], misDays = int.Parse(data[3]) });
                }
            }
            return diag; ;
        }
        public static Diagnosis SELECTDiagnosisByCode(int mis)
        {
            Diagnosis d=new Diagnosis ();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Diagnosises.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (int.Parse(data[0]) == mis)
                    {
                        d.codeDiagnosis = int.Parse(data[0]); d.codeDepartment = int.Parse(data[1]); d.diagnosis = data[2]; d.misDays = int.Parse(data[3]);
                    }
                }
            }
            return d; 
        }
        public static List<Room> SELECTRoom()
        {
            List<Room> Rooms = new List<Room>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    Rooms.Add(new Room() { misRoom = int.Parse(data[0]), codeDepartment = int.Parse(data[1]), amountBeds = int.Parse(data[2]) });
                }
            }
            return Rooms;
        }
        public static List<Room> SELECTRoomInDepartment(int mis)
        {
            List<Room> Rooms = new List<Room>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if(int.Parse(data[1])==mis)
                    Rooms.Add(new Room() { misRoom = int.Parse(data[0]), codeDepartment = int.Parse(data[1]), amountBeds = int.Parse(data[2]) });
                }
            }
            return Rooms;
        }
        public static int Patients(int codeRoom)
        {
            DateTime date;
            int misDays = 0, count = 0, amount = 0;
            List<Diagnosis> diag = data.SELECTDiagnosis();
            List<Room> rooms = data.SELECTRoom();
            List<Patient> patients = data.SELECTPatient(codeRoom);
            foreach (var patient in patients)
            {
                foreach (var d in diag)
                {
                    if (d.codeDiagnosis == patient.codeDiagnosis)
                        misDays = d.misDays;
                }
                date = DateTime.Parse(patient.dateResived).AddDays(misDays);
                if (date > DateTime.Today)
                    count++;
            }
            foreach (var r in rooms)
            {
                if (r.misRoom == codeRoom)
                    amount = r.amountBeds;
            }
            if (amount <= count)
                return 0;
            return 1;
        }
        public static List<Patient> PatientsInRoom(int code)
        {
            DateTime date;
            int misDays = 0;
            List<Diagnosis> diag = data.SELECTDiagnosis();
            List<Patient> patients = data.SELECTPatient(code);
            List<Patient> patientFit = new List<Patient>();
            foreach (var patient in patients)
            {
                foreach (var d in diag)
                {
                    if (d.codeDiagnosis == patient.codeDiagnosis)
                        misDays = d.misDays;
                }
                date = DateTime.Parse(patient.dateResived).AddDays(misDays);
                if (date > DateTime.Today)
                    patientFit.Add(patient);
            }
            return patientFit;
        }
        public static int SELECTRoom(int mis)
        {
            
            List<Room> Rooms = new List<Room>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (int.Parse(data[0]) == mis)
                        numDepartment = int.Parse(data[1]);  
                }
            }
            return numDepartment;
        }
        public static List<Room> SELECTRoom(int mis,string status)
        {

            List<Room> Rooms = new List<Room>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (int.Parse(data[1]) == mis)
                        Rooms.Add(new Room() {misRoom = int.Parse(data[0]), codeDepartment = int.Parse(data[1]), amountBeds = int.Parse(data[2]) });
                }
            }
            return Rooms;
        }
        public static List<Patient> SELECTPatient()
        {
            List<Patient> Patients = new List<Patient>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Patients.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    Patients.Add(new Patient() { idPatient = data[0], namePatient = data[1], dateBirth = data[2], dateResived = data[3], codeRoom = int.Parse(data[4]), describe = data[5], codeCity = int.Parse(data[6]), codeDiagnosis = int.Parse(data[7]) });
                }
            }
            return Patients;
        }
        public static List<Nurse> SELECTNurse()
        {
            List<Nurse> Nurses = new List<Nurse>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Nurses.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    Nurses.Add(new Nurse() { idNurse = data[0], nameNurse = data[1], adress = data[2], codeCity = int.Parse(data[3]), price = double.Parse(data[4]) });
                }
            }
            return Nurses;
        }
        public static List<Shift> SELECTShift()
        {

            List<Shift> Shifts = new List<Shift>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Shifts.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    Shifts.Add(new Shift() { codeShift = int.Parse(data[0]), codeNurse = data[1], codeRoom = int.Parse(data[2]), startTime = data[3], finishTime = data[4], date1 = data[5] });
                }
            }
            return Shifts;
        }
        public static List<Shift> SELECTShift(string id)
        {

            List<Shift> Shifts = new List<Shift>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Shifts.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if(data[1]==id)
                    Shifts.Add(new Shift() { codeShift = int.Parse(data[0]), codeNurse = data[1], codeRoom = int.Parse(data[2]), startTime = data[3], finishTime = data[4], date1 = data[5] });
                }
            }
            return Shifts;
        }
        public static string SELECNurseToShift(int code)
        {
            string idN="000000000";
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Shifts.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    var date = DateTime.Now;
                    var date1 = DateTime.Parse(data[5]);
                    var date2 = DateTime.Parse(data[3]);
                    if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 7)
                    {
                        date = DateTime.Now.AddDays(-1);
                        date2 = date2.AddDays(-1);
                    }

                    var d = (date-date2).TotalHours;
                        if (int.Parse(data[2]) == code && date1.ToShortDateString() == date.ToShortDateString() && ((d<8 && d>0)||d==0||d<-16))
                    {
                        idN= data[1]; 
                    }
                }
            }
            var name="";
            List<Nurse> nu = SELECTNurse();
            foreach (var p in nu)
                if (p.idNurse == idN)
                    name = p.nameNurse;
            return name;
        }
        public static List<Patient> SELECTPatient(int num)
        {

            List<Patient> patients = new List<Patient>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Patients.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (int.Parse(data[4]) == num)
                        patients.Add(new Patient() { idPatient = data[0],namePatient=data[1], codeDiagnosis=int.Parse(data[7]),dateResived=data[3]});
                }
            }
            return patients;
        }
        public static int AddShift(Shift r)
        {

            List<Shift> Shifts = SELECTShift();
            var max = Shifts.Max(p => p.codeShift);
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Shifts.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Shift s = new Shift();
                s.codeShift = max + 1;
                s.codeNurse = r.codeNurse;
                s.codeRoom = r.codeRoom;
                s.startTime = r.startTime;
                s.finishTime = r.finishTime;
                s.date1 = DateTime.Parse(r.date1).ToShortDateString();
                sw.WriteLine(s.ToString());
            }
            return 1;
        }
        public static int AddCity(string name)
        {

            List<City> cities = SELECTCity();
            var max = cities.Max(p => p.codeCity);
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Cities.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                City s = new City();
                s.codeCity = max + 1;
                s.nameCity = name;
                sw.WriteLine(s.ToString());
            }
            return 1;
        }
        public static int AddDepartment(string name)
        {

            List<Department> Departments = SELECTDepartment();
            var max = Departments.Max(p => p.codeDepartment);
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Departments.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Department s = new Department();
                s.codeDepartment = max + 1;
                s.nameDepartment = name;
                sw.WriteLine(s.ToString());
            }
            return 1;
        }
        public static int AddRoom(Room r)
        {

            List<Room> Rooms = SELECTRoom();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Room s = new Room();
                s.misRoom = r.misRoom;
                s.codeDepartment = r.codeDepartment;
                s.amountBeds = r.amountBeds;
                sw.WriteLine(s.ToString());
            }
            return 1;
        }
        public static int AddPatient(Patient p)
        {

            List<Patient> Patients = SELECTPatient();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Patients.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Patient s = new Patient();
                s.idPatient = p.idPatient;
                s.namePatient = p.namePatient;
                s.dateBirth =DateTime.Parse( p.dateBirth).ToShortDateString();
                s.dateResived = DateTime.Parse(p.dateResived).ToShortDateString();
                s.describe = p.describe;
                s.codeCity = p.codeCity;
                s.codeRoom = p.codeRoom;
                        s.codeDiagnosis = p.codeDiagnosis;
                sw.WriteLine(s.ToString());
            }
            return 1;
        }
        public static int AddNurse(Nurse n)
        {

            List<Nurse> Shifts = SELECTNurse();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Nurses.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Nurse s = new Nurse();
                s.idNurse = n.idNurse;
                s.nameNurse = n.nameNurse;
                s.adress = n.adress;
                s.codeCity = n.codeCity;
                s.price = n.price;
                sw.WriteLine(s.ToString());
            }
            return 1;
        }
        public static int AddDiag(int code,string diagnosis,int mis)
        {

            List<Diagnosis> diag = SELECTDiagnosis();
            var max = diag.Max(p => p.codeDiagnosis);
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Diagnosises.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Diagnosis s = new Diagnosis();
                s.codeDiagnosis = max + 1;
                s.diagnosis = diagnosis;
                s.codeDepartment = code;
                s.misDays = mis;
                sw.WriteLine(s.ToString());
            }
            return 1;
        }
        public static int DeleteCity(int code)
        { 
            var i = 0;
            int mis=1;
            List<City> Cities = new List<City>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Cities.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (mis != code || i == 1)
                    {
                        Cities.Add(new City() { codeCity = mis, nameCity = data[1] });
                        mis = mis + 1;
                    }
                    else
                    {
                       // text = sr.ReadLine();
                        i = 1;
                    }
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                Cities.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static void updateCity(List<City> c)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Cities.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                c.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
        }
        public static int DeleteDepartment(int code)
        {
            var i = 0;
            int mis = 1;
            List<Department> dep = new List<Department>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Departments.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (mis != code || i == 1)
                    {
                        dep.Add(new Department() { codeDepartment = mis, nameDepartment = data[1] });
                        mis = mis + 1;
                    }
                    else
                    {
                        // text = sr.ReadLine();
                        i = 1;
                    }
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                dep.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static void updateDepartment(List<Department> c)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Departments.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                c.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
        }
        public static int DeleteRoom(int code)
        {
            List<Room> rooms = new List<Room>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (int.Parse(data[0]) != code )
                    {
                        rooms.Add(new Room() { misRoom = int.Parse(data[0]), codeDepartment = int.Parse(data[1]),amountBeds= int.Parse(data[2]) });
                    }
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                rooms.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static void updateRoom(List<Room> c)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Rooms.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                c.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
        }
        public static int DeleteShift(int code)
        {
            var i = 0;
            int mis = 1;
            List<Shift> shifts = new List<Shift>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Shifts.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (mis != code || i == 1)
                    {
                        shifts.Add(new Shift() { codeShift = mis, codeNurse = data[1], codeRoom = int.Parse(data[2]), startTime = data[3], finishTime = data[4], date1 = data[5] });
                        mis = mis + 1;
                    }
                    else
                        i = 1;
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                shifts.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static void updateShift(List<Shift> c)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Shifts.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                c.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
        }
        public static int DeletePatient(string id)
        {
            List<Patient> patients = new List<Patient>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Patients.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (data[0] != id)
                    { 
                    patients.Add(new Patient() { idPatient = data[0], namePatient = data[1], dateBirth = data[2], dateResived = data[3], codeRoom = int.Parse(data[4]), describe = data[5], codeCity = int.Parse(data[6]) , codeDiagnosis = int.Parse(data[7])});
                    }
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                patients.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static void updatePatient(List<Patient> c)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Patients.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                c.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
        }
        public static int DeleteNurse(string id)
        {
            List<Nurse> nurses = new List<Nurse>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Nurses.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (data[0] != id)
                    {
                        nurses.Add(new Nurse() { idNurse = data[0], nameNurse = data[1], adress = data[2], codeCity = int.Parse(data[3]), price = int.Parse(data[4]) });
                    }
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                nurses.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static void updateNurse(List<Nurse> c)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Nurses.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                c.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
        }
        public static int DeleteDiag(int code)
        {
            var i = 0;
            int mis = 1;
            List<Diagnosis> diag = new List<Diagnosis>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Diagnosises.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    var data = text.Split(", ");
                    if (mis != code || i == 1)
                    {
                        diag.Add(new Diagnosis() { codeDiagnosis = mis, codeDepartment = int.Parse(data[1]),diagnosis=data[2],misDays=int.Parse(data[3]) });
                        mis = mis + 1;
                    }
                    else
                    {
                        // text = sr.ReadLine();
                        i = 1;
                    }
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                diag.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
            return 1;
        }
        public static void updateDiag(List<Diagnosis> c)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Hospital/Diagnosises.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                c.ForEach(p =>
                {
                    sw.WriteLine(p.ToString());
                });
            }
        }
        public static string Convert(string date)
        {
            string dateConvert = DateTime.Parse(date).Year.ToString();
            if (DateTime.Parse(date).Month < 10)
                dateConvert = dateConvert + "-0" + DateTime.Parse(date).Month.ToString();
            else
                dateConvert = dateConvert + "-" + DateTime.Parse(date).Month.ToString();
            if (DateTime.Parse(date).Day < 10)
                dateConvert = dateConvert + "-0" + DateTime.Parse(date).Day.ToString();
            else
                dateConvert = dateConvert + "-" + DateTime.Parse(date).Day.ToString();
            return dateConvert;
        }
    }
}
