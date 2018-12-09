using System;
namespace yny_005.Model
{
    /// <summary>
    /// Member_OperationRecord:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Member_OperationRecord
    {
        public Member_OperationRecord()
        { }
        #region Model
        private int _id;
        private string _mid;
        private string _levelcode;
        private string _rolecode;
        private DateTime _time;
        private string _typecode;
        private string _operation;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MID
        {
            set { _mid = value; }
            get { return _mid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LevelCode
        {
            set { _levelcode = value; }
            get { return _levelcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RoleCode
        {
            set { _rolecode = value; }
            get { return _rolecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Time
        {
            set { _time = value; }
            get { return _time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeCode
        {
            set { _typecode = value; }
            get { return _typecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Operation
        {
            set { _operation = value; }
            get { return _operation; }
        }
        #endregion Model

    }
}

