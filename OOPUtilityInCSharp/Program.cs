
using OOPUtilityInCSharp.ClassesInCSharp;
using OOPUtilityInCSharp.InheritanceInCSharp;
using OOPUtilityInCSharp.PolymorphismInCSharp;

#region Main Entry Point Of Class

	Console.WriteLine("----------Start OOP code about Simple Classes, Static Classes, Sealed Classes---------- \n");

	ClassesEntryPoint csharpClassCode = new ClassesEntryPoint();
	csharpClassCode.ExecuteSimpleClass();
	csharpClassCode.ExecuteStaticClass();
	csharpClassCode.ExecuteSealedClass();

	Console.WriteLine("\n----------End OOP code about Simple Classes, Static Classes, Sealed Classes---------- \n");

#endregion

#region Main Entry Point Of Inheritance

	Console.WriteLine("----------Start OOP code about Inheritance and Types of Inheritance---------- \n");

	InheritanceEntryPoint csharpInheritCode = new InheritanceEntryPoint();
	HybridInheritanceEntryPoint csharpHybridCode = new HybridInheritanceEntryPoint();

	csharpInheritCode.ExecuteSingleInheritance();
	csharpInheritCode.ExecuteMultilevelInheritance();
	csharpInheritCode.ExecuteHierarchicalInheritance();
	csharpInheritCode.ExecuteMultipleInheritance();
	csharpHybridCode.ExecuteHybridInheritance();

	Console.WriteLine("\n----------End OOP code about Inheritance and Types of Inheritance---------- \n");

#endregion

#region Main Entry Point Of Polymorhism

	Console.WriteLine("----------Start OOP code about Polymorhism---------- \n");

	PolymorphismEntryPoint csharpolymorhism = new PolymorphismEntryPoint();
	csharpolymorhism.ExecuteMethodOverloading();
	csharpolymorhism.ExecuteMethodOverriding();

	Console.WriteLine("----------End OOP code about Polymorhism---------- \n");
#endregion
