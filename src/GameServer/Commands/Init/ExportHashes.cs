﻿using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands 
    {
        static void ExportHashes()
        {
            #region exporthashes command

            Command exporthashesCommand = new Command("exporthashes", "exported ability hashes");

            exporthashesCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnExportHashes,UserRank.Console);

            ConsoleHandler.AddCommand(exporthashesCommand);

            #endregion
        }
    }
}
