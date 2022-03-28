using Autodesk.Revit.DB;


namespace HbToolbar.Compatibility
{
    public static class FilterStringRuleCompatibility
    {

        /// <summary>
        /// Return a R19 <see cref="FilterStringRule"/>
        /// </summary>
        public static FilterStringRule DepreciatedFilterStringRule( FilterableValueProvider provider, FilterStringRuleEvaluator evaluator, string stringRule, bool caseSensitive )
        {
            return new FilterStringRule(provider, evaluator, stringRule, caseSensitive);
        }
    }
}
