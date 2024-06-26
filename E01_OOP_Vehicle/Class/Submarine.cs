using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    internal class Submarine : ISubmarine
    {
        #region Properties
        private static int NextId = 1;
        public int Id { get; private set; }
        public Enum Make { get; private set; }
        public Enum Model { get; private set; }
        public int Year { get; set; }
        public string PennantNumber { get; set; }
        public EnumSubmarineType SubmarineType { get; set; }
        public double CurrentDepth { get; set; }
        public double MaxDepth { get; set; }
       

       
        #endregion

        #region Constructor
        public Submarine()
        {
            Id = NextId++;
            CurrentDepth = 0;
        }
        #endregion

        #region Methods
        public void Create()
        {
            #region Brand
            Utility.WriteMessage("\nSelecione a marca do submarino:");
            foreach (EnumMakeSubmarine make in Enum.GetValues(typeof(EnumMakeSubmarine)))
            {
                Utility.WriteMessage($"{(int)make} - {make}");
            }

            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumMakeSubmarine opcao))
                {
                    if (Enum.IsDefined(typeof(EnumMakeSubmarine), opcao))
                    {
                        Make = opcao;
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }
            #endregion

            #region Model
            Utility.WriteMessage("\nSelecione o modelo:");
            foreach (EnumModelSubmarine model in Enum.GetValues(typeof(EnumModelSubmarine)))
            {
                Utility.WriteMessage($"{(int)model} - {model}");
            }

            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumModelSubmarine opcao))
                {
                    if (Enum.IsDefined(typeof(EnumModelSubmarine), opcao))
                    {
                        Model = opcao;
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }
            #endregion

            #region Type
            Utility.WriteMessage("\nSelecione o tipo:");
            foreach (EnumSubmarineType type in Enum.GetValues(typeof(EnumSubmarineType)))
            {
                Utility.WriteMessage($"{(int)type} - {type}");
            }

            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out EnumSubmarineType opcao))
                {
                    if (Enum.IsDefined(typeof(EnumSubmarineType), opcao))
                    {
                        SubmarineType = opcao;
                        break;
                    }
                }

                Utility.WriteMessage("Opção inválida.");
            }
            #endregion

            #region Year / Registration
            Utility.WriteMessage("\nAno:");
            Year = int.Parse(Console.ReadLine());

            Utility.WriteMessage("\nNúmero de amura (número de casco):");
            PennantNumber = Console.ReadLine();
            #endregion

            #region Creating/Depth
            Utility.WriteMessage($"\nSubmarino {NextId} - Veículo criado com sucesso.\n");

            Utility.WriteMessage("\nQual a profundidade máxima?");
            MaxDepth = double.Parse(Console.ReadLine());

            #endregion
        }
        #endregion

        #region Actions
        public void Start()
        {
            Utility.WriteMessage("\nIniciando...");
            Console.ReadKey();
        }

        public void Move()
        {
            Utility.WriteMessage($"\nO submarino está se movendo.");
            Console.ReadLine();
        }


        public void Dive()
        {
            Utility.WriteMessage($"\nSua profundidade atual é de {CurrentDepth} pés. A qual profundidade deseja mergulhar?");
            string speedUser = Console.ReadLine();
            if (double.TryParse(speedUser, out double desiredDepth))
            {
                if (desiredDepth <= MaxDepth)
                {
                    CurrentDepth = desiredDepth;
                    Utility.WriteMessage($"\nSubmergindo... Profundidade mudando de {CurrentDepth} pés para {desiredDepth} pés.");
                }
                else
                {
                    Utility.WriteMessage($"\nA profundidade máxima permitida é de {MaxDepth} pés. Atualizando para a profundidade máxima possível.");
                }

            }
        }

        public void Emerge()
        {
            Utility.WriteMessage($"\nO submarino está superfície. Sua profundidade atual é de {CurrentDepth}");
            Console.ReadKey();
        }
        public void Stop()
        {
            Utility.WriteMessage($"\nO submarino parou. Sua profundidade é de {CurrentDepth} pés.");
            Console.ReadKey();
        }


        #endregion
    }
}