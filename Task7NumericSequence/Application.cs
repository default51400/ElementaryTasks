﻿using System;
using System.Configuration;
using System.Collections.Generic;

using SharedLibrary;

namespace Task7NumericSequence
{
    public class Application
    {
        private string[] _args;
        private IView _view;

        public Application()
        {
            _view = new SequenceUI();
        }

        public Application(IView view)
        {
            _view = view;
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
                if (Validator.IsValid(args))
                {
                    Sequence sequence = new NumericSequence(int.Parse(args[0]));
                    IEnumerable<int> sequenceCollection = sequence.GetSequenceCollection();

                    _view.ShowResult(sequence.GetStringSequence(sequenceCollection).ToString());
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _view.ShowErrorMessage(ex.Message);
                Run();
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
