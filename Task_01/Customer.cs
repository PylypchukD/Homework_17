using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal struct Customer
    {
        private string name;
        private string model;
        private string phone;
        public Customer(string name, string model, string phone)
        {
            this.name = name;
            this.model = model;
            this.phone = phone;
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return $"{name} {model} {phone}";
        }
    }
}
