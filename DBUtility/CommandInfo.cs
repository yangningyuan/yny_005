using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace DBUtility
{
    public enum EffentNextType
    {
        /// <summary>
        /// ������������κ�Ӱ�� 
        /// </summary>
        None,
        /// <summary>
        /// ��ǰ������Ϊ"select count(1) from .."��ʽ��������������ִ�У������ڻع�����
        /// </summary>
        WhenHaveContine,
        /// <summary>
        /// ��ǰ������Ϊ"select count(1) from .."��ʽ����������������ִ�У����ڻع�����
        /// </summary>
        WhenNoHaveContine,
        /// <summary>
        /// ��ǰ���Ӱ�쵽�������������0������ع�����
        /// </summary>
        ExcuteEffectRows,
        /// <summary>
        /// �����¼�-��ǰ������Ϊ"select count(1) from .."��ʽ����������������ִ�У����ڻع�����
        /// </summary>
        SolicitationEvent
    }
    public class CommandInfo
    {
        public object ShareObject = null;
        public object OriginalData = null;
        event EventHandler _solicitationEvent;
        public event EventHandler SolicitationEvent
        {
            add
            {
                _solicitationEvent += value;
            }
            remove
            {
                _solicitationEvent -= value;
            }
        }
        public void OnSolicitationEvent()
        {
            if (_solicitationEvent != null)
            {
                _solicitationEvent(this, new EventArgs());
            }
        }
        public string CommandText;
        public System.Data.Common.DbParameter[] Parameters;
        public EffentNextType EffentNextType = EffentNextType.None;
        public CommandInfo()
        {

        }
        public CommandInfo(string sqlText, SqlParameter[] para)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
        }
        public CommandInfo(string sqlText, SqlParameter[] para, EffentNextType type)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
            this.EffentNextType = type;
        }
    }
    public class LogHelper
    {
        public static string GetAppBaseDirctory()
        {

            string path = string.Empty;
            if (System.Environment.CurrentDirectory == AppDomain.CurrentDomain.BaseDirectory)
            {
                //WindowsӦ�ó��������
                path = AppDomain.CurrentDomain.BaseDirectory;
            }
            else
            {

                // path = AppDomain.CurrentDomain.BaseDirectory + "Bin/";
                path = AppDomain.CurrentDomain.BaseDirectory;
            }
            return path;
        }

        //����վ��Ŀ¼�´�����־Ŀ¼
        public static string path = GetAppBaseDirctory() + "log/";

        //������
        public static object objlock = new object();

        public static void Log(string type, string content, string filename = null)
        {
            StringBuilder strbuid = new StringBuilder();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (string.IsNullOrEmpty(filename))
            {
                filename = string.Format("{0}/{1}.log", path, DateTime.Now.ToString("yyyyMMdd"));
            }
            else
            {
                try
                {
                    if (new FileInfo(path + filename).Length > 1024 * 1024 * 5)
                    {
                        int num = filename.LastIndexOf('_');
                        if (num < 0)
                        {
                            filename = string.Format("{0}_{1}.log", filename.Substring(0, filename.LastIndexOf('.')), 1);
                        }
                        else
                        {
                            filename = string.Format("{0}_{1}.log", filename.Substring(0, filename.LastIndexOf('.')), num++);
                        }
                    }
                    else
                    {
                        filename = string.Format("{0}/{1}.log", path, filename);
                    }
                }
                catch
                {
                    filename = string.Format("{0}/{1}.log", path, filename);
                }
            }

            strbuid.AppendFormat("\r\n================{0}========{1}========\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), type);
            strbuid.AppendFormat(" {0}\r\n", content);
            lock (objlock)
            {
                StreamWriter sw = new StreamWriter(filename, true);
                sw.Write(strbuid.ToString());
                sw.Close();
            }
        }
    }
}
