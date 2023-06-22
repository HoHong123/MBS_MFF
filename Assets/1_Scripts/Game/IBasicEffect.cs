namespace MBS.Controller.Game.Buff
{
    public interface IBasicEffect
    {
        public int ID { get; }
        public string Name { get; }

        public void Execute();
        public void Dismiss();
    }
}