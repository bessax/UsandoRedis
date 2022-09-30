using Newtonsoft.Json;
using UsandoRedis.Connection;
using UsandoRedis.Model;

Console.WriteLine(" === Usando o Redis ===");

Console.WriteLine("Salvando um objeto no Cache.");
Random random = new Random();   
Client cli = new Client();
cli.Id = random.Next(0, 100);
cli.Name = "André Silva";
cli.Email = "andre@email.com";
SaveData(cli);

Console.WriteLine("Lendo um objeto no Cache.");
ReadData(cli.Id);

void ReadData(int id)
{
    var cache = RedisConnection.Connection.GetDatabase();
    var value = cache.StringGet($"Cli_{id}");
    var cli = JsonConvert.DeserializeObject<Client>(value.ToString());
    Console.WriteLine(cli.ToString());    
}

void SaveData(Client cli)
{  
    var json = JsonConvert.SerializeObject(cli, Formatting.Indented);  
    var cache = RedisConnection.Connection.GetDatabase();  
    cache.StringSet($"Cli_{cli.Id}",json);   
}
