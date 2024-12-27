using System.Text.RegularExpressions;

namespace TestRoslynInNET9.Generators.NET9;

public partial class GeneratedRegex_9
{
	// EXPECTED: partial method is generated successfully
	[GeneratedRegex("\b")]
	private static partial Regex FiveCharWord { get; }
}