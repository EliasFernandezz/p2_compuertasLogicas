public class AndGate : IGate{
    public ILogicValue Input1 { get; }
    public ILogicValue Input2 { get; }

    public bool Output{
        get{
            if (this.Input1.Value && this.Input2.Value) {
                return true;
            }
            else{
                return false;
            }
        }
    }

    public AndGate(ILogicValue input1, ILogicValue input2)
    {
        this.Input1 = input1;
        this.Input2 = input2;
    }
}