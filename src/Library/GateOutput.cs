public class GateOutput : ILogicValue{
    public bool Value {get;}
    public IGate EmitterGate{get;}

    public TrueValue(){
        this.Value = this.EmitterGate.Output();
    }
}