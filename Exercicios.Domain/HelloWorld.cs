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
		public static string initTasks(string task, int steps)
		{
            Console.WriteLine($"## Task {task} starded.");

            for (var i = steps; i > 0; i--)
            {
				Thread.Sleep(1000);
                Console.WriteLine($"Task {task} is running... {i}");
            }
			return $"Task {task} completed.";
        }

        public static async Task<string> initTasksAsync(string task, int steps)
        {
            Console.WriteLine($"## Task {task} starded.");

            for (var i = steps; i > 0; i--)
            {
				await Task.Delay(1000);
                Console.WriteLine($"Task {task} is running... {i}");
            }
            return $"Task {task} completed.";
        }
    }
}