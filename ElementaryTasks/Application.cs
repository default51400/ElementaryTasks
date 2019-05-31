using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    public class Application
    {
        private string[] _args;
        private IView _view;
        private ISurface _board;

        public Application()
        {
            _view = new ConsoleView();
        }

        public virtual void Run()
        {
            _view.ShowInstruction(ConfigurationManager.AppSettings["Instruction"]);
            Run(_view.ReInput());
        }
        public virtual void Run(string[] args)
        {
            _args = (string[])args.Clone();
            try
            { 
                if (Validator.IsValid(_args, out int height, out int width))
                {
                    _board = new ChessBoard(height, width);
                    _view.ShowSurface(_board);
                }
            }
            catch (ArgumentException ex)
            {
                _view.ShowErrorMessage(ex.Message);
                Run();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage(ex.Message);
                Run();
            }
        }
    }
}
