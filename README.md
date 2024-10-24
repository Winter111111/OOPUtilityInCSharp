<!DOCTYPE html>
<html lang="en">
<head>
<meta name="google-site-verification" content="uZq-Afnefgjvtnio4q8XjEmQtP7FPhB72LzQ_iYBLqM" />
</head>
<body>
<h1>Object Oriented Programming in C#</h1> 
<h2>Class</h2>
<p>A class is basic pillar of OOP that is called when instance of a class is created. A class can have fields, properties, method, constructor and destructor etc. When we create an instance of class. This instance of class is used to access of fields, methods, properties, constructor (constructor can zero argument or multiple argument) and destructor. A class is reference type and stores in heap.</p>
<h2>Static Class</h2>
<p>In C#, a static is a keyward that is used with fields, methods, properties and classes when we make these members static they are globally accessble in all over the application.</p>
<h2>Sealed Class</h2>
<p>When you have class as base class and you want that any other derived class can not inherit this base class then we declared the base class as sealed class. The sealed keyword also can be used with method, property or event in the derived class to prevent further overriding. This is often done to protect the integrity of a class or to prevent unintentional modifications to its behavior.</p>
<h2>Abstract Class</h2>
<p>When you have a class, method, property that doe not required implementation in current class you can make the that class, method, property abstract, Once we have defined abstract class, method and properties in base class then this abstract class, method and porperty can be overridden or implemented in derived (child) classes.</p>
<h2>Inheritance</h2>
<p>You can create a base class (parent class). You can derive a new class (child class) from this existing base class (parent class). When you inherit a child class with base class you also inherit it's members (fields, methods, properties etc.). you can also add these members and also can modify them as needed.Inheritance promotes code reuse, simplifies code maintenance, and improves code organization.</p>
<h2>Polymorphism</h2>
<p>Polymorphism mean many forms that we usually archived with static binding and dynamic binding. which also called late binding and early binding.</p>
<h2>Interface</h2>
<p>Multiple inheritance is not supported in C#. So for accomplishing multiple inheritance (many to many relationship) we use interface. For making interface we use interface keyword and give a interface name. Interface have method without body. A set of method, properties signatures are defined in interface that can be implement only in that class which derived from this interface. A class which implement to interface that will have methods with body.</p>
<h2>Namespace</h2>
<p>A namespace is a container of group related classes, structs, enums, interfaces, and other types. You can organize related classes in a specific namespace. Namespaces help avoid naming conflicts between types and provide a hierarchical structure for organizing your code.</p>
<h2>Access Modifiers</h2>
<p>Access modifiers are keywords used to specify the declared accessibility of a member or a type. With access modifier we defined the boundary of fields, methods, constructor, properties and events. With access modifier we told a program either it's code will accessible within same class or within another classs ot it will be accessible within sname assembly or within another assembly. So we set the boundary of accessibility of code with access modifier.</p>
<h2>Encapsulation</h2>
<p>When you have such type of data in which you need the grouping of related operation into single unit, You can use encapsulation. Access modifier (such as Private, Public, Protected, Interval etc.) can be used for achieving the encapsulation. The encapsulation is used most commonly for data hiding.</p>
<p style="font-weight: bold;">Source: <a href="https://c-sharptutorial.com">https://c-sharptutorial.com</a></p>
</body>
</html>
