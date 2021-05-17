using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Workshop_Management_OOD_W12
{
    class WorkshopModel : IWorkshopModel, IPersistentSerializeStorage
    {
        private static List<Workshop> workshops;
        private static bool hasBeenLoaded = false;
        private string filepath = "workshops.bin";
        public int ItemsCount => workshops.Count;
        public WorkshopModel()
        {
            try {
                if (workshops == null && !hasBeenLoaded)
                {
                    workshops = new List<Workshop>();
                }
                if (!hasBeenLoaded) {
                    LoadData();
                    hasBeenLoaded = true;
                }
            }
            catch(Exception ex) {
                workshops = new List<Workshop>();
                hasBeenLoaded = true;
            }
        }
        public void AddWorkshop(Workshop workshop)
        {
            if (workshops.Contains(workshop))
            {
                throw new Exception("This workshop has similar name, cannot add");
            }
            workshops.Add(workshop);
        }
        public Workshop GetWorkshop(int workshopID)
        {
            foreach(Workshop workshop in workshops)
            {
                if (workshop.ID == workshopID)
                {
                    return workshop;
                }
            }
            throw new Exception("Cannot find the workshop have similar ID");
        }
        public Workshop[] GetWorkshops()
        {
            return workshops.ToArray();
        }
        public void RemoveWorkshop(Workshop workshop)
        {
            if (workshops.Contains(workshop))
            {
                throw new Exception("This workshop is not available in the system");
            }
            workshops.Remove(workshop);
        }
        public void UpdateWorkshop(Workshop workshop)
        {
            throw new NotImplementedException();
        }
        public void LoadData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            string filepath = this.filepath;

            try
            {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
                workshops = (List<Workshop>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        public void SaveData() {
            FileStream fs = null;
            BinaryFormatter bf = null;
            string filepath = this.filepath;

            try
            {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, workshops);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null) 
                {
                    fs.Close();
                }
            }
        }
    }
}
