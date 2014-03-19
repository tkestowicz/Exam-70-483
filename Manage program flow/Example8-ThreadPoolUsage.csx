using System;
using System.Threading;

ThreadPool.QueueUserWorkItem((state) => {

	Console.WriteLine("Additional thread started.");

	for(int i = 0; i< 5; i++)
	{
		Console.WriteLine("Additional thread is counting: {0}", i);
		Thread.Sleep(300);
	}
	
});

public static class Worker{

	public static void Todo(object iterations){
		Console.WriteLine("Another one thread started.");
			for(int i = 0; i< (int)iterations; i++)
		{
			Console.WriteLine("Another one is counting: {0}", i);
			Thread.Sleep(100);
		}
	}

}

ThreadPool.QueueUserWorkItem(new WaitCallback(Worker.Todo), 5);

Thread.Sleep(2000);