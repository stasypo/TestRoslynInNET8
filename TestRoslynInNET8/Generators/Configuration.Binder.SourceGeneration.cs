namespace TestRoslynInNET8.Generators;

public class ConfigurationBinderSourceGeneration
{
    // EXPECTED: Bind method generated with a source generator is used
    internal void Configure(IConfiguration configuration) =>
        ConfigurationBinder.Bind(configuration: configuration, instance: this);
}