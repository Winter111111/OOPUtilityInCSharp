using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUtilityInCSharp.InheritanceInCSharp.HybridInheritance
{
	
	// base class (parent class)
	internal class Food
	{
		internal void forEat() => Console.WriteLine("Fruits are for eating.");
	}

	// derive class (child class)
	internal class Fruit : Food
	{
		public void isFood() => Console.WriteLine("Fruit is a Food. ");
	}

	// derived class (child class)
	internal class Mango : Fruit
	{
		public void hasSweetToCreamyTaste() => Console.WriteLine("Mango has sweet and creamy taste.");
	}

	// derived class (child class)
	internal class Orange : Fruit
	{
		public void hasSweetToTartTaste() => Console.WriteLine("Orange has tangy, sweet, and tart, sour taste.");
	}
}
