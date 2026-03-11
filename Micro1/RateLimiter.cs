
Dictionary<string, Queue<DateTime>> _request = new();
int _limit = 100;
TimeSpan _span = TimeSpan.FromSeconds(1);

GenerateRandomRequest();

bool AllowRequest(string userId){
    if(!_request.ContainsKey(userId)){
        _request[userId] = new Queue<DateTime>();
    }

    //Get the Queue
    var queue = _request[userId];
    var now = DateTime.UtcNow;

    //Check the queue time
    Console.WriteLine($"Request Count: {_request.Count}");
    Console.WriteLine($"UserId: {userId}");
    Console.WriteLine($"Span Time: {_span}");
    Console.WriteLine($"Queue Count: {queue.Count}");
    Console.WriteLine($"Queue: {string.Join(", ", queue)}");
    Console.WriteLine($"Now: {now}");
    
    if(queue.Count > 0){
        var peekTime = now - queue.Peek();

        Console.WriteLine($"Peek time: {peekTime}");

        Console.WriteLine($"Queue Count: {queue.Count} && Peek Time: {peekTime > _span}");
        while(queue.Count > 0 && peekTime > _span){
            Console.WriteLine("Dequeue Process");
            // Console.WriteLine($"Queue Count: {queue.Count} && Peek Time: {peekTime > _span}");
            queue.Dequeue();
        }
        
        Console.WriteLine($"Queue count after dequeue: {queue.Count}");

        //Check if queue count > _limit
        if(queue.Count >= _limit)
            return false;
        
        queue.Enqueue(now);
        Console.WriteLine($"Queue Enqueue: {queue.Count}");
        Console.WriteLine("-----------------------------------------------------");
    }
    else
    {
        queue.Enqueue(now);
        Console.WriteLine($"Queue Enqueue: {queue.Count}");
        Console.WriteLine("-----------------------------------------------------");
    }

    return true;
}

void GenerateRandomRequest(){
    string[] user = {"erymn", "budi", "joniwick", "centurion"}; 

    for(int i = 0; i < 1000; i++){
        AllowRequest(user[new Random().Next(user.Length)]);
    }   
}