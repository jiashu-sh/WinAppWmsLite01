using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.LocationMgt
{
    class BizLocationView
    {
        public static DataSet initEmptyWarehouseGraphicsDS()
        {
            const string DS_WH_GRAPHICS = "DSNAME_WH_GRAPHICS";
            const string DT_WH_GRAPHICS = "DT_WH_GRAPHICS";

            DataSet dsRFOrder = new DataSet(DS_WH_GRAPHICS);
            //---------------------------------------------------------//
            //----------------------DS_WH_GRAPHICS--------------------//

            dsRFOrder.Tables.Add(DT_WH_GRAPHICS);

            System.Data.DataColumn addColumn;

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.String");
            addColumn.ColumnName = "AreaNo";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.String");
            addColumn.ColumnName = "LaneNo";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.String");
            addColumn.ColumnName = "ShelfNo";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "StorageType";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.String");
            addColumn.ColumnName = "LaneDirection";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.String");
            addColumn.ColumnName = "LaneOrder";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "LocationCount";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "Layer";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "IsHold";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "LanePointX";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "LanePointY";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "XPointS";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "YPointS";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "XPointE";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            addColumn = new System.Data.DataColumn();
            addColumn.DataType = System.Type.GetType("System.Int16");
            addColumn.ColumnName = "YPointE";
            dsRFOrder.Tables[DT_WH_GRAPHICS].Columns.Add(addColumn);

            //-------------------------------------------------------//
            return dsRFOrder;
        }
    }
}
