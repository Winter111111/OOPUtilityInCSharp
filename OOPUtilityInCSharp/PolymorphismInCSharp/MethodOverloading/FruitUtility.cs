namespace OOPUtilityInCSharp.PolymorphismInCSharp.MethodOverloading
{
	internal class FruitUtility
	{
		// Method with no parameters
		internal int AddFruitPrice() => 0;

		// Method with two integer parameters
		internal int AddFruitPrice(int price1, int price2) => price1 + price2;

		// Method with three double parameters
		internal double AddFruitPrice(double price1, double price2, double price3) => price1 + price2 + price3;

		// Method with a different parameter type
		internal string AddFruitPrice(string a, string b) => a + b;

	}
}
