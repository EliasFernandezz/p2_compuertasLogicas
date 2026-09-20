public class GateOutput : ILogicValue{
    public bool Value {get;}
    public IGate EmitterGate{get;}

    public GateOutput(IGate emitterGate){
        this.EmitterGate = emitterGate;
        this.Value = this.EmitterGate.Output;
    }
}