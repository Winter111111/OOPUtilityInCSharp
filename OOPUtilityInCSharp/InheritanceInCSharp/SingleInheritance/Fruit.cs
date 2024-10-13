
namespace OOPUtilityInCSharp.InheritanceInCSharp.SingleInheritance
{
	// base class (parent class)
	internal class Fruit
    {
		internal void FruitTaste() => Console.WriteLine("Fruit has taste.");

		internal void FruitColor() => Console.WriteLine("Fruit has color.");
    }

	// derived class (child class)
	internal class Orange : Fruit
    {
		internal void hasTaste() => Console.WriteLine("Orange has tangy, sweet, and tart taste. ");

		internal void hasColor() => Console.WriteLine("Orange has dark orange color. ");
    }
}
