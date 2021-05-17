using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class InBuildingWorkshop : Workshop
    {
        private string address;
        private string room;

        public string Address { 
            get { return address; }
            set { address = value; }
        }
        public string Room { 
            get { return room; } 
            set { room = value; }
        }
        public InBuildingWorkshop(int id, string title, string description, int maximumCapacity, DateTime createdDate, 
                  Teacher teacher, string address, string room) : base(id, title, description, maximumCapacity, createdDate, teacher)
        {
            this.address = address;
            this.room = room;
        }
        public override string GetInfo()
        {
            string rightInfo = $", Location: {address} {room})";
            string baseInfo = base.GetInfo();
            string newInfo = baseInfo.Remove(baseInfo.Length - 1) + rightInfo;
            newInfo = $"InBuilding{newInfo}";
            return newInfo;
        }
    }
}
