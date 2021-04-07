using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Hospital
{
    public class Model
    {
    }
    public class City
    {
        public int codeCity { get; set; }
        public string nameCity { get; set; }
        public override string ToString()
        {
            return $"{codeCity}, {nameCity}";
        }
    }
    public class Department
    {
        public int codeDepartment { get; set; }
        public string nameDepartment { get; set; }
        public override string ToString()
        {
            return $"{codeDepartment}, {nameDepartment}";
        }
    }
    public class Room
    {
        public int misRoom { get; set; }
        public int codeDepartment { get; set; }
        public int amountBeds { get; set; }
        public override string ToString()
        {
            return $"{misRoom}, {codeDepartment}, {amountBeds}";
        }
    }
    public class Patient
    {
        public string idPatient { get; set; }
        public string namePatient { get; set; }
        public string dateBirth { get; set; }
        public string dateResived { get; set; }
        public int codeRoom { get; set; }
        public string describe { get; set; }
        public int codeCity { get; set; }
        public int codeDiagnosis { get; set; }

        public override string ToString()
        {
            return $"{idPatient}, {namePatient}, {dateBirth}, {dateResived}, {codeRoom}, {describe}, {codeCity}, {codeDiagnosis}";
        }
    }
    public class Nurse
    {
        public string idNurse { get; set; }
        public string nameNurse { get; set; }
        public string adress { get; set; }
        public int codeCity { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return $"{idNurse}, {nameNurse}, {adress}, {codeCity}, {price} ";
        }
    }
    public class Shift
    {
        public int codeShift { get; set; }
        public string codeNurse { get; set; }
        public int codeRoom { get; set; }
        public string startTime { get; set; }
        public string finishTime { get; set; }
        public string date1 { get; set; }

        public override string ToString()
        {
            return $"{codeShift}, {codeNurse}, {codeRoom}, {startTime}, {finishTime}, {date1} ";
        }
    }
    public class Diagnosis
    {
        public int codeDiagnosis { get; set; }
        public int codeDepartment { get; set; }
        public string diagnosis { get; set; }
        public int misDays { get; set; }

        public override string ToString()
        {
            return $"{codeDiagnosis}, {codeDepartment}, {diagnosis}, {misDays} ";
        }
    }
    //public static class DataBase
    //{
    //    public static SqlConnection con = new SqlConnection("data source=localhost; initial catalog=Hospital;persist security info=true; Integrated Security=SSPI;MultipleActiveResultsSets=true");
    //    public static SqlDataReader reader;
    //    public static SqlDataAdapter adapter;
    //    public static SqlCommand cmd = new SqlCommand("");
    //    //public static SqlCommand selectCityCommand = new SqlCommand("select * from City", con);
    //    //public static SqlCommand selectDepartmentCommand = new SqlCommand("select * from Department", con);
    //    //public static SqlCommand selectRoomCommand = new SqlCommand("select * from Room", con);
    //    //public static SqlCommand selectPatientCommand = new SqlCommand("select * from Patient", con);
    //    //public static SqlCommand selectNurseCommand = new SqlCommand("select * from Nurse", con);
    //    //public static SqlCommand selectShiftCommand = new SqlCommand("select * from Shift", con);

    //    public static List<City> SELECTCity(string query)
    //    {
    //        cmd = new SqlCommand(query, con);
    //        List<City> Cities = new List<City>();
    //        con.Open();
    //        using (reader = cmd.ExecuteReader())
    //        {

    //            while (reader.Read())
    //            {
    //                City c = new City();
    //                {
    //                    c.codeCity = reader.GetInt32(0);
    //                    c.nameCity = reader.GetValue(1).Tostring();
    //                };

    //                Cities.Add(c);
    //            }
    //        }
    //        con.Close();
    //        return Cities;
    //    }
    //    public static List<Department> SELECTDepartment(string query)
    //    {
    //        cmd = new SqlCommand(query, con);
    //        List<Department> Departments = new List<Department>();
    //        con.Open();
    //        using (reader = cmd.ExecuteReader())
    //        {

    //            while (reader.Read())
    //            {
    //                Department d = new Department();
    //                {
    //                    d.codeDepartment = reader.GetInt32(0);
    //                    d.nameDepartment = reader.GetValue(1).Tostring();
    //                };

    //                Departments.Add(d);
    //            }
    //        }
    //        con.Close();
    //        return Departments;
    //    }
    //    public static List<Room> SELECTRoom(string query)
    //    {
    //        cmd = new SqlCommand(query, con);
    //        List<Room> Rooms = new List<Room>();
    //        con.Open();
    //        using (reader = cmd.ExecuteReader())
    //        {

    //            while (reader.Read())
    //            {
    //                Room r = new Room();
    //                {
    //                    r.misRoom = reader.GetInt32(0);
    //                    r.codeDepartment = reader.GetInt32(1);
    //                    r.amountBeds = reader.GetInt32(2);
    //                };
    //                Rooms.Add(r);
    //            }
    //        }
    //        con.Close();
    //        return Rooms;
    //    }
    //    public static List<Patient> SELECTPatient(string query)
    //    {
    //        cmd = new SqlCommand(query, con);
    //        List<Patient> Patients = new List<Patient>();
    //        con.Open();
    //        using (reader = cmd.ExecuteReader())
    //        {

    //            while (reader.Read())
    //            {
    //                Patient p = new Patient();
    //                {
    //                    p.idPatient = reader.GetValue(0).Tostring();
    //                    p.namePatient = reader.GetValue(1).Tostring();
    //                    p.dateBirth = reader.GetDateTime(2);
    //                    p.dateResived = reader.GetDateTime(3);
    //                    p.codeRoom = reader.GetInt32(4);
    //                    p.describe = reader.GetValue(5).Tostring();
    //                    p.codeCity = reader.GetInt32(6);
    //                };
    //                Patients.Add(p);
    //            }
    //        }
    //        con.Close();
    //        return Patients;
    //    }
    //    public static List<Nurse> SELECTNurse(string query)
    //    {
    //        cmd = new SqlCommand(query, con);
    //        List<Nurse> Nurses = new List<Nurse>();
    //        con.Open();
    //        using (reader = cmd.ExecuteReader())
    //        {

    //            while (reader.Read())
    //            {
    //                Nurse n = new Nurse();
    //                {
    //                    n.idNurse = reader.GetValue(0).Tostring();
    //                    n.nameNurse = reader.GetValue(1).Tostring();
    //                    n.adress = reader.GetValue(2).Tostring();
    //                    n.codeCity = reader.GetInt32(3);
    //                    n.price = reader.GetFloat(4);
    //                };
    //                Nurses.Add(n);
    //            }
    //        }
    //        con.Close();
    //        return Nurses;
    //    }
    //    public static List<Shift> SELECTShift(string query)
    //    {
    //        cmd = new SqlCommand(query, con);
    //        List<Shift> Shifts = new List<Shift>();
    //        con.Open();
    //        using (reader = cmd.ExecuteReader())
    //        {

    //            while (reader.Read())
    //            {
    //                Shift sh = new Shift();
    //                {
    //                    sh.codeShift = reader.GetInt32(0).Tostring();
    //                    sh.codeNurse = reader.GetValue(1).Tostring();
    //                    sh.codeRoom = reader.GetInt32(2).Tostring();
    //                    sh.startTime = reader.GetDateTime(3);
    //                    sh.finishTime = reader.GetDateTime(4);
    //                };
    //                Shifts.Add(sh);
    //            }
    //        }
    //        con.Close();
    //        return Shifts;
    //    }
    //    public static void PrintCities(List<City> Cities)
    //    {
    //        foreach (var item in Cities)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //    }
    //    public static void PrintDepartments(List<City> Departments)
    //    {
    //        foreach (var item in Departments)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //    }
    //    public static void PrintRooms(List<City> Rooms)
    //    {
    //        foreach (var item in Rooms)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //    }
    //    public static void PrintPatients(List<City> Patients)
    //    {
    //        foreach (var item in Patients)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //    }
    //    public static void PrintNurses(List<City> Nurses)
    //    {
    //        foreach (var item in Nurses)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //    }
    //    public static void PrintShifts(List<City> Shifts)
    //    {
    //        foreach (var item in Shifts)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //    }
    //    public static void DeleteCity(int code)
    //    {
    //        cmd = new SqlCommand($"DELETE from Cities  where codeCity={code}" , con);
    //        con.Open();
    //        adapter.DeleteCommand = cmd;
    //        adapter.DeleteCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void DeleteDepartment(int code)
    //    {
    //        cmd = new SqlCommand($"DELETE from Department  where codeDepartment={code}", con);
    //        con.Open();
    //        adapter.DeleteCommand = cmd;
    //        adapter.DeleteCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void DeletePatient(string id)
    //    {
    //        cmd = new SqlCommand($"DELETE from Patient  where idPatient={id}", con);
    //        con.Open();
    //        adapter.DeleteCommand = cmd;
    //        adapter.DeleteCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void DeleteRoom(int code)
    //    {
    //        cmd = new SqlCommand($"DELETE from Room  where misRoom={code}", con);
    //        con.Open();
    //        adapter.DeleteCommand = cmd;
    //        adapter.DeleteCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void DeleteNurse(int id)
    //    {
    //        cmd = new SqlCommand($"DELETE from Nurse  where idNurse={id}", con);
    //        con.Open();
    //        adapter.DeleteCommand = cmd;
    //        adapter.DeleteCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void DeleteShift(int code)
    //    {
    //        cmd = new SqlCommand($"DELETE from Shifts  where codeShift={code}", con);
    //        con.Open();
    //        adapter.DeleteCommand = cmd;
    //        adapter.DeleteCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void UpdateCity(int code)
    //    {
    //        cmd = new SqlCommand($"UPDATE Cities SET nameCity=ירושלים where codeCity={code}", con);
    //        con.Open();
    //        adapter.UpdateCommand = cmd;
    //        adapter.UpdateCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void UpdateDepartment(int code)
    //    {
    //        cmd = new SqlCommand($"UPDATE Department SET nameDepartment=מיוןא where codeDepartment={code}", con);
    //        con.Open();
    //        adapter.UpdateCommand = cmd;
    //        adapter.UpdateCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void UpdatePatient(string id)
    //    {
    //        cmd = new SqlCommand($"UPDATE Patient SET namePatient=רחלי where idPatient={id}", con);
    //        con.Open();
    //        adapter.UpdateCommand = cmd;
    //        adapter.UpdateCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void UpdateRoom(int code)
    //    {
    //        cmd =  new SqlCommand($"UPDATE Room SET amount=3 where misRoom={code}", con);
    //        con.Open();
    //        adapter.UpdateCommand = cmd;
    //        adapter.UpdateCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void UpdateNurse(int id)
    //    {
    //        cmd =  new SqlCommand($"UPDATE Nurse SET nameNurse=יפוש where idNurse={id}", con);
    //        con.Open();
    //        adapter.UpdateCommand = cmd;
    //        adapter.UpdateCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    public static void UpdateShift(int code)
    //    {
    //        cmd =  new SqlCommand($"UPDATE Shifts SET codeNurse=1 where codeShift={code}", con);
    //        con.Open();
    //        adapter.UpdateCommand = cmd;
    //        adapter.UpdateCommand.ExecuteNonQuery();
    //        con.Close();
    //    }
    //}
}