namespace TestRoslynInNET8.Generators;

public class ConfigurationBinderSourceGeneration
{
    internal void Configure(IConfiguration configuration) =>
        ConfigurationBinder.Bind(configuration: configuration, instance: this);
}