using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.modelo
{
    public class Vehicle
    {

        private Boolean belongsIcesi;
        private String placa;

        public Vehicle (Boolean belongsIcesi, String placa)
        {
            this.belongsIcesi = belongsIcesi;
            this.placa = placa;

        }

        //Getter and setter 
        public string Placa { get => placa; set => placa = value; }
        public bool BelongsIcesi { get => belongsIcesi; set => belongsIcesi = value; }
    }
}
