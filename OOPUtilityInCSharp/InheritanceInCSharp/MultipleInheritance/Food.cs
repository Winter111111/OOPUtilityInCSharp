using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUtilityInCSharp.InheritanceInCSharp.MultipleInheritance
{
	public class Food : IFruits, IVegetables
	{
		public void ForCookingAndEating() => Console.WriteLine("Vegatables are for cooking and eating.");

		public void ForEating() => Console.WriteLine("Fruits are for eating.");
	}
	// Vegetables interface

	interface IVegetables
	{
		void ForCookingAndEating();
	}
	// Fruits interface

	interface IFruits
	{
		void ForEating();
	}
}
