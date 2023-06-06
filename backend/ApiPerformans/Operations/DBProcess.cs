using Oracle.ManagedDataAccess.Client;

public class DBProcess
{
    public DBProcess()
    {
    }

    public static bool Insert(string table, string[] columns, string[] values)
    {
        var result = false;
        try
        {
            DBConnection connObj = new();
            OracleCommand insertCommand = connObj.getCommand();
            var query = "INSERT INTO " + table + "(";
            for (int i = 0; i < columns.Length; i++)
            {
                query += columns[i];
                if (i != columns.Length - 1)
                {
                    query += ",";
                }
            }
            query += ") VALUES (";
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == "sysdate")
                {
                    query += values[i];
                }
                else
                    query += "'" + values[i] + "'";
                if (i != values.Length - 1)
                {
                    query += ",";
                }
            }
            query += ")";
            insertCommand.CommandText = query;
            connObj.openConnection();
            var dr = insertCommand.ExecuteNonQuery();
            if (dr > 0)
            {
                result = true;
            }
            connObj.closeConnection();
        }
        catch (Exception ex)
        {
            Console.WriteLine("--DBProcess-Insert : " + ex.Message);
        }
        return result;
    }

    public static int MaxIdBul(string table)
    {
        var id = 0;
        try
        {
            DBConnection connObj = new();
            OracleCommand selectCommand = connObj.getCommand();
            selectCommand.CommandText = @"SELECT MAX(ID)+1 AS ID FROM " + table;

            connObj.openConnection();
            OracleDataReader dr = selectCommand.ExecuteReader();

            if (dr.Read())
            {
                id = Convert.ToInt32(dr.GetValue(dr.GetOrdinal("ID")).ToString());
            }
            dr.Close();
            connObj.closeConnection();
        }
        catch (Exception ex)
        {
            Console.WriteLine("--DBProcess-MaxIdBul : " + ex.Message);
        }
        return id;
    }
}