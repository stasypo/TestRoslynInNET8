namespace TestRoslynInNET8.Generators;

public partial class LoggingGenerators
{
    [LoggerMessage(Level = LogLevel.Warning, Message = "Value should be valid")]
    public partial void LogWaraning(string p1);
}