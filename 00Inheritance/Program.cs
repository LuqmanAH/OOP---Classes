using System.ComponentModel;
using InheritanceTutorial;

static class Program {
	static void Main() {
		string name = "Suleiman" ;
		Parent parent = new Parent(name);
		Child child = new Child(name);

		Console.WriteLine(parent.myString);
		Console.WriteLine(child.myString);
		// parent.MyMethodParent();
		// child.MyMethodChild();
		// parent.MyMethodParent();

		// Console.WriteLine("\n");
		// child.MyMethodParent();
	}
}