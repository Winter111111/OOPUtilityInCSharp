
using OOPUtilityInCSharp.ClassesInCSharp;
using OOPUtilityInCSharp.InheritanceInCSharp;

#region MainEntryPointOfClass
	ClassesEntryPoint csharpClassCode = new ClassesEntryPoint();
	csharpClassCode.ExecuteSimpleClass();
	csharpClassCode.ExecuteStaticClass();
	csharpClassCode.ExecuteSealedClass();
#endregion

#region MainEntryPointOfInheritance
	InheritanceEntryPoint csharpInheritCode = new InheritanceEntryPoint();
	HybridInheritanceEntryPoint csharpHybridCode = new HybridInheritanceEntryPoint();

	csharpInheritCode.ExecuteSingleInheritance();
	csharpInheritCode.ExecuteMultilevelInheritance();
	csharpInheritCode.ExecuteHierarchicalInheritance();
	csharpInheritCode.ExecuteMultipleInheritance();
	csharpHybridCode.ExecuteHybridInheritance();
#endregion
