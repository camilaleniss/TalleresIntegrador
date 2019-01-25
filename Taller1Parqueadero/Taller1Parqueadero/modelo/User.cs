using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.modelo
{
    public class User
    {
        private int cod;
        private String name;

        public User(int cod, String name)
        {
            this.cod = cod;
            this.name = name;
 
        }

        //Getter and setter 
        public string Name { get => name; set => name = value; }

        public int Cod { get => cod; set => cod = value; }



    }
}
