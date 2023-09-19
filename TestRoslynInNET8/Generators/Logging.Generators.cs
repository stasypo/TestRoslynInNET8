namespace TestRoslynInNET8.Generators;

public partial class LoggingGenerators
{
    // EXPECTED: partial method is generated successfully
    [LoggerMessage(Level = LogLevel.Warning, Message = "Value should be valid")]
    public partial void LogWaraning(string p1);
}