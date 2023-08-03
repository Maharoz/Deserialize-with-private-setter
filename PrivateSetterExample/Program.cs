using Newtonsoft.Json;

namespace PrivateSetterExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HttpClient client = new HttpClient();
			string json = client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1").Result;
			JsonSerializerSettings settings = new JsonSerializerSettings();
			settings.ContractResolver = new PrivateResolver();
			SampleModel a = JsonConvert.DeserializeObject<SampleModel>(json,settings);
			
		}
	}
}