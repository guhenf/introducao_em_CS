namespace Exercicios.Domain
{
	public static class HelloWorld
	{
		public static string SayHello()
		{
			return "Hello World!";
		}

		public static void PassValue(int value)
		{
			value = 999;
		}

		public static void PassReference(Dog dog)
		{
			dog.Name = "Frederico";
		}
	}
}
