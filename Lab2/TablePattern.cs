using System.Data;

namespace TI2
{
    public static class TablePattern
    {
        public static DataView CreateTable(int X, int Y)
        {
            DataTable dt = new DataTable();
            DataRow row;
            DataColumn column;

            for (int i = 0; i < X - 1; i++)
            {
                column = new DataColumn();
                dt.Columns.Add(column);
            }

            dt.Columns.Add(new DataColumn("checked", typeof(bool)));

            for (int i = 0; i < Y; i++)
            {
                row = dt.NewRow();
                dt.Rows.Add(row);
            }

            return new DataView(dt);
        }
    }
}
