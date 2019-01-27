using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.Model
{
    public class Vehicle
    {

        public const string NO_ICESI = "";

        private string owner;
        private string plate;

        public Vehicle (string owner, string plate)
        {
            this.owner = owner;
            this.plate = plate;

        }

        //Getter and setter 
        public string Plate { get => plate; set => plate = value; }
        public string Owner { get => owner; set => owner = value; }

        public override string ToString()
        {
            string belongs = owner != NO_ICESI ? "pertenece a "+owner : "no pertenece a Icesi";
            return plate + ", " + belongs;
        }
    }
}
