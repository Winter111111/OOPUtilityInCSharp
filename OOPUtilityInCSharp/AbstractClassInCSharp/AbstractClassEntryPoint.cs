using OOPUtilityInCSharp.AbstractClassInCSharp;

namespace OOPUtilityInCSharp.AbstractClassInCSharp
{
	internal class AbstractClassEntryPoint
	{
		internal void ExecuteAbstractClass()
		{
			#region  Abstract Entry Point

			Fruit fruit;
			// create an object of WaterMelon class

			fruit = new WaterMelon();

			fruit.Color = "Dark Green";

			fruit.FruitColor();

			// create an object of Mango class

			fruit = new Mango();

			fruit.Color = "Yellow";

			fruit.FruitColor();

			#endregion
		}
	}
}
