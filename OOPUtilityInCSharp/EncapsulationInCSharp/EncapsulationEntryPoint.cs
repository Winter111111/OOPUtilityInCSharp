
namespace OOPUtilityInCSharp.EncapsulationInCSharp
{
	internal class EncapsulationEntryPoint
	{
		internal void ExecuteEncapsulation()
		{
			#region  Encapsulation Entry Point

			Fruit fruit = new Fruit();

			fruit.FruitName = "Mango";

			fruit.FruitPrice = 100;

			Console.WriteLine("Fruit Name is = {0}", fruit.FruitName);

			Console.WriteLine("Fruit Price is = {0}", fruit.FruitPrice);

			#endregion
		}
	}
}
