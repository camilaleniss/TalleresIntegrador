using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.Model
{
    class Parking
    {

        public const int CAPACITY = 100;

        private LinkedList<User> users;
        private LinkedList<Vehicle> currentVehicles;
        private int availableSpace;

        Parking()
        {
            users = new LinkedList<User>();
            //Deberia llamarse al método uploadUsers
            currentVehicles = new LinkedList<Vehicle>();
            availableSpace = CAPACITY;
        }

        void AddUser (int cod, String name)
        {
            User user = new User(cod, name);
            users.AddLast(user);
        }

        void reduceSpace()
        {
            --availableSpace;
        }

        void increaseSpace()
        {
            ++availableSpace;
        }

        public void saveUsers()
        {
            //Aqui deberia ir el método que crea el archivo de texto de los usuarios
        }

        void uploadUsers()
        {
            //Aqui deberia ir el método que carga el archivo de texto
        }

        public void enterVehicle(Boolean belongs, String placa)
        {
            //Método que añade un vehiculo al parqueadero
        }

        public void removeVehicle(String placa)
        {
            //Método que retira un vehiculo del parqueadero
        }

        void removeVehicle(Vehicle vehicle)
        {
            //Método auxiliar que retira un vehiculo del parqueadero
        }

        public String showUsers()
        {
            return "Users";
        }

    }
}
