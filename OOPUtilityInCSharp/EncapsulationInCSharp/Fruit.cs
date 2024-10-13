using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
namespace OOPUtilityInCSharp.EncapsulationInCSharp
{
	
	// parent class
	internal class Fruit
	{
		internal string? fruitName;
		internal int fruitPrice;
		
		//FruitName and FruitPrice Properties
		internal string? FruitName
		{
			get { return fruitName; }
			set { fruitName = value; }
		}
		internal int FruitPrice
		{
			get { return fruitPrice; }
			set { fruitPrice = value; }
		}
	}
}
