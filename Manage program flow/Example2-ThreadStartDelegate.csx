using System;
using System.Threading;

public static class Worker{

	public static void Todo(){
		Console.WriteLine("Additional thread started.");
			for(int i = 0; i< 2; i++)
		{
			Console.WriteLine("Additional thread is counting: {0}", i);
			Thread.Sleep(1000);
		}
	}

}

Thread t = new Thread(new ThreadStart(Worker.Todo));

t.Start();

for(int i = 0; i< 3; i++)
{
	Console.WriteLine("Main thread is counting: {0}", i);
	Thread.Sleep(500);
}

t.Join();
Console.WriteLine("Additional threads returned.");