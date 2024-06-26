using E01_OOP_Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_OOP_Vehicle
{
    
    internal class Car : IRoad
    {

        #region Propreties
       private static int NextId = 1;
       
       public int Id { get; private set; }
       public Enum Make { get; private set; }
       public Enum Model { get; private set; }
       public int Year { get; private set; }
       public string CarRegistration { get; private set; }
       public EnumColor Color {  get; private set; }
       public EnumNumberOfDoors NumberOfDoors { get; private set; }
       public double CurrentSpeed { get; private set; }
       public double MaxSpeed { get; private set; }

        #endregion

        #region Constructor
        internal Car()
        {
            Id = NextId++;
            CurrentSpeed = 50;
            MaxSpeed = 130;


        }

        #endregion


        #region Methods
        public void Create()
        {
            #region Brand
            Utility.WriteMessage("\nSelecione a marca do carro:");
            foreach (EnumMakeCar make in Enum.GetValues(typeof(EnumMakeCar))) // entendi que o typeof recebe o tipo da Enum e faz a verificação com o GetValues
            {
                Utility.WriteMessage($"{(int)make} - {make}"); // lista os valores da Enum
            }

            while (true) // pensei em criar a verificação em uma utility mas teria que criar uma para cada ?
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumMakeCar opcao))
                {
                    if (Enum.IsDefined(typeof(EnumMakeCar), opcao)) // IsDefined Verifica se o valor está definido na Enum
                    {
                        Make = opcao; // atribui o valor selecionado
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }

            #endregion

            #region Model
            Utility.WriteMessage("\nSelecione a modelo:");
            foreach (EnumModelCar model in Enum.GetValues(typeof(EnumModelCar)))
            {
                Utility.WriteMessage($"{(int)model} - {model}");
            }
            while (true) // pensei em criar a verificação em uma utility mas teria que criar uma para cada ?
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumModelCar opcao))
                {
                    if (Enum.IsDefined(typeof(EnumModelCar), opcao)) // IsDefined Verifica se o valor está definido na Enum
                    {
                        Make = opcao; // atribui o valor selecionado
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }

            #endregion

            #region Year / Registration
            Utility.WriteMessage("\nAno:"); // o ano ainda precisa ser verificado (V2)
            Year = int.Parse(Console.ReadLine());

            Utility.WriteMessage("\nMatrícula:");
            CarRegistration = Console.ReadLine();

            #endregion

            #region Color
            Utility.WriteMessage("\nCor:");
            foreach (var color in Enum.GetValues(typeof(EnumColor)))
            {
                Utility.WriteMessage($"{(int)color} - {color}");
            }
            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumColor opcao))
                {
                    if (Enum.IsDefined(typeof(EnumColor), opcao))
                    {
                        Make = opcao; // atribui o valor selecionado
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }

            #endregion

            #region Number of doors
            Utility.WriteMessage("\nNúmero de portas:");
            foreach (var doors in Enum.GetValues(typeof(EnumNumberOfDoors)))
            {
                Utility.WriteMessage($"{(int)doors} - {doors}");
            }
            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumNumberOfDoors opcao))
                {
                    if (Enum.IsDefined(typeof(EnumNumberOfDoors), opcao))
                    {
                        Make = opcao; // atribui o valor selecionado
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }

            #endregion

            #region Creating/Speed
            Utility.WriteMessage($"\n{NextId} - Veículo criado com sucesso.\n");

            #endregion

        }

        #endregion

        #region Actions
        public void Start()
        {
            Utility.WriteMessage("\nIniciando o carro...");
            Console.ReadKey();
        }

        public void Move()
        {
            Utility.WriteMessage($"\nO carro está se movendo a {CurrentSpeed} km/h.");
            Console.ReadKey();
        }
        public void Move(double speed)
        {
            Utility.WriteMessage($"Qual velocidade deseja mover o veículo?");
            speed = double.Parse(Console.ReadLine());
            if (speed <= MaxSpeed)
            {
                CurrentSpeed = speed;
                Utility.WriteMessage($"\nCarro se movendo a {speed} km/h.");
            }
            else
            {
                Utility.WriteMessage($"\nVelocidade excedeu o limite máximo de {MaxSpeed} km/h.");
            }
        }

       

        public void Honk()
        {
            Utility.WriteMessage("\nO carro está buzinando....");
            Console.ReadKey();
        }

        public void Park()
        {
            CurrentSpeed = 0;
            Utility.WriteMessage($"\nVelocidade atual {CurrentSpeed} km/h. O carro está estacionando....");
            Console.ReadKey();
        }

        public void Stop()
        {
            Utility.WriteMessage($"\nO carro parou. Sua velocidade é de {CurrentSpeed} km/h.");
            Console.ReadKey();
        }
        #endregion
    }
}


