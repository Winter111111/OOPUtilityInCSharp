using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUtilityInCSharp
{
	static class StaticFruitClass
	{
		private static string? fruitName;
		private static int fruitPrice;
		private static bool fruitIsAailableInSeason;
		public static string? Name
		{
			get => fruitName;
			set => fruitName = value;
		}
		public static int Price
		{
			get => fruitPrice;
			set => fruitPrice = value;
		}
		public static bool IsAailableInSeason
		{
			get => fruitIsAailableInSeason;
			set => fruitIsAailableInSeason = value;
		}
	    static StaticFruitClass() => (Name, Price, IsAailableInSeason) = ("Apple", 8, true);
		public static void GetFruit() => Console.WriteLine("This is a static fruit class.");
		public static string? GetFruitName() => Name;
		public static int GetFruitPrice() => Price;
		public static bool GetFruitIsInSeason() => IsAailableInSeason;
	}
}
