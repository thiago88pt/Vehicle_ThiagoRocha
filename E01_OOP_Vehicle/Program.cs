using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_OOP_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Menu
            string[] opcoes = new string[]
            {
                "1. Carro",
                "2. Avião",
                "3. Submarino",
                "4. Sair\n\n"
            };

            while (true)
            {
                Utility.WriteMessage("Selecione o tipo de veículo que deseja criar:");
                foreach (string opcao in opcoes)
                {
                    Utility.WriteMessage($"{opcao}");
                }

                string choice = Console.ReadLine();

                IVehicle vehicle = null;

                switch (choice)
                {
                    case "1":
                        vehicle = new Car();
                        break;
                    case "2":
                        vehicle = new Airplane();
                        break;
                    case "3":
                        vehicle = new Submarine();
                        break;
                    case "4":
                        return;
                    default:
                        Utility.WriteMessage("Opção inválida, por favor, tente novamente.");
                        continue;
                }

                #endregion

                #region Methods
                vehicle.Create();
                vehicle.Start();

                if (vehicle is Car)
                {
                    Car car = (Car)vehicle;
                    car.Move(0);
                    car.Move();
                    car.Honk();
                    car.Park();
                }
                else if (vehicle is Airplane)

                {
                    Airplane airplane = (Airplane)vehicle;
                    airplane.TakeOff();
                    airplane.Land();

                }
                else if (vehicle is Submarine)
                {
                    Submarine submarine = (Submarine)vehicle;
                    submarine.Dive();
                    submarine.Emerge();
                }

                vehicle.Stop();


                #endregion

                Utility.TerminateConsole();
            }
        }
    }
}
