// See https://aka.ms/new-console-template for more information
using DesignPatterns;

Console.WriteLine("Hello, World!");

//Thread thread1 = new Thread(() =>
//{
//    var instance = Singleton.Instance;
//    Console.WriteLine(instance.SingletonId);

//});


//Thread thread2 = new Thread(() =>
//{
//    var instance = Singleton.Instance;
//    Console.WriteLine(instance.SingletonId);

//});

//Thread thread3 = new Thread(() =>
//{
//    var instance = Singleton.Instance;
//    //Console.WriteLine(instance.SingletonId);

//});


//Thread thread4 = new Thread(() =>
//{
//    var instance = Singleton.Instance;
//// Console.WriteLine(instance.SingletonId);

//});

//thread1.Start();
//thread1.Join();
//thread2.Start();
//thread2.Join();
//thread3.Start();
//thread4.Start();



//thread3.Join();
//thread4.Join();


Task task1 = Task.Factory.StartNew(() => { 
    var instance1 = Singleton.Instance;
    Console.WriteLine(instance1.SingletonId);
});
Task task2 = Task.Factory.StartNew(() => {
    var instance2 = Singleton.Instance;
    Console.WriteLine(instance2.SingletonId);
});
Task task3 = Task.Factory.StartNew(() => {
    var instance3 = Singleton.Instance;
    Console.WriteLine(instance3.SingletonId);
});

Task.WaitAll(task1, task2, task3);
Console.WriteLine("All threads complete");


Task task4 = Task.Factory.StartNew(() => {
    var instance1 = ThreadSafeSingleton.Instance;
    Console.WriteLine(instance1.SingletonId);
});
Task task5 = Task.Factory.StartNew(() => {
    var instance2 = ThreadSafeSingleton.Instance;
    Console.WriteLine(instance2.SingletonId);
});
Task task6 = Task.Factory.StartNew(() => {
    var instance3 = ThreadSafeSingleton.Instance;
    Console.WriteLine(instance3.SingletonId);
});

Task.WaitAll(task4, task5, task6);
Console.WriteLine("All threads complete");

Task task7 = Task.Factory.StartNew(() => {
    var instance1 = ThreadSafeWithoutLock.Instance;
    Console.WriteLine(instance1.SingletonId);
});
Task task8 = Task.Factory.StartNew(() => {
    var instance2 = ThreadSafeWithoutLock.Instance;
    Console.WriteLine(instance2.SingletonId);
});
Task task9 = Task.Factory.StartNew(() => {
    var instance3 = ThreadSafeWithoutLock.Instance;
    Console.WriteLine(instance3.SingletonId);
});

Task.WaitAll(task7, task8, task9);
Console.WriteLine("All threads complete");

