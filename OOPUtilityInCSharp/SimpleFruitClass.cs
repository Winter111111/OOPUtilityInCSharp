namespace OOPUtilityInCSharp
{
	public class SimpleFruitClass
	{
		private string? fruitName;
		private int fruitPrice;
		private bool fruitIsAailableInSeason;
		public string? Name
		{
			get => fruitName;
			set => fruitName = value;
		}
		public int Price
		{
			get => fruitPrice;
			set => fruitPrice = value;
		}
		public bool IsAailableInSeason
		{
			get => fruitIsAailableInSeason;
			set => fruitIsAailableInSeason = value;
		}
		public SimpleFruitClass(string name, int price, bool isAvailable) =>(Name, Price, IsAailableInSeason) = (name, price, isAvailable);
		public void GetFruit() => Console.WriteLine("This is a simple fruit class.");
		public string? GetFruitName() => Name;
		public int GetFruitPrice() => Price;
		public bool GetFruitIsInSeason() => IsAailableInSeason;
	}
}
