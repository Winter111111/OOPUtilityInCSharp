namespace OOPUtilityInCSharp.NameSpaceInCSharp
{
	internal class NamespaceEntryPoint
	{
		internal void ExecuteNameSapce()
		{
			#region  Namespace Entry Point

			FruitOneUtils fruitObjectOne = new FruitOneUtils();
			
			// We have FruitOneUtils from FruitLibrary
			string result1 = fruitObjectOne.FruitColor("Yellow");

			Console.WriteLine(result1);

			FruitTwoUtils fruitObjectTwo = new FruitTwoUtils();

			// We have FruitTwoUtils from FruitLibrary
			string result2 = fruitObjectTwo.FruitColor("Green");

			Console.WriteLine(result2);

			#endregion
		}
	}
}
