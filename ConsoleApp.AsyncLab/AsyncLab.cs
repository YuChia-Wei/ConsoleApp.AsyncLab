public class AsyncLab
{
    public async Task RunAsync()
    {
        var asyncRun = new AsyncRun();
        Console.WriteLine($"{DateTime.Now} start - await");
        await asyncRun.RunAwaitAsync("await");
        await asyncRun.RunNoAwaitAndNoAsync("await");
        await asyncRun.RunNoAwaitAsync("await");
        Console.WriteLine($"{DateTime.Now} end");

        Console.WriteLine($"{DateTime.Now} start - no await");
        asyncRun.RunAwaitAsync("no await");
        asyncRun.RunNoAwaitAndNoAsync("no await");
        asyncRun.RunNoAwaitAsync("no await");
        Console.WriteLine($"{DateTime.Now} end");
    }
}

public class AsyncRun
{
    public async Task RunAwaitAsync(string entry)
    {
        Console.WriteLine($"{DateTime.Now} : {entry} step {nameof(RunAwaitAsync)} start");
        await Task.Delay(5000);
        Console.WriteLine($"{DateTime.Now} : {entry} step {nameof(RunAwaitAsync)} end");
    }

    public Task RunNoAwaitAndNoAsync(string entry)
    {
        Console.WriteLine($"{DateTime.Now} : {entry} step {nameof(RunNoAwaitAndNoAsync)} start");
        Task.Delay(5000);
        Console.WriteLine($"{DateTime.Now} : {entry} step {nameof(RunNoAwaitAndNoAsync)} end");
        return Task.CompletedTask;
    }

    public async Task RunNoAwaitAsync(string entry)
    {
        Console.WriteLine($"{DateTime.Now} : {entry} step {nameof(RunNoAwaitAsync)} start");
        Task.Delay(5000);
        Console.WriteLine($"{DateTime.Now} : {entry} step {nameof(RunNoAwaitAsync)} end");
    }
}