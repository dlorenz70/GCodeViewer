using System;


namespace gcodeparser
{
    internal class CommandM: BaseCommand
    {
        public override void Parse()
        {
            int mType = GCodeParser.ParseInt();

            switch (mType)
            {
                case -1: Logger.Info("M: no command"); return;
                case 0:  Logger.Info("M00: PAUSE"); return;
                case 1:  Logger.Info("M01: PAUSE if the stop switch is ON"); return;
                case 2:  Logger.Info("M02: END PROGRAM"); return;
                
                case 3:  Logger.Info("M03: Start spindle (clockwise)"); return;
                case 4:  Logger.Info("M04: Start spindle (counterclockwise)"); return;
                case 5:  Logger.Info("M05: Stop spindle"); return;

                case 6: Logger.Info("M06: Stop spindle and CHANGE TOOL (current tool index)"); return;
                    
                case 30: Logger.Info("M30: PROGRAM FINISH"); return;
                case 60: Logger.Info("M60: PAUSE to exchange pallet shuttles"); return;

                default:
                    Logger.Info("M: Unsupported: {0}", mType);
                    break;
            }
        }
    }
}
