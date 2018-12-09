using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yny_005.BLL
{
	public class OperationRecordBLL
	{
		public static void Add(string mid, string opeartionType, string opeartion, params object[] args)
		{
			Model.OperationRecord entity = new Model.OperationRecord();
            var member = BLL.Member.GetModelByMID(mid);
			entity.MID = mid;
			entity.LevelCode = member.AgencyCode;
			entity.RoleCode = member.RoleCode;
			entity.Time = DateTime.Now;
			entity.Type = opeartionType;
			entity.Operation = string.Format(opeartion, args);
			DAL.OperationRecordDAL.Add(entity);
		}

		/// <summary>
		/// 分页查询
		/// </summary>
		/// <param name="query"></param>
		/// <param name="pageIndex"></param>
		/// <param name="pageSize"></param>
		/// <param name="totalCount"></param>
		/// <returns></returns>
		public static IEnumerable<Model.OperationRecord> QueryByPage(Model.QueryOperationRecord query, int pageIndex, int pageSize, out int totalCount)
		{
			return DAL.OperationRecordDAL.QueryByPage(query, pageIndex, pageSize, out totalCount);
		}

        public static List<Model.Member_OperationRecord> GetList(string strWhere, int pageIndex, int pageSize, out int count)
        {
            return DAL.Member_OperationRecord.GetList(strWhere, pageIndex, pageSize, out count);
        }
    }
}
