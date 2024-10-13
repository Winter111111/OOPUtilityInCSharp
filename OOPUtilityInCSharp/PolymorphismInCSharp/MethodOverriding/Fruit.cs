namespace OOPUtilityInCSharp.PolymorphismInCSharp.MethodOverriding
{
	
	// Base class (parent class)
	internal class Fruit
	{
		internal virtual void Taste() => Console.WriteLine("Fruits have unique taste.");

		// Base class method.
		internal virtual void GetFruit(string fruitName) => Console.WriteLine("Fruit name is : {0}", fruitName);
	}

	// Derive class (child class)
	internal class WaterMelon : Fruit
	{
		internal override void Taste() => Console.WriteLine("WaterMelon has mixture of sweet, sour and bitter taste.");

		// Derive class method.

		internal override void GetFruit(string fruitName)
		{
			base.GetFruit("WaterMelon");
			Console.WriteLine("{0} has sweet, tart eating taste", fruitName);
		}

	}

	// Derive class (child class)
	internal class Mango : Fruit
	{
		internal override void Taste() => Console.WriteLine("Mango has sweet and creamy taste.");
	}
}
