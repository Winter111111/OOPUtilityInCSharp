using System;
using System.Collections.Generic;
namespace OOPUtilityInCSharp.PolymorphismInCSharp.MethodOverriding
{
	
	// Base class (parent class)
	internal class Fruit
	{
		internal virtual void Taste() => Console.WriteLine("Fruits have unique taste.");
	}

	// Derive class (child class)
	internal class WaterMelon : Fruit
	{
		internal override void Taste() => Console.WriteLine("WaterMelon has mixture of sweet, sour and bitter taste.");
	}

	// Derive class (child class)
	internal class Mango : Fruit
	{
		internal override void Taste() => Console.WriteLine("Mango has sweet and creamy taste.");
	}
}
