using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUtilityInCSharp.InheritanceInCSharp.MultilevelInheritance
{
	
	// base class (parent class)
	internal class Fruit
	{
		internal void hasTaste() => Console.WriteLine("Fruit has taste.");
	}

	// derived class (child class)
	internal class Oranges : Fruit
	{
		internal void hasSweetToSourTaste() => Console.WriteLine("Oranges have tangy, sweet, and tart, sour taste.");
	}

	// derived class (child class)
	internal class Blood_Orange : Oranges
	{
		internal void hasRedColor() => Console.WriteLine("Blood Orange has red color of it's Juice.");
	}
}
