using System;
using System.Threading;

[ThreadStatic]
static int sum;

Thread t = new Thread(() => {
	Console.WriteLine("Additional thread started.");

	for(int i = 0; i < 3; i++)
{
	Console.WriteLine("Additional thread is counting: {0}", i);
	sum += i;
	Thread.Sleep(1000);
}
Console.WriteLine("Additional thread result is: {0}", sum);
	
});

t.Start();

for(int i = 0; i< 5; i++)
{
	Console.WriteLine("Main thread is counting: {0}", i);
	Thread.Sleep(500);
	sum += i;
}
Console.WriteLine("Main thread result is: {0}", sum);

t.Join();
Console.WriteLine("Additional thread returned");