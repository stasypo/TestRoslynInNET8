namespace TestRoslynInNET9.Generators.NET9;

public partial class ClassWithPrimaryConstructor(ILogger logger)
{
	// EXPECTED: partial method is generated successfully
	[LoggerMessage(0, LogLevel.Debug, "Test.")]
	public partial void Test();
}