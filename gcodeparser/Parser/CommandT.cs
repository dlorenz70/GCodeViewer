﻿using System;


namespace gcodeparser
{
    internal class CommandT: BaseCommand
    {
        public int ToolIndex = -1;

        public override void Parse()
        {
            ToolIndex = GCodeParser.ParseInt();

            Logger.Info("T: Select tool: {0}", ToolIndex);
        }
    }
}
