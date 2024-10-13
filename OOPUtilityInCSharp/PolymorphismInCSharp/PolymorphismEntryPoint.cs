using OOPUtilityInCSharp.PolymorphismInCSharp.MethodOverloading;
using OOPUtilityInCSharp.PolymorphismInCSharp.MethodOverriding;

namespace OOPUtilityInCSharp.PolymorphismInCSharp
{
	internal class PolymorphismEntryPoint
	{
		internal void ExecuteMethodOverloading()
		{
			#region  MethodOverloading Entry Point

			FruitUtility objfruitutil = new FruitUtility();

			int result1 = objfruitutil.AddFruitPrice();

			int result2 = objfruitutil.AddFruitPrice(5, 3);

			double result3 = objfruitutil.AddFruitPrice(2.3, 2.2, 3.4);

			string result4 = objfruitutil.AddFruitPrice("Sweet", "Apple");

			Console.WriteLine(result1);

			Console.WriteLine(result2);

			Console.WriteLine(result3);

			Console.WriteLine(result4);

			#endregion
		}

		internal void ExecuteMethodOverriding()
		{
			#region  MethodOverriding Entry Point

			Fruit objfruit;

			objfruit = new Fruit();

			objfruit.Taste();

			objfruit = new WaterMelon();

			objfruit.Taste();
			objfruit.GetFruit("Orange");

			objfruit = new Mango();

			objfruit.Taste();

			#endregion
		}
	}
}
