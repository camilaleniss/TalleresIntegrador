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
        public const string VEHICLES_LOCATION = "..\\..\\vehicles.txt";

        public LinkedList<User> Users { get; private set; }
        public LinkedList<Vehicle> CurrentVehicles { get; private set; }
        public int AvailableSpace { get; private set; }

        public Parking()
        {
            Users = new LinkedList<User>();
            CurrentVehicles = new LinkedList<Vehicle>();
            AvailableSpace = CAPACITY;
            LoadUsers();
            LoadVehicles();
            
        }

        public void AddUser(string cod, string name)
        {
            User user = new User(cod, name);
            Users.AddLast(user);
            SaveUser(user);
        }

        public void ReduceSpace()
        {
            --AvailableSpace;
        }

        public void IncreaseSpace()
        {
            ++AvailableSpace;
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

        public void SaveVehicles()
        {
            try
            {
                StreamWriter sw = new StreamWriter(VEHICLES_LOCATION, false);
                foreach(Vehicle vehicle in CurrentVehicles)
                {
                    sw.WriteLine(vehicle.Owner + "&" + vehicle.Plate);
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

        public void LoadVehicles()
        {
            if (File.Exists(VEHICLES_LOCATION))
            {
                string line;
                try
                {
                    StreamReader sr = new StreamReader(VEHICLES_LOCATION);

                    line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] information = line.Split('&');
                        EnterVehicle(new Vehicle(information[0], information[1]));
                    }

                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        public bool EnterVehicle(User owner, string plate)
        {
            bool success = false;
            if (AvailableSpace > 0)
            {
                string ownerString = Vehicle.NO_ICESI;
                if (owner != null)
                {
                    ownerString = owner.ToString() ;
                }
                Vehicle vehicle = new Vehicle(ownerString, plate);
                EnterVehicle(vehicle);
                success = true;
            }

            return success;
        }

        public void EnterVehicle(Vehicle vehicle)
        {
            CurrentVehicles.AddLast(vehicle);           
            ReduceSpace();
            SaveVehicles();
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            CurrentVehicles.Remove(vehicle);
            IncreaseSpace();
        }

        public String showUsers()
        {
            String users = "Codigo  / Nombre"+"\n";
            if (File.Exists(USERS_LOCATION))
            {
                try
                {
                    String line;
                    StreamReader sr = new StreamReader(USERS_LOCATION);
                    line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] information = line.Split('&');
                        users += (information[0] + " / " + information[1]+"\n");
                    }

                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            return users;
        }

    }
}
