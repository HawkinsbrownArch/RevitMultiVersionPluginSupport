using System.Collections.Generic;
using Autodesk.Revit.DB;
using HbToolbar.Compatibility;

namespace HbToolbar.Common
{
    public class BasePointCheck
    {

        /// <summary>
        /// Method to determine which method is used to return the <see cref="Autodesk.Revit.DB.BasePoint"/> depending on which version of Revit is being used
        /// </summary>
        public static BasePoint GetCompatibleBasePoint(IEnumerable<BasePoint> projectLocationData, Document document)
        {

            if (RevitVersionInformation.RevitVersionNumber < 2222)//ApplicationSettingsCommon.RevitAPINewUnitsVersion) We have the API version in a class for common settings
            {
                return ProjectBasePointCompatibility.GetBasePointCompatibility(projectLocationData);
            }

            return GetBasePointRevitTwentyTwo(document);

        }

        /// <summary>
        /// Method to get the project <see cref="BasePoint"/> in Revit 2021 onwards
        /// </summary>
        public static BasePoint GetBasePointRevitTwentyTwo(Document document)
        {
            return BasePoint.GetProjectBasePoint(document);
        }
    }
}
