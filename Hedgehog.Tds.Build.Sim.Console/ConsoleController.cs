﻿using System.Collections.Generic;
using System.Diagnostics;

using SIM.Pipelines;

namespace Hedgehog.Tds.Build.Sim.Console
{
    public class ConsoleController : IPipelineController
    {
        public void Start(string replaceHere, List<Step> steps)
        {
            System.Console.WriteLine("SIM: Operation Started : " + replaceHere);
        }

        public void SetProgress(long progress)
        {
        }

        public void IncrementProgress(long progress)
        {
        }

        public void Finish(string message, bool closeInterface)
        {
            System.Console.WriteLine("SIM:  Operation Finished : " + message);
        }

        public void ProcessorCrashed(string error)
        {
            System.Console.WriteLine("SIM:  Processor Crashed : " + error);
        }

        public void ProcessorDone(string title)
        {
            System.Console.WriteLine("SIM:  Processor Done : " + title);
        }

        public void ProcessorSkipped(string processorName)
        {
            System.Console.WriteLine("SIM: Processor Skipped : " + processorName);
        }

        public void ProcessorStarted(string title)
        {
            System.Console.WriteLine("SIM:  Processor Started : " + title);
        }

        public void Execute(string path, string args)
        {
            Process.Start(path, args);
        }

        public double Maximum { get; set; }

        public Pipeline Pipeline { get; set; }

        public void IncrementProgress()
        {
        }

        public void Pause()
        {
        }

        #region Not implemented - not important for this demo

        public string Ask(string title, string defaultValue)
        {
            return defaultValue;
        }

        public bool Confirm(string message)
        {
            return true;
        }

        public void Resume()
        {
        }

        public string Select(string message, IEnumerable<string> options, bool allowMultipleSelection,
            string defaultValue)
        {
            //throw new NotImplementedException();
            return defaultValue;
        }

        #endregion
    }
}