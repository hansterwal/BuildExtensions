﻿using System.Collections.Generic;

namespace Hedgehog.Tds.Build.Sim.Console
{
    public class InstallArgs : BaseArgsProcessor
    {
        public InstallArgs(IEnumerable<string> args) : base(args)
        {
        }

        public string HostName
        {
            get { return GetArg("HostName"); }
        }

        public string InstanceName
        {
            get { return GetArg("InstanceName"); }
        }

        public string InstanceDirectory
        {
            get { return GetArg("InstanceDirectory"); }
        }

        public string RepoDirectory
        {
            get { return GetArg("RepoDirectory"); }
        }

        public string RepoFile
        {
            get { return GetArg("RepoFile"); }
        }

        public string ConnectionString
        {
            get { return GetArg("ConnectionString"); }
        }

        public string AppPoolIdentity
        {
            get { return GetArg("AppPoolIdentity"); }
        }

        public string LicencePath
        {
            get { return GetArg("LicencePath"); }
        }

        public string Modules
        {
            get { return GetArg("Modules"); }
        }
    }
}