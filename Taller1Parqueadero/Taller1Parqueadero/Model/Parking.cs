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

        public void AddUser(string cod, string name)
        {
            User user = new User(cod, name);
            Users.AddLast(user);
            SaveUser(user);
        }

        public void ReduceSpace()
        {
            --availableSpace;
        }

        public void IncreaseSpace()
        {
            ++availableSpace;
        }

        public void SaveUser(User user)
        {
            try
            {
                StreamWriter sw = new StreamWriter(USERS_LOCATION, true);
                sw.WriteLine(user.Cod + "&" + user.Name);

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

        public bool EnterVehicle(bool belongs, string plate)
        {
            bool success = false;
            if (availableSpace > 0)
            {
                Vehicle vehicle = new Vehicle(belongs, plate);
                vehiclesMap[plate] = vehicle;
                CurrentVehicles.AddLast(vehicle);
                success = true;
                IncreaseSpace();
            }

            return success;
        }

        public void RemoveVehicle(string plate)
        {
            Vehicle vehicle = vehiclesMap[plate];
            if (vehicle != null) { RemoveVehicle(vehicle); }
        }

        void RemoveVehicle(Vehicle vehicle)
        {
            vehiclesMap.Remove(vehicle.Plate);
            CurrentVehicles.Remove(vehicle);
            ReduceSpace();
        }

        public String showUsers()
        {
            return "Users";
        }

    }
}
