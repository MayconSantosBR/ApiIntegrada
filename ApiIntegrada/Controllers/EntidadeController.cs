using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace ApiIntegrada.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntidadeController : ControllerBase
    {
        string databaseName = Environment.GetEnvironmentVariable("DATABASE_NAME") ?? "Entidades1";
        string mongoUri = Environment.GetEnvironmentVariable("MONGO_URI") ?? "mongodb://localhost:27017";
        string vizinhos = Environment.GetEnvironmentVariable("VIZINHOS") ?? "api2:3002";

        public EntidadeController()
        {
        }

        [HttpGet]
        public ActionResult<Entidade> Get([FromQuery] string id, [FromHeader] List<string> scopes)
        {
            IMongoDatabase database = ConectarMongoDb();
            IMongoCollection<Entidade> collection = database.GetCollection<Entidade>(databaseName);
            Entidade entidade = collection.Find(e => e._id == id).FirstOrDefault();

            if (entidade == null)
            {
                var vizinhosArray = vizinhos.Split(",");

                foreach (var vizinho in vizinhosArray)
                {
                    var domain = vizinho.Split(":")[0];
                    var port = vizinho.Split(":")[1];
                    var server = ExtractNumbers(domain);

                    var client = new HttpClient();
                    scopes.Add(ExtractNumbers(databaseName));
                    client.DefaultRequestHeaders.Add("scopes", scopes); 
                    var response = client.GetFromJsonAsync<Entidade>($"https://{domain}:{port}/Entidade?id={id}").Result;

                    if (response != null)
                    {
                        entidade = response;
                        break;
                    }
                }
            }

            if (entidade == null)
                return NotFound();

            return Ok(entidade);
        }

        private IMongoDatabase ConectarMongoDb()
        {
            MongoClient client = new MongoClient(mongoUri);
            IMongoDatabase database = client.GetDatabase(databaseName);
            return database;
        }

        string ExtractNumbers(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\d+");

            string result = "";

            foreach (Match match in matches)
                result += match.Value;

            return result;
        }
    }
}
