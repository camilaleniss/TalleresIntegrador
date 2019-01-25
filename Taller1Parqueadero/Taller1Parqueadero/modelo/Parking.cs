using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.modelo
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

        }

        public void removeVehicle(String placa)
        {

        }

        void removeVehicle(Vehicle vehicle)
        {

        }

        public String showUsers()
        {
            return "Users";
        }

    }
}
