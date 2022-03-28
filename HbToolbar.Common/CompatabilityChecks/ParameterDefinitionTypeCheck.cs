using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using HbToolbar.Compatibility;

namespace HbToolbar.Common
{
    public class ParameterDefinitionTypeCheck
    {
        public static string GetCompatableParamDefinitionType(Definition definition)
        {
            if (RevitVersionInformation.RevitVersionNumber < 2222)//ApplicationSettingsCommon.RevitAPINewUnitsVersion) We have the API version in a class for common settings
            {
                return ParameterTypeCompatibility.DepreciatedParameterType(definition);
            }

            return GetParameterForgeTypeId(definition);
        }

        private static string GetParameterForgeTypeId(Definition definition)
        {
            return definition.GetDataType().ToString();
        }
    }

}
