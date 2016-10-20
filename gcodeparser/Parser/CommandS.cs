﻿using System;


namespace gcodeparser
{
    // Set Spindle Speed
    internal class CommandS: BaseCommand
    {
        public int SpindleSpeed = -1;

        public override void Parse()
        {
            SpindleSpeed = GCodeParser.ParseInt();

            Logger.Info("S: SetSpindleSpeed: {0}", SpindleSpeed);
        }
    }

}
