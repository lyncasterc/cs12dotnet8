HttpClient client = new();

HttpResponseMessage res = await client.GetAsync("https://www.google.com");
Console.WriteLine(res.StatusCode);

