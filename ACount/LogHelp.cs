using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;

namespace Tools.Log
{
    /// <summary>
    /// ���̰߳�ȫLog��¼����20180314
    /// Tools.Log.LogHelper.LogFlag = true; //������¼
   ///Tools.Log.LogHelper.LogInfo("==========��־��¼���� Info====");     
   ///Tools.Log.LogHelper.LogWarn("==========��־��¼���� Warn====");
   ///Tools.Log.LogHelper.LogError("==========��־��¼���� Error====");
   //Tools.Log.LogHelper.LogFlag = false;//ֹͣ��¼
   ///Tools.Log.LogHelper.ExitThread();// �˳���־��¼�̣߳�һ���ڳ����˳�ʱ����á�
    /// </summary>
    public class LogHelper
    {
        //Ϊ��ʹ��DBGView�������ߵ��ԣ�
        //System.Diagnostics.Debug.WriteLine("Debugģʽ�ɼ�")
        //System.Diagnostics.Trace.WriteLine("Debug��Release���ɼ�");

        private static  Thread WriteThread;
        private static readonly Queue<string> MsgQueue;

        private static readonly string FilePath;

        private static Boolean autoResetEventFlag = false;
        private static AutoResetEvent aEvent = new AutoResetEvent(false);
        private static bool flag = true;
        public static bool LogFlag = true;

        static LogHelper()
        {
            FilePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "App_Log\\";
            WriteThread = new Thread(WriteMsg);
            MsgQueue = new Queue<string>();
            WriteThread.Start();
        }

        public static void LogInfo(string msg)
        {
            Monitor.Enter(MsgQueue);
            MsgQueue.Enqueue(string.Format("{0} {1} {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss"), "Info", msg));
            Monitor.Exit(MsgQueue);
            if (autoResetEventFlag) {
                aEvent.Set();
            }
        }
        public static void LogError(string msg)
        {
            Monitor.Enter(MsgQueue);
            MsgQueue.Enqueue(string.Format("{0} {1} {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss"), "Error", msg));
            Monitor.Exit(MsgQueue);
            if (autoResetEventFlag)
            {
                aEvent.Set();
            }
        }
        public static void LogWarn(string msg)
        {
            Monitor.Enter(MsgQueue);
            MsgQueue.Enqueue(string.Format("{0} {1} {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss"), "Warn", msg));
            Monitor.Exit(MsgQueue);
            if (autoResetEventFlag)
            {
                aEvent.Set();
            }
        }

        /// <summary>
        /// ExitThread���˳���־��¼�̵߳ķ�����һ���˳����޷�������һ���ڳ���ر�ʱִ��
        /// </summary>
        public static void ExitThread() {
            flag = false;
            aEvent.Set();//�ָ��߳�ִ��
        }
        private static void WriteMsg()
        {
            while (flag)
            {
                //���м�¼
                if (LogFlag)
                {
                    autoResetEventFlag = false;
                    if (!Directory.Exists(FilePath))
                    {
                        Directory.CreateDirectory(FilePath);
                    }
                    string fileName = FilePath + DateTime.Now.ToString("yyyy-MM-dd") + "-Dic.log";
                    var logStreamWriter = new StreamWriter(fileName, true);
                    while (MsgQueue.Count > 0)
                    {
                        Monitor.Enter(MsgQueue);
                        string msg = MsgQueue.Dequeue();
                        Monitor.Exit(MsgQueue);
                        logStreamWriter.WriteLine(msg);
                        if (GetFileSize(fileName) > 1024 * 5)
                        {
                            logStreamWriter.Flush();
                            logStreamWriter.Close();
                            CopyToBak(fileName);
                            logStreamWriter = new StreamWriter(fileName, false);
                            logStreamWriter.Write("");
                            logStreamWriter.Flush();
                            logStreamWriter.Close();
                            logStreamWriter = new StreamWriter(fileName, true);
                        }
                        //��������DbgView.exe���߽������ߵ���
                        System.Diagnostics.Debug.WriteLine("BS_Debug:"+msg);
                        System.Diagnostics.Trace.WriteLine("BS_Release:" + msg);
                    }
                    logStreamWriter.Flush();
                    logStreamWriter.Close();
                    autoResetEventFlag = true;
                    aEvent.WaitOne();
                }
                else {
                    autoResetEventFlag = true;
                    aEvent.WaitOne();
                }
            }
        }
        private static long GetFileSize(string fileName)
        {
            long strRe = 0;
            if (File.Exists(fileName))
            {
                var myFs=new FileInfo(fileName);
                strRe = myFs.Length / 1024;
                //Console.WriteLine(strRe);
            }
            return strRe;
        }
        private static void CopyToBak(string sFileName)
        {
            int fileCount = 0;
            string sBakName = "";
            do
            {
                fileCount++;
                sBakName = sFileName + "." + fileCount + ".BAK";
            }
            while (File.Exists(sBakName));
            File.Copy(sFileName, sBakName);
        }
    }
}