using System;
using System.Collections.Generic;

namespace OOPUtilityInCSharp.AbstractClassInCSharp
{
	
	// create an abstract class
	internal abstract class Fruit
	{
		// abstract property
		internal abstract string Color { get; set; }
		// abstract method
		internal abstract void FruitColor();
		// non-abstract method

		internal void FruitTaste()
		{
			Console.WriteLine("Fruits have taste");
		}
	}
	// inheriting from abstract class

	internal class WaterMelon : Fruit
	{
		// provide implementation of abstract property

		internal override string? Color { get; set; }
		// provide implementation of abstract method

		internal override void FruitColor()
		{
			Console.WriteLine("WaterMelon has {0} color", Color);
		}
	}
	// inheriting from abstract class

	internal class Mango : Fruit
	{
		// provide implementation of abstract property

		internal override string? Color { get; set; }
		// provide implementation of abstract method

		internal override void FruitColor()
		{
			Console.WriteLine("Mango has {0} color", Color);
		}
	}
}
