using HbToolbar.Common;


namespace HBRevit2022CompatabilityDemo
{
    public class CompatibilityExample
    {

        public void dummyMethod () 
        {
            //below are 4 examples of methods that have been created to handle depreciated items from the Revit 2022 API

            int offsetFt2Mm = (int)UnitConversion.ToDecimalFeet(300);

            var projectBasePoint = BasePointCheck.GetCompatibleBasePoint(basePoints, doc);

            var rule = FilterStringRuleCheck.GetCompatibleFilterStringRule(provider, evaluator, searchString, false);

            var paramType = ParameterDefinitionTypeCheck.GetCompatableParamDefinitionType(parameter.Definition);


        }
    }
}
