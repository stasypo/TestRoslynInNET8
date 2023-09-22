namespace TestRoslynInNET8.Generators;

public partial class LoggingGenerators
{
    // EXPECTED: partial method is generated successfully
    [LoggerMessage(Level = LogLevel.Warning, Message = "{p1} should be valid")]
    public partial void LogWarning(string p1);

    [LoggerMessage(
        EventId = 10,
        Level = LogLevel.Error,
        Message = "The handler with id [{requestId:D}] failed processing request")]
    public static partial void HandlerError(ILogger logger, Guid requestId);

    [GeneratedRegex(
        @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$",
        RegexOptions.CultureInvariant,
        500)]
    private static partial Regex MatchIfValidUrl();
    
    public void Test()
    {
        
    }
}