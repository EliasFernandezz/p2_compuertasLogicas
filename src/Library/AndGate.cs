public class AndGate : IGate{
    public ILogicValue Input1 { get; }
    public ILogicValue Input2 { get; }

    public bool Output{
        get{
            if (this.Input1.get() && this.Input2.get()) {
                return true;
            }
            else{
                return false;
            }
        }
    }
}