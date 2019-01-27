using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.Model
{
    public class User
    {
        private string cod;
        private string name;

        public User(string cod, String name)
        {
            this.cod = cod;
            this.name = name;
 
        }

        //Getter and setter 
        public string Name { get => name; set => name = value; }

        public string Cod { get => cod; set => cod = value; }

        public override string ToString()
        {
            return cod + " - " + name;
        }

    }
}
