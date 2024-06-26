using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    internal interface IRoad: IVehicle
    {
        #region Propreties
        string CarRegistration { get; }
        EnumColor Color { get; }
        EnumNumberOfDoors  NumberOfDoors {  get; } 
        double CurrentSpeed { get; }
        double MaxSpeed { get; }
        #endregion

        #region Methods
        void Move(double speed);
        void Park();
        void Honk();
        #endregion
    }
}
