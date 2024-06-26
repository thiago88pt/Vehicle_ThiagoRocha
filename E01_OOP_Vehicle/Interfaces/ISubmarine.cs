using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    internal interface ISubmarine : IVehicle
    {
        #region Propreties
        string PennantNumber { get; }
        EnumSubmarineType SubmarineType { get; }
        double CurrentDepth { get; }
        double MaxDepth { get; }
        #endregion

        #region Methods
        void Dive();
        void Emerge();
        #endregion
    }
}
