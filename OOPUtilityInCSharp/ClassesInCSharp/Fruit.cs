namespace OOPUtilityInCSharp.ClassesInCSharp
{
	// Base class (parent class)

	public class Fruit
	{
		public virtual void Taste() => Console.WriteLine("Fruits have unique taste.");
		public virtual void Color() => Console.WriteLine("Fruits have unique color.");
	}
	// Derive class (child class)

	public class WaterMelon : Fruit
	{
		public sealed override void Taste() => Console.WriteLine("WaterMelon has mixture of sweet, sour and bitter taste.");
		public override void Color() => Console.WriteLine("WaterMelon has Dark Green Color.");
	}
	// Derive class (child class)

	public class SweetWater : WaterMelon
	{
		// As Taste() method is sealed in WaterMelon class so we cannot inherit it here in SweetWater class.
		// If we will try to inherit it we will get below error.
		// 'SweetWater.Taste()': cannot override inherited member 'WaterMelon.Taste()' because it is sealed.

		//public override void Taste() => Console.WriteLine("Watermelon has sweet and fruity water.");
		public override void Color() => Console.WriteLine("WaterMelon water has red color.");
	}
}
