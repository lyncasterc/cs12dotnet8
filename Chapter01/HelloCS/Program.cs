﻿Console.WriteLine("Hello, C#!");

string name = typeof(Program).Namespace ?? "None";
Console.WriteLine($"Namespace: {name}");