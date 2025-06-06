#:package Cowsay

using Cowsay;

var staticCow = await DefaultCattleFarmer.RearCowWithDefaults("default");

Console.WriteLine(staticCow.Say("Hello, .NET10 and C#14!", cowEyes: "$$"));