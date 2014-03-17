using System;
using System.Threading;

public static class Worker{

	public static void Todo(object max){
		Console.WriteLine("Additional thread started.");
			for(int i = 0; i< (int)max; i++)
		{
			Console.WriteLine("Additional thread is counting: {0}", i);
			Thread.Sleep(1000);
		}
	}

}

Thread t = new Thread((max) => {
	Console.WriteLine("Another additional thread started.");
	for(int i = 0; i< (int)max; i++)
{
	Console.WriteLine("Another additional thread is counting: {0}", i);
	Thread.Sleep(1000);
}
	
});

Thread t2 = new Thread(new ParameterizedThreadStart(Worker.Todo));

t.Start(4);
t2.Start(2);

for(int i = 0; i< 3; i++)
{
	Console.WriteLine("Main thread is counting: {0}", i);
	Thread.Sleep(500);
}

t.Join();
t2.Join();
Console.WriteLine("Additional threads returned.");