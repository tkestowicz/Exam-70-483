using System;
using System.Threading;

Thread t = new Thread(() => {
	Console.WriteLine("Additional thread started.");

	for(int i = 0; i < 10; i++)
{
	Console.WriteLine("Additional thread is counting: {0}", i);
	Thread.Sleep(1000);
}
	
});

t.IsBackground = true;
t.Start();

for(int i = 0; i< 5; i++)
{
	Console.WriteLine("Main thread is counting: {0}", i);
	Thread.Sleep(500);
}

Console.WriteLine("Program finished");