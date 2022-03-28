using Autodesk.Revit.DB;
using HbToolbar.Compatibility;

namespace HbToolbar.Common
{
    public static class FilterStringRuleCheck
    {


        /// <summary>
        /// Returns a multi API compatable <see cref="FilterStringRule"/>
        /// </summary>
        public static FilterStringRule GetCompatibleFilterStringRule(FilterableValueProvider provider, FilterStringRuleEvaluator evaluator, string stringRule, bool caseSensitive)
        {
            if (RevitVersionInformation.RevitVersionNumber < 2222)//ApplicationSettingsCommon.RevitAPINewUnitsVersion) We have the API version in a class for common settings
            {

                return FilterStringRuleCompatibility.DepreciatedFilterStringRule(provider, evaluator, stringRule, caseSensitive);
            }


            return FilterStringRuleRevitTwentyTwo(provider, evaluator, stringRule);
        }


        /// <summary>
        /// Create a R22 <see cref="FilterStringRule"/>
        /// </summary>
        public static FilterStringRule FilterStringRuleRevitTwentyTwo(FilterableValueProvider provider, FilterStringRuleEvaluator evaluator, string stringRule)
        {
            return new FilterStringRule(provider, evaluator, stringRule);
        }



    }
}
