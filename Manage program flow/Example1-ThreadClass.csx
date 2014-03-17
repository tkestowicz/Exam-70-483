using System;
using System.Threading;

Thread t = new Thread(() => {
	Console.WriteLine("Additional thread started.");
	for(int i = 0; i< 5; i++)
{
	Console.WriteLine("Additional thread is counting: {0}", i);
	Thread.Sleep(1000);
}
	
});

t.Start();

for(int i = 0; i< 7; i++)
{
	Console.WriteLine("Main thread is counting: {0}", i);
	Thread.Sleep(500);
}

t.Join();
Console.WriteLine("Additional thread returned");