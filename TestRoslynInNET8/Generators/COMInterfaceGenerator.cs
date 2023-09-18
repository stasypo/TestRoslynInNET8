using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace TestRoslynInNET8.Generators;

[GeneratedComInterface]
[Guid("5401c312-ab23-4dd3-aa40-3cb4b3a4683e")]
interface IComInterface
{
    void DoWork();
    void RegisterCallbacks(ICallbacks callbacks);
}

[GeneratedComInterface]
[Guid("88470b56-aabc-46af-bf97-8106a1aa3cf9")]
interface ICallbacks
{
    void Callback();
}

internal partial class MyNativeLib
{
    [LibraryImport(nameof(MyNativeLib))]
    public static partial void GetComInterface(out IComInterface comInterface);
}

[GeneratedComClass]
internal class MyCallbacks : ICallbacks
{
    public void Callback()
    {
        Console.WriteLine("Callback called");
    }
}

public class RunClass()
{
    public static void RunMethod()
    {
        MyNativeLib.GetComInterface(out IComInterface comInterface);
        comInterface.RegisterCallbacks(new MyCallbacks());
        comInterface.DoWork();
    }
}