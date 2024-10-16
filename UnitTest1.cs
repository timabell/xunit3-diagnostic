namespace xunit3_diagnostic;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        TestContext.Current.SendDiagnosticMessage("hello xunit3 world");
        Assert.True(true);
    }
}
