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
    class UserModel : IUserModel, IPersistentSerializeStorage
    {
        private static List<User> users;
        private static bool hasBeenLoaded = false;
        private string filepath = "users.bin";
        public int ItemsCount => users.Count;

        public UserModel()
        {
            try
            {
                if (users == null && !hasBeenLoaded)
                {
                    users = new List<User>();
                }
                if (!hasBeenLoaded)
                {
                    LoadData();
                    hasBeenLoaded = true;
                }
            }
            catch(Exception ex)
            {
                users = new List<User>();
                hasBeenLoaded = true;
            }
        }
        public void AddUser(User user)
        {
            if (users.Contains(user))
            {
                throw new Exception("This user have similar PCN, cannot create");
            }
            users.Add(user);
            users.Sort();
        }
        public User GetUser(string pcn)
        {
            foreach(User user in users)
            {
                if (user.PCN == pcn)
                {
                    return user;
                }
            }
            throw new Exception("Cannot find the user with this pcn");
        }
        public User[] GetUsers()
        {
            return users.ToArray();
        }
        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        public void RemoveUser(User user)
        {
            if (!users.Contains(user))
            {
                throw new Exception("This user does not existed, cannot delete");
            }
            users.Remove(user);
        }
        public void LoadData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
                users = (List<User>)bf.Deserialize(fs);
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        public void SaveData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, users);
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
