using System;
using Autodesk.Revit.DB;
using HbToolbar.Compatibility;

namespace HbToolbar.Common
{
    public static class UnitConversion
    {


        /// <summary>
        /// Converts the input value into Revit internal units - decimal feet.
        /// </summary>
        public static double ToDecimalFeet(this double value)
        {
            if (RevitVersionInformation.RevitVersionNumber < 2222)//ApplicationSettingsCommon.RevitAPINewUnitsVersion) We have the API version in a class for common settings
            {
                return value.ToDecimalFeetCompatibility();

            }

            return ToForgeDecimalFeet(value);
        }


        /// <summary>
        /// Convert a value into decimal feet using the updated Forge Type ID unit system
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ToForgeDecimalFeet(double value)
        {
            var forgeTypeId = new ForgeTypeId(UnitTypeId.Millimeters.TypeId);

            return UnitUtils.ConvertToInternalUnits(value, forgeTypeId);
        }





        /// <summary>
        /// Method to convert feet to millimetres
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public static double ToMillimeters(this double value)
        {
            if (RevitVersionInformation.RevitVersionNumber < 2222)//ApplicationSettingsCommon.RevitAPINewUnitsVersion) We have the API version in a class for common settings ApplicationSettingsCommon.RevitAPINewUnitsVersion)
            {
                return value.ToMillimetersCompatibility();

            }

            return ToForgeMillimeters(value);

        }


        /// <summary>
        /// Convert a value into millimeters using the updated Forge Type ID unit system
        /// </summary>

        public static double ToForgeMillimeters(double value)
        {
            var forgeTypeId = new ForgeTypeId(UnitTypeId.Millimeters.TypeId);
            return UnitUtils.ConvertFromInternalUnits(value, forgeTypeId);
        }

    }
}
