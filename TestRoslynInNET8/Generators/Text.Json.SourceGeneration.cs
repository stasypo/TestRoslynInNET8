using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestRoslynInNET8.Generators;

public class TextJsonSourceGeneration
{
    
    public void TestMethod()
    {
        // Missing member handling
        // JsonException : The JSON property 'AnotherId' could not be mapped to any .NET member contained in type 'MyPoco'.
        JsonSerializer.Deserialize<MyPoco>("""{"Id" : 42, "AnotherId" : -1 }"""); 
        
        // JsonContent.Create overloads accepting JsonTypeInfo
        var book = new Book(id: 42, "Title", "Author", publishedYear: 2023);
        HttpContent content = JsonContent.Create(book, MyContext2.Default.Book);
    }
}

[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public class MyPoco
{
    public int Id { get; set; }
    // Support for required and init properties
    public required int X { get; set; }
    public int Y { get; init; }
}

// JsonSourceGenerationOptionsAttribute feature parity with the JsonSerializerOptions class, enabling specifying
// serialization configuration at compile time
[JsonSourceGenerationOptions(JsonSerializerDefaults.Web,
    AllowTrailingCommas = true,
    Converters = new[] { typeof(JsonStringEnumConverter<MyEnum>) },
    DefaultBufferSize =  1024,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
    DictionaryKeyPolicy = JsonKnownNamingPolicy.SnakeCaseUpper,
    IgnoreReadOnlyFields = true,
    IgnoreReadOnlyProperties = true,
    IncludeFields = true,
    MaxDepth = 1024,
    NumberHandling = JsonNumberHandling.WriteAsString,
    PreferredObjectCreationHandling = JsonObjectCreationHandling.Replace,
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.KebabCaseUpper,
    ReadCommentHandling = JsonCommentHandling.Skip,
    UnknownTypeHandling = JsonUnknownTypeHandling.JsonNode,
    UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
    WriteIndented = true)]
[JsonSerializable(typeof(MyPoco))]
public partial class MyContext : JsonSerializerContext { } // EXPECTED: partial method is generated successfully

public enum MyEnum
{
}

public record Book(int id, string title, string author, int publishedYear);

// EXPECTED: partial method is generated successfully
[JsonSerializable(typeof(Book))]
public partial class MyContext2 : JsonSerializerContext 
{ }