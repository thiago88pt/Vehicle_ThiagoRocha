using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_OOP_Vehicle
{
    internal interface IVehicle
    {
        #region Propreties
        int Id { get; }
        int Year { get; }
        Enum Make { get; }
        Enum Model { get; }
        #endregion

        #region Methods  // não poderíamos criar uma classe Vehicle e implementar os 4 métodos? Já que são comuns a todos.
        void Create();
        void Start();
        void Move();
        void Stop();
        #endregion

    }
}
