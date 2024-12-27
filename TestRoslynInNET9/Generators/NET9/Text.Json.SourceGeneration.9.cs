using System.Text.Json;
using System.Text.Json.Schema;

namespace TestRoslynInNET9.Generators.NET9;

public class Book
{
	public string Title { get; set; }
	public string? Author { get; set; }
	public int PublishYear { get; set; }
	
	public void Test()
	{
		var book = new Book
		{
			Title = "Test",
			Author = "Author",
			PublishYear = 2024
		};
		
		var json = JsonSerializer.Serialize(book);
		
		Console.WriteLine(JsonSchemaExporter.GetJsonSchemaAsNode(JsonSerializerOptions.Default, typeof(Book)));
	}
}