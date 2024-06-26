using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    internal interface IAir : IVehicle
    {
        #region Propreties
        string PlaneRegistration { get; }
        EnumAiplaneType AiplaneType { get; }
        double CurrentAltitude { get; }
        double MaxAltitude { get; }

        #endregion

        #region Methods
        void TakeOff();
        void Land();
    }
        #endregion
}
