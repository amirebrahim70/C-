 public static DataTable ConvertGridToDatatable(DataGridView grid)
        {
            var dt = new DataTable();
            var colsCount = grid.Columns.Count;
            for (int i = 0; i < colsCount; i++)
            {
                dt.Columns.Add(grid.Columns[i].Name);
            }
            var rowsCount = grid.Rows.Count;
            for (int j = 0; j <= rowsCount - 2; j++)
            {
                dt.Rows.Add();
                for (int k = 0; k < colsCount; k++)
                {
                    dt.Rows[j][k] = grid.Rows[j].Cells[k].Value.ToString();
                }
            }
            return dt;
        }
