using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    class Employees :IEquatable <Employees>
    {
        public int Employeeid {  get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Employees(int id, string name, string department)
        {
            Employeeid = id;
            Name = name;
            Department = department;
        }

        public bool Equals(Employees other)
        {
            if (other is null) return false;
            return  this.Name.Equals(other.Name) ;
        }


        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
            //return HashCode.Combine(this.Employeeid, this.Name);
        }

    }


}
