namespace ElementaryTasks
{
    public interface IView
    {
        void ShowErrorMessage(string text);
        void ShowInstruction(string text);
        void ShowResult(IDraw ui);
    }
}