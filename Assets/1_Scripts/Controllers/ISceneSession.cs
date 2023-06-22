namespace MBS.Controller
{
    public interface ISceneSession
    {
        protected void StartScene();
        protected void RunningScene();
        protected void EndScene();
    }
}