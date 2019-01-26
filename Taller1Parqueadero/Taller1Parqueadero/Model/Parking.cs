using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Parqueadero.Model
{
    class Parking
    {

        public const int CAPACITY = 100;
        public const string USERS_LOCATION = "..\\..\\users.txt";

        public LinkedList<User> Users { get; private set; }
        public LinkedList<Vehicle> CurrentVehicles { get; private set; }
        private Dictionary<string, Vehicle> vehiclesMap;
        private int availableSpace;

        public Parking()
        {
            Users = new LinkedList<User>();
            vehiclesMap = new Dictionary<string, Vehicle>();
            LoadUsers();
            CurrentVehicles = new LinkedList<Vehicle>();
            availableSpace = CAPACITY;
        }

        void AddUser(string cod, string name)
        {
            User user = new User(cod, name);
            Users.AddLast(user);
        }

        void ReduceSpace()
        {
            --availableSpace;
        }

        void IncreaseSpace()
        {
            ++availableSpace;
        }

        public void SaveUsers()
        {
            try
            {
                StreamWriter sw = new StreamWriter(USERS_LOCATION, true);

                foreach (User user in Users)
                {
                    sw.WriteLine(user.ToString());
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void LoadUsers()
        {
            if (File.Exists(USERS_LOCATION))
            {
                string line;
                try
                {
                    StreamReader sr = new StreamReader(USERS_LOCATION);

                    line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] information = line.Split('&');
                        AddUser(information[0], information[1]);
                    }

                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        public void EnterVehicle(Boolean belongs, String placa)
        {
            //Método que añade un vehiculo al parqueadero
        }

        public void RemoveVehicle(String plate)
        {
            Vehicle vehicle = vehiclesMap[plate];
            if (vehicle != null) { RemoveVehicle(vehicle); }
        }

        void RemoveVehicle(Vehicle vehicle)
        {
            //Método auxiliar que retira un vehiculo del parqueadero
        }

        public String showUsers()
        {
            return "Users";
        }

    }
}
