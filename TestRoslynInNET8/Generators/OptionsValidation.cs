using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace TestRoslynInNET8.Generators;

public class FirstModelNoNamespace
{
    [Required]
    [MinLength(5)]
    public string P1 { get; set; } = string. Empty;

    [Microsoft.Extensions.Options.ValidateObjectMembers(typeof(SecondValidatorNoNamespace))]
    public SecondModelNoNamespace? P2 { get; set; }

    [Microsoft.Extensions.Options.ValidateObjectMembers]
    public ThirdModelNoNamespace? P3 { get; set; }
}

public class SecondModelNoNamespace
{
    [Required]
    [MinLength(5)]
    public string P4 { get; set; } = string. Empty;
}

public class ThirdModelNoNamespace
{
    [Required]
    [MinLength(5)]
    public string P5 { get; set; } = string.Empty;
}

// EXPECTED: OptionsValidator generated with a source generator is used
[OptionsValidator]
public partial class FirstValidatorNoNamespace : IValidateOptions<FirstModelNoNamespace>
{
    public ValidateOptionsResult Validate(string? name, FirstModelNoNamespace options)
    {
        throw new NotImplementedException();
    }
}

// EXPECTED: OptionsValidator generated with a source generator is used
[OptionsValidator]
public partial class SecondValidatorNoNamespace : IValidateOptions<SecondModelNoNamespace>
{
    public ValidateOptionsResult Validate(string? name, SecondModelNoNamespace options)
    {
        throw new NotImplementedException();
    }
}

