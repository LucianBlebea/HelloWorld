using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    class Computer : Product
    {
        private string serialNumber;
        private int storage;

        //property that returns computer name, it is set as readonly for now
        public string ComputerName
        {
            get
            {
                return ProductName;
            }
        }

        //property that returns computer serial number, it is set as readonly for now
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
        }

        //property that returns computer storage, it is set as readonly for now
        public int Storage
        {
            get
            {
                return storage;
            }
        }

    }
}
