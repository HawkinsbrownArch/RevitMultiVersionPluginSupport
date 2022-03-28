using Autodesk.Revit.DB;


namespace HbToolbar.Compatibility
{
    public static class UnitExtensionsCompatibility
    {

        /// <summary>
        /// Converts the input value into Revit internal units - decimal feet.
        /// </summary>
        public static double ToDecimalFeetCompatibility(this double value)
        {

            return UnitUtils.ConvertToInternalUnits(value, DisplayUnitType.DUT_MILLIMETERS);
        }


        /// <summary>
        /// Converts the input value into Revit internal units - decimal feet.
        /// </summary>
        public static double ToMillimetersCompatibility(this double value)
        {

            return UnitUtils.ConvertFromInternalUnits(value, DisplayUnitType.DUT_MILLIMETERS);
        }
    }
}
