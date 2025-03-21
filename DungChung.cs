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
        connectionString = "Data Source=192.168.1.235,1433;Initial Catalog=master;User ID=sa;Password=CJnEmigeG!@JLipcRy4&2MNv;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        connection = new SqlConnection(connectionString);
    }

    public string getConnectionString() { return connectionString; }

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


    // Thêm sửa xóa
    //public bool ExecuteNonQuery(string query, object[] parameter = null)
    //{
    //    int data = 0;
    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        connection.Open();
    //        SqlCommand command = new SqlCommand(query, connection);
    //        if (parameter != null)
    //        {
    //            string[] listParams = query.Split(' ');

    //            int i = 0;
    //            foreach (string item in listParams)
    //            {
    //                if (item.Contains('@'))
    //                {
    //                    command.Parameters.AddWithValue(item, parameter[i]);
    //                    i++;
    //                }
    //            }
    //        }

    //        data = command.ExecuteNonQuery();
    //        connection.Close();
    //    }
    //    return data > 0;
    //}

    // lấy danh sách
    public DataTable ExecuteQuery(string query, object[] parameter = null)
    {
        DataTable data = new DataTable();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listParams = query.Split(' ');

                int i = 0;
                foreach (string item in listParams)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
        }

        return data;
    }

    public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
    {
        int rowsAffected = 0;
        try
        {
            OpenConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                rowsAffected = command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw; // Giúp debug dễ hơn
        }
        finally
        {
            CloseConnection();
        }
        return rowsAffected;
    }


    //public int ExecuteNonQuery(string query)
    //{
    //    int rowsAffected = 0;
    //    try
    //    {
    //        OpenConnection();
    //        SqlCommand command = new SqlCommand(query, connection);
    //        rowsAffected = command.ExecuteNonQuery();
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Lỗi: " + ex.Message);
    //    }
    //    finally
    //    {
    //        CloseConnection();
    //    }
    //    return rowsAffected;
    //}
    public int ExecuteScalar(string query)
    {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }
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
