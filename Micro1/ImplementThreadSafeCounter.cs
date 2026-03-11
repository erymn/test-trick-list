Console .WriteLine("Thread Safe Counter Implementation");

var safeCounter = new SafeCounter();

for(int i = 0; i < 10; i++){
    safeCounter.Increment();
}

Console.WriteLine($"Counter: {safeCounter.GetValue()}");

class SafeCounter
{
    int _counter = 0;

    public void Increment(){
        Interlocked.Increment(ref _counter);
    }

    public int GetValue(){
        return _counter;
    }
}