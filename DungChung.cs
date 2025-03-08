using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DungChung
{
    private string connectionString;
    private SqlConnection connection;

    public DungChung()
    {
        connectionString = "Server=localhost;Database=btl_winforms;Trusted_Connection=True;";
        connection = new SqlConnection(connectionString);
    }

    // Phương thức mở kết nối
    public void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    // Phương thức đóng kết nối
    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    // Phương thức tạo SqlDataAdapter
    public DataTable GetDataTable(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            OpenConnection();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                adapter.Fill(dt);

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return dt;
    }


    // Phương thức thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
    public int ExecuteNonQuery(string query)
    {
        int rowsAffected = 0;
        try
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return rowsAffected;
    }

    public void LoadDataToGridView(string query, DataGridView dgv)
    {
        try
        {
            DataTable dt = GetDataTable(query);
            dgv.DataSource = dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.Message);
        }
    }
}
