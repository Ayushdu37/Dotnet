using System;

interface IDisposable
{
    void Dispose();
}

interface INotifier
{
    void Log();
}

class ResourceHandler : IDisposable, INotifier
{
    void IDisposable.Dispose()
    {
        Console.WriteLine("Resource disposed");
    }
    void INotifier.Log()
    {
        Console.WriteLine("Notification sent");
    }
}


