using NUnit.Framework;
public class NotGateTests
{
    [TestCase(true, false)]
    [TestCase(false, true)]
    public void NotGate_TablaDeVerdad(bool value, bool expectedResult)
    {
        ILogicValue input;
        ILogicValue expected;

        if (value)
        {
            input = new TrueValue();
        }
        else
        {
            input = new FalseValue();
        }

        if (expectedResult)
        {
            expected = new TrueValue();
        }
        else
        {
            expected = new FalseValue();
        }

        
        IGate notGate = new NotGate(input);

        Assert.That(notGate.Output, Is.EqualTo(expected.Value));
    }
}