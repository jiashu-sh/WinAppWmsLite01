using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HamsterCode.DataBaseCommon
{
    public interface IDbHelper
    {
        string GetConnectionString();
        /// <summary>
        /// 执行 Transact-SQL 语句并返回受影响的行数。
        /// </summary>
        int ExecuteNonQuery(string cmdText);

        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        object ExecuteScalar(string cmdText);

        /// <summary>
        /// 在事务中执行查询，返回DataSet
        /// </summary>
        DataSet ExecuteDataSet(string cmdText);

        DataTable ExecuteDataTable(string cmdText);

        DataRow ExecuteDataRow(string cmdText);
    }
}
