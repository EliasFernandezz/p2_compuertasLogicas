public class AndGate : IGate{
    public ILogicValue Input1{get;}

    public bool Output{
        get{
            return !this.Input1.get()
        }
    }
}