using System.Data;
using System.Data.OleDb;

namespace ConsoleApp2;

public class Fonction
{
    //public static void InsertData(string file, string worksheet, string data)
    public static void InsertData(string file, string worksheet)
    {
        DataSet ds = new DataSet();
        
        string connectionString = Initialisation.GetConnectionString(file);

        using (OleDbConnection conn = new OleDbConnection(connectionString))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            
            cmd.CommandText = "Insert into [" + worksheet + "] (id, name,description) values('4' ,'coucou','jetestejusteuntruc')";

            
            DataTable dt = new DataTable();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            
            ds.Tables.Add(dt);
            
            cmd = null;
            conn.Close();
        }
        return;
    }
    
    public static void PrintSelectedData(string file, string worksheet)
    {
        DataSet ds = new DataSet();
        
        string connectionString = Initialisation.GetConnectionString(file);

        using (OleDbConnection conn = new OleDbConnection(connectionString))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            
            cmd.CommandText = "Insert into [" + worksheet + "] (name, description) values('coucou','jetestejusteuntruc')";

            
            DataTable dt = new DataTable();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            
            ds.Tables.Add(dt);
            
            cmd = null;
            conn.Close();
        }
        return;
    }
    
}