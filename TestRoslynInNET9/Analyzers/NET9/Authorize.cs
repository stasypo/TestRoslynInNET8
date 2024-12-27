using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestRoslynInNET9.Analyzers.NET9;

/*
 * ASP0026: [Authorize] overridden by [AllowAnonymous] from farther away
 * Default severity: warning
 * Category: Usage
 * Quick fix: not available
 */
[AllowAnonymous]
public class MyController
{
	[Authorize] // Overridden by the [AllowAnonymous] attribute on the class
	public IActionResult Private() => null;
}