using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.TaskInfo
{
    static class TaskSetting
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

        private static string _insertPtInstData;
        public static string insertPtInstData
        {
            get { return _insertPtInstData; }
            set { _insertPtInstData = value; }
        }

        private static string _insertPtSymTyp;
        public static string insertPtSymTyp
        {
            get { return _insertPtSymTyp; }
            set { _insertPtSymTyp = value; }
        }
        

    }
}
