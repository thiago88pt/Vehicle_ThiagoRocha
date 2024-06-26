using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    #region EnumMakes
    public enum EnumMakeCar
    {
        Mazda = 1, 
        Lexus = 2
    }

    public enum EnumMakeAirPlane
    {
        Boeing = 1,
        Embraer = 2
    }

    public enum EnumMakeSubmarine
    {
        Arma = 1,
        NavalSub = 2
    }
    #endregion

    #region EnumModels
    public enum EnumModelCar
    {
        Sedan = 1 ,
        SUV = 2,
        SpaceWagon = 3
    }

    public enum EnumModelAirPlane
    {
        F35 = 1,
        BlackHocket = 2,
        Concord = 3
    }

    public enum EnumModelSubmarine
    {
        Nemo = 1,
        Dolly = 2,
        Tutubarao = 3
    }

    #endregion

    #region EnumTypes
    public enum EnumAiplaneType
    {
        Jet = 1,
        Bomber = 2,
        Commercial = 3,
        Private = 4,
        Rescue = 5
    }

    public enum EnumSubmarineType
    {
        Nuclear = 1,
        Search = 2,
        Spy = 3
    }

    #endregion


    public enum EnumColor
    {
        Red = 1,
        Blue = 2,
        Green = 3,
        Yellow = 4,
        Black = 5
    }

    public enum EnumNumberOfDoors
    {
        Duas = 2,
        Quatro  = 4 ,
        Cinco = 5
    }


}
