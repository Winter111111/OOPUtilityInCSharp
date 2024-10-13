using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUtilityInCSharp.InheritanceInCSharp.HierarchicalInheritance
{
	// base class (parent class)

	internal class Fruit
	{
		internal void hasTaste() => Console.WriteLine("Fruit has taste.");
	}
	// derived class (child class)

	internal class Mango : Fruit
	{
		internal void hasSweetToCreamyTaste() => Console.WriteLine("Mango has sweet and creamy taste.");
	}
	// derived class (child class)

	internal class Apple : Fruit
	{
		public void hasSweetToTartTaste() => Console.WriteLine("Orange has sweet, tart, or a little of both taste. ");
	}
}
