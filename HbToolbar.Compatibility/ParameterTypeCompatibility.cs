using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace HbToolbar.Compatibility
{

    /// <summary>
    /// return the 
    /// </summary>
    public static class ParameterTypeCompatibility
    {
        public static string DepreciatedParameterType(Definition definition)
        {
            return definition.ParameterType.ToString();
        }

    }
}
