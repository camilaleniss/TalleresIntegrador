using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.Model
{
    public class Vehicle
    {

        private Boolean belongsToIcesi;
        private String plate;

        public Vehicle (Boolean belongsIcesi, String plate)
        {
            this.belongsToIcesi = belongsIcesi;
            this.plate = plate;

        }

        //Getter and setter 
        public string Plate { get => plate; set => plate = value; }
        public bool BelongsToIcesi { get => belongsToIcesi; set => belongsToIcesi = value; }

        public override string ToString()
        {
            string belongs = belongsToIcesi ? "pertenece a Icesi" : "no pertenece a Icesi";
            return plate + " , " + belongs;
        }
    }
}
