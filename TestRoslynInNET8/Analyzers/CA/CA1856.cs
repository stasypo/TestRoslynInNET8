using System.Diagnostics.CodeAnalysis;

namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1856: Pass constants to parameters marked as [ConstantExpected]
 * Default severity: Error
 * Category: Performance
 * Quick fix: no
 */
public sealed class CA1856
{
    // EXPECTED: error highlighting on [ConstantExpected(...)]
    public static void MyInvalidUshort([ConstantExpected(Min = -5, Max = -1)] ushort b) { }
    // EXPECTED: error highlighting on [ConstantExpected(...)]
    public static void MyInvalidRange([ConstantExpected(Min = 5, Max = -5)] int b) { }
    public static void MyBool1([ConstantExpected] bool b) { }
    public static void MyLong1([ConstantExpected] long b) { }
    public static void MyLong2([ConstantExpected(Min = -5, Max = 10)] long b) { }
    public static void MyFloat1([ConstantExpected] float b) { }
    public static void MyFloat2([ConstantExpected(Min = -5.3f, Max = 10.1f)] float b) { }

}
