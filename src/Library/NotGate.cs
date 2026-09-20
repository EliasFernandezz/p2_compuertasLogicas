public class NotGate : IGate{
    public ILogicValue Input1{get;}

    public bool Output{
        get{
            return !this.Input1.Value;
        }
    }

    public NotGate(ILogicValue input1)
    {
        this.Input1 = input1;
    }
}