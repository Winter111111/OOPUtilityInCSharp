
using OOPUtilityInCSharp.AbstractClassInCSharp;
using OOPUtilityInCSharp.ClassesInCSharp;
using OOPUtilityInCSharp.EncapsulationInCSharp;
using OOPUtilityInCSharp.InheritanceInCSharp;
using OOPUtilityInCSharp.NameSpaceInCSharp;
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

Console.WriteLine("----------Start Method Overloading---------- \n");
csharpolymorhism.ExecuteMethodOverloading();
Console.WriteLine("\n-----End Method Overloading----- \n");

Console.WriteLine("-----Start Method Overriding----- \n");
csharpolymorhism.ExecuteMethodOverriding();
Console.WriteLine("\n-----End Method Overriding----- \n");

Console.WriteLine("\n----------End OOP code about Polymorhism---------- \n");
#endregion

#region Main Entry Point Of Namespace

Console.WriteLine("----------Start NameSpace In OOP---------- \n");

NamespaceEntryPoint csharpNameSpace = new NamespaceEntryPoint();
csharpNameSpace.ExecuteNameSapce();

Console.WriteLine("\n----------End NameSpace IN OOP---------- \n");

#endregion

#region Main Entry Point Of Encapsulation

Console.WriteLine("----------Start Encapsulation In OOP---------- \n");

EncapsulationEntryPoint csharpEncapsulation = new EncapsulationEntryPoint();
csharpEncapsulation.ExecuteEncapsulation();

Console.WriteLine("\n----------End Encapsulation IN OOP---------- \n");

#endregion


#region Main Entry Point Of Abstract Class

Console.WriteLine("----------Start Abstract Class In OOP---------- \n");

AbstractClassEntryPoint csharpAbstractClass = new AbstractClassEntryPoint();
csharpAbstractClass.ExecuteAbstractClass();

Console.WriteLine("\n----------End Abstract Class IN OOP---------- \n");

#endregion



