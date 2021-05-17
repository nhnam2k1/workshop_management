using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IPersistentSerializeStorage
    {
        int ItemsCount { get; }
        void LoadData();
        void SaveData();
    }
}
