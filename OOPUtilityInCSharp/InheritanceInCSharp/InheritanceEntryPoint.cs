using OOPUtilityInCSharp.InheritanceInCSharp.MultilevelInheritance;
using OOPUtilityInCSharp.InheritanceInCSharp.SingleInheritance;
using OOPUtilityInCSharp.InheritanceInCSharp.HierarchicalInheritance;
using OOPUtilityInCSharp.InheritanceInCSharp.MultipleInheritance;



namespace OOPUtilityInCSharp.InheritanceInCSharp
{
	internal class InheritanceEntryPoint
	{
		internal void ExecuteSingleInheritance()
		{
			#region Simple Class Execution

			Orange objfruit = new Orange();

			objfruit.FruitTaste();

			objfruit.hasTaste();

			objfruit.FruitColor();

			objfruit.hasColor();

			#endregion
		}

		internal void ExecuteMultilevelInheritance()
		{
			#region Simple Class Execution

			Blood_Orange bloodorange = new Blood_Orange();

			bloodorange.hasTaste();

			bloodorange.hasSweetToSourTaste();

			bloodorange.hasRedColor();

			#endregion
		}

		internal void ExecuteHierarchicalInheritance()
		{
			#region Simple Class Execution

			Apple apple = new Apple();

			Mango mango = new Mango();

			apple.hasSweetToTartTaste();

			mango.hasSweetToCreamyTaste();

			#endregion
		}

		internal void ExecuteMultipleInheritance()
		{
			#region Simple Class Execution

			Food food = new Food();

			food.ForCookingAndEating();

			food.ForEating();

			#endregion
		}

		
	}
}
