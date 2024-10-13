using OOPUtilityInCSharp.InheritanceInCSharp.MultilevelInheritance;
using OOPUtilityInCSharp.InheritanceInCSharp.SingleInheritance;
using OOPUtilityInCSharp.InheritanceInCSharp.HierarchicalInheritance;
using OOPUtilityInCSharp.InheritanceInCSharp.MultipleInheritance;



namespace OOPUtilityInCSharp.InheritanceInCSharp
{
	public class InheritanceEntryPoint
	{
		public void ExecuteSingleInheritance()
		{
			#region Simple Class Execution

			Orange objfruit = new Orange();

			objfruit.FruitTaste();

			objfruit.hasTaste();

			objfruit.FruitColor();

			objfruit.hasColor();

			#endregion
		}

		public void ExecuteMultilevelInheritance()
		{
			#region Simple Class Execution

			Blood_Orange bloodorange = new Blood_Orange();

			bloodorange.hasTaste();

			bloodorange.hasSweetToSourTaste();

			bloodorange.hasRedColor();

			#endregion
		}

		public void ExecuteHierarchicalInheritance()
		{
			#region Simple Class Execution

			Apple apple = new Apple();

			Mango mango = new Mango();

			apple.hasSweetToTartTaste();

			mango.hasSweetToCreamyTaste();

			#endregion
		}

		public void ExecuteMultipleInheritance()
		{
			#region Simple Class Execution

			Food food = new Food();

			food.ForCookingAndEating();

			food.ForEating();

			#endregion
		}

		
	}
}
