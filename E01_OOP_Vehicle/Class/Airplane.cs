using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_OOP_Vehicle
{
    internal class Airplane : IAir
    {

        #region Properties
        private static int NextId = 1;
        public int Id { get; set; }
        public Enum Make { get; private set; }
        public Enum Model { get; private set; }
        public int Year { get; private set; }
        public string PlaneRegistration { get; private set; }
        

        public EnumAiplaneType AiplaneType { get; private set; }

        public double CurrentAltitude { get; private set; }

        public double MaxAltitude { get; private set; }
        public double inputAltitude { get; private set; }
       

       

        #endregion

        #region Constructors
        public Airplane()
        {
            Id = NextId++;
            CurrentAltitude = 0;
            inputAltitude = 0;
        }
        
        #endregion


        #region Methods
        public void Create()
        {
            #region Brand
            Utility.WriteMessage("Selecione a marca do avião:");
            foreach (var make in Enum.GetValues(typeof(EnumMakeAirPlane)))
            {
                Utility.WriteMessage($"{(int)make} - {make}");
            }
            while (true) 
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumMakeAirPlane opcao))
                {
                    if (Enum.IsDefined(typeof(EnumMakeAirPlane), opcao)) 
                    {
                        Make = opcao; 
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }

            #endregion

            #region Model
            Utility.WriteMessage("\nSelecione a marca do avião:");
            foreach (var make in Enum.GetValues(typeof(EnumModelAirPlane)))
            {
                Utility.WriteMessage($"{(int)make} - {make}");
            }
            while (true) 
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumModelAirPlane opcao))
                {
                    if (Enum.IsDefined(typeof(EnumModelAirPlane), opcao)) 
                    {
                        Make = opcao; 
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }

            #endregion

            #region Year / Registration
            Utility.WriteMessage("\nAno:"); 
            Year = int.Parse(Console.ReadLine());

            Utility.WriteMessage("\nCódigo do registo:");
            PlaneRegistration = Console.ReadLine();

            #endregion

            #region Type
            Utility.WriteMessage("\nSelecione o tipo do avião:");
            foreach (var make in Enum.GetValues(typeof(EnumAiplaneType)))
            {
                Utility.WriteMessage($"{(int)make} - {make}");
            }
            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumAiplaneType opcao))
                {
                    if (Enum.IsDefined(typeof(EnumAiplaneType), opcao))
                    {
                        Make = opcao;
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }

            #endregion

            #region Creating/Speed
            Utility.WriteMessage($"\n{NextId} - Avião criado com sucesso.\n");

            Utility.WriteMessage("\nQual a altitude máxima?");
            MaxAltitude = double.Parse(Console.ReadLine()); // Aqui, diferente do carro, recebi a altitude máxima do console.
            Utility.WriteMessage($"\nQual a altitude de vôo desejada?");
            inputAltitude = double.Parse(Console.ReadLine());

            if (inputAltitude > MaxAltitude)
            {
                Utility.WriteMessage($"\nProibido voar acima de {MaxAltitude} pés. O avião atingirá somente a altitude máxima permitida");
            }
            else
            {
                MaxAltitude = double.Parse(Console.ReadLine());
            }
            
            #endregion

        }

        public void Start()
        {
            Utility.WriteMessage("\nIniciando...");
            Console.ReadKey();
        }
        public void Move()
        {
            Utility.WriteMessage($"\nO avião está movendo .");
            Console.ReadLine();
            
        }

        public void TakeOff()
        {
            Utility.WriteMessage($"\nO avião atingiu a altitude padrão de { MaxAltitude} pés.");
            Console.ReadKey();
        }


        public void Land()
        {
            Utility.WriteMessage($"\nO avião aterrou. A altitude é de {CurrentAltitude}");
            Console.ReadKey();
        }

        public void Stop()
        {
            Utility.WriteMessage($"\nO avião aterrou.");
            Console.ReadKey();
        }

        #endregion

    }
}
