namespace TestRoslynInNET8.Analyzers.CA;
using static CA1856;

/*
 * CA1857: Pass constants to parameters marked as [ConstantExpected]
 * Default severity: Warning
 * Category: Performance
 * Quick fix: no
 */
public class CA1857
{
    public void TestMethod(long b, ushort u)
    {
        // EXPECTED: no special highlighting
        const long a = 10;
        MyLong1(a);
        MyLong2(a);
        MyLong1(1L);
        MyLong2(2L);
        MyInvalidUshort(1);
        const ushort us = 0;

        // EXPECTED: suggestion highlighting on `us` (not flagged in VS)
        MyInvalidUshort(us);

        // EXPECTED: suggestion highlighting on `b`
        MyLong1(b);

        // EXPECTED: suggestion highlighting on `b`
        MyLong2(b); 

        // EXPECTED: suggestion highlighting on `20`        
        MyLong2(20);

        // EXPECTED: suggestion highlighting on `u` (not flagged in VS)
        MyInvalidUshort(u);

        // EXPECTED: suggestion highlighting on `10` (not flagged in VS)
        MyInvalidUshort(10);
    }
}