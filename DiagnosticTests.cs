namespace xunit3_diagnostic;

public class DiagnosticTests
{
    [Fact]
    public void TestDiagnosticOutput()
    {
        TestContext.Current.SendDiagnosticMessage("hello xunit3 world");
        Assert.True(true);
    }
}
