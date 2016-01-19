using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.TaskInfo
{
    class TaskSetting
    {
        private static string _InputFilePath;
        public static string InputFilePath
        {
            get { return _InputFilePath; }
            set { _InputFilePath = value; }
        }

        private static string _OutputFilePath;
        public static string OutputFilePath
        {
            get { return _OutputFilePath; }
            set { _OutputFilePath = value; }
        }

        

    }
}
