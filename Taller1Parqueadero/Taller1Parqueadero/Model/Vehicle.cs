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
        private String placa;

        public Vehicle (Boolean belongsIcesi, String placa)
        {
            this.belongsToIcesi = belongsIcesi;
            this.placa = placa;

        }

        //Getter and setter 
        public string Placa { get => placa; set => placa = value; }
        public bool BelongsToIcesi { get => belongsToIcesi; set => belongsToIcesi = value; }
    }
}
