using OOPUtilityInCSharp.InheritanceInCSharp.HybridInheritance;

namespace OOPUtilityInCSharp.InheritanceInCSharp
{
	internal class HybridInheritanceEntryPoint
	{
		internal void ExecuteHybridInheritance()
		{
			#region Simple Class Execution

			Orange orange = new Orange();

			Mango mango = new Mango();

			orange.forEat();

			orange.isFood();

			orange.hasSweetToTartTaste();

			mango.forEat();

			mango.isFood();

			mango.hasSweetToCreamyTaste();

			#endregion
		}
	}
}
