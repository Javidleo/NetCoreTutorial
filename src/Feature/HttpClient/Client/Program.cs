// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.ReadKey();

var client = new HttpClient();

client.BaseAddress = new Uri("https://localhost:7161");

var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "/api/User"));

Console.ReadKey();

var content = await response.Content.ReadAsStringAsync();

Console.WriteLine(content);

