
Console.WriteLine("Hello, World!");

Console.ReadKey();

var clinet = new HttpClient();

clinet.BaseAddress = new Uri("https://localhost:7160");

var response = await clinet.SendAsync(new HttpRequestMessage(HttpMethod.Get, "/api/User"));

Console.ReadKey();
if (response.IsSuccessStatusCode)
{
    var content = await response.Content.ReadAsStringAsync();
    Console.Write(content);
}
else
    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
