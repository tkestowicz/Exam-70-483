using System;
using System.Threading;

bool started = true;

Thread t = new Thread(() => {
	Console.WriteLine("Additional thread started.");

	int i;
	while(started)
{
	Console.WriteLine("Additional thread is counting: {0}", i++);
	Thread.Sleep(1000);
}
	
});

t.Start();

for(int i = 0; i< 7; i++)
{
	Console.WriteLine("Main thread is counting: {0}", i);
	Thread.Sleep(500);
}
started = false;

t.Join();
Console.WriteLine("Additional thread returned");