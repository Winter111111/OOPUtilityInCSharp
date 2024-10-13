namespace OOPUtilityInCSharp.ClassesInCSharp
{
	public class ClassesInCSharp
	{
		public void ExecuteSimpleClass()
		{
			#region Simple Class Execution

			SimpleFruitClass objSimpleFruit = new SimpleFruitClass("Mango", 20,  true);
			// Calling a method

			objSimpleFruit.GetFruit();
			// Accessing a field fruit price

			int fieldPrice = objSimpleFruit.GetFruitPrice();
			// Accessing a field fruit name

			string? fieldName = objSimpleFruit.GetFruitName();
			// Accessing a field fruit is in market

			bool fieldIsInMarket = objSimpleFruit.GetFruitIsInSeason();

			Console.WriteLine("Fruit name: " + fieldName + " Fruit price:" + fieldPrice + " Is available in market :" + fieldIsInMarket);

			#endregion
		}

		public void ExecuteStaticClass()
		{
			#region Static Class Execution

			// Calling a method

			StaticFruitClass.GetFruit();
			// Accessing a field fruit price

			int fieldPrice = StaticFruitClass.GetFruitPrice();
			// Accessing a field fruit name

			string? fieldName = StaticFruitClass.GetFruitName();
			// Accessing a field fruit is in market

			bool fieldIsInMarket = StaticFruitClass.GetFruitIsInSeason();

			Console.WriteLine("Fruit name: " + fieldName + " Fruit price:" + fieldPrice + " Is available in market :" + fieldIsInMarket);

			#endregion
		}

		public void ExecuteSealedClass()
		{
			#region Sealed Class Execution

			Fruit objfruit;
			objfruit = new Fruit();
			objfruit.Taste();
			objfruit.Color();
			objfruit = new WaterMelon();
			objfruit.Taste();
			objfruit.Color();
			objfruit = new SweetWater();
			objfruit.Color();

			#endregion
		}
	}
}
