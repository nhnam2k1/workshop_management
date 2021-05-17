using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class OnlineWorkshop : Workshop
    {
        private string url;
        public string URL { 
            get { return url; }
            set { url = value; }
        }
        public OnlineWorkshop(int id, string title, string description, int maximumCapacity, DateTime createdDate, Teacher teacher, string url) :
            base(id, title, description, maximumCapacity, createdDate, teacher)
        {
            this.url = url;
        }
        public override string GetInfo()
        {
            string rightInfo = $", URL: {url})";
            string baseInfo = base.GetInfo();
            string newInfo = baseInfo.Remove(baseInfo.Length - 1) + rightInfo;
            newInfo = $"Online{newInfo}";
            return newInfo;
        }
    }
}
