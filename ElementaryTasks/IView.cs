namespace ElementaryTasks
{
    public interface IView
    {
        void ShowErrorMessage(string text);
        void ShowInstruction(string text);
        void ShowSurface(ISurface surface);
        string[] ReInput();
    }
}