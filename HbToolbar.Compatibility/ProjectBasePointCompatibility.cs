using System;
using System.Collections.Generic;
using Autodesk.Revit.DB;

namespace HbToolbar.Compatibility
{
    public static class ProjectBasePointCompatibility
    {

        public static BasePoint GetBasePointCompatibility(IEnumerable<BasePoint> projectLocationData)
        {

            foreach (var locationPoint in projectLocationData)
            {
                BasePoint basePoint = locationPoint as BasePoint;
                if (basePoint.IsShared == false)
                {
                    return basePoint;
                }
            }

            return null;
        }

    }
}
