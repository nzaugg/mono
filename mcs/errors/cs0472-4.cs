// CS0472: The result of comparing value type `int' with null is `false'
// Line: 9
// Compiler options: -warnaserror -warn:2

class C
{
	public static void Main ()
	{
		System.Console.WriteLine(5 == (long?)null);
	}
}
