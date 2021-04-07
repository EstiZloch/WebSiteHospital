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
    public class RoomsController : ControllerBase
    {
        [HttpPost("{AddRoom}")]
        public string AddRoom([FromBody] Room r)
        {
            List<Room> room = data.SELECTRoom();
            room = room.Where(c => c.misRoom == r.misRoom).ToList();
            var text = JsonConvert.SerializeObject(room);
            if (text == "[]")
            {
                @data.AddRoom(r);
                text = "";
            }
            else
            {
                text = " חדר זה כבר קיים";
            }
            return text;
        }
        [HttpGet("")]
        public int GetNext()
        {
            var room = data.SELECTRoom();
            var max = room.Max(p => p.misRoom);
            return max+1;
        }
        [HttpGet("{mis}")]
        public string NameDepartment(int mis)
        {
            var num = data.SELECTRoom(mis);
            string name= data.SELECTDepartment(num);
            return name;
        }
        [HttpGet("{mis}/{status}")]
        public string FitRooms(int mis,string status)
        {
            List<Room> roomFit = new List<Room>();
            List<Room> room = data.SELECTRoomInDepartment(mis);
            foreach(var r in room)
            {
                if (data.Patients(r.misRoom) == 1)
                    roomFit.Add(new Room() { misRoom = r.misRoom, codeDepartment = r.codeDepartment, amountBeds=r.amountBeds });
              
            }
            var text = JsonConvert.SerializeObject(roomFit);
            return text;
        }
        [HttpPost("DeleteRoom")]
        public int DeleteRoom([FromBody] int code)
        {
            data.DeleteRoom(code);
            var rooms = data.SELECTRoom();
            return rooms.Count;
        }
        [HttpPost("UpdateRoom")]
        public void UpdateRoom([FromBody] Room c)
        {
            List<Room> rooms = data.SELECTRoom();
            rooms.First(p => p.misRoom == c.misRoom).amountBeds = c.amountBeds;
            rooms.First(p => p.misRoom == c.misRoom).codeDepartment = c.codeDepartment;
            data.updateRoom(rooms);
        }
    }
}
