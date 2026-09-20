using NUnit.Framework;
public class AndGateTests
{
    [TestCase(true, true, true)]
    [TestCase(true, false, false)]
    [TestCase(false, true, false)]
    [TestCase(false, false, false)]
    public void AndGate_TablaDeVerdad(bool value1, bool value2, bool expectedResult)
    {
        ILogicValue input1;
        ILogicValue input2;
        ILogicValue expected;

        if (value1)
        {
            input1 = new TrueValue();
        }
        else
        {
            input1 = new FalseValue();
        }

        if (value2)
        {
            input2 = new TrueValue();
        }
        else
        {
            input2 = new FalseValue();
        }

        if (expectedResult)
        {
            expected = new TrueValue();
        }
        else
        {
            expected = new FalseValue();
        }

        
        IGate andGate = new AndGate(input1, input2);

        Assert.That(andGate.Output, Is.EqualTo(expected.Value));
    }
}