using Playground.Monads;
using System;

class Program
{
    static void Main(string[] args)
    {
        var result = SomeLogic();

        var response = result.MatchWith(error => "error response", success => "success response");
        Console.WriteLine(response);
    }

    public static Either<Exception, SomeResult> SomeLogic()
    {
        var callResult = false;
        return callResult ? new SomeResult() : new Exception();
    }
}