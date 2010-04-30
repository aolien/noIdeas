using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace NoIdeasServer.Lib
{
    /// <summary>
    /// This class allows to connect and performe queries on SLQ DB
    /// </summary>
    public class DataBaseWorker
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DataBaseWorker(string connectionString)
        {
            Initialize(connectionString);
        }

        /// <summary>
        /// SqlConnection object
        /// </summary>
        protected SqlConnection connection = null;

        /// <summary>
        /// Connection property
        /// </summary>
        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }


        /// <summary>
        /// Initialize the database connection property so commands can be executed.
        /// </summary>
        /// <param name="connectionString">The connection string for the desired server and database.</param>
        //   [MethodImpl(MethodImplOptions.Synchronized)]
        private bool Initialize(string connectionString)
        {
            bool result = false;
            if (Connection == null)
            {
                try
                {
                    Connection = new SqlConnection(connectionString);
                    Connection.Open();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (Connection != null)
                    {
                        Connection.Close();
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Executes the SQL query, returns a DataSet filled with query results.
        /// Database connection must be already initialized
        /// </summary>
        /// <param name="sql">Sql query</param>
        /// <returns>DataSet filled with query results</returns>
        public DataTable ExecuteSQL(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, Connection))
            {
                adapter.SelectCommand.CommandTimeout = 360;
                adapter.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// Insert, update, or delete a record in the database.
        /// Database connection must be already initialized
        /// </summary>
        /// <param name="sqlQuery">The SQL query to run against the database.</param>
        /// <returns>The number of rows affected by the operation.</returns>
        public int ExecuteSql(string sqlQuery)
        {
            int numRowsAffected;
            // Create and configure a command
            using (SqlCommand command = new SqlCommand(sqlQuery, Connection))
            {
                // The time in seconds to execute the command before the exception will be thrown
                command.CommandTimeout = 360;
                // Execute the command
                numRowsAffected = command.ExecuteNonQuery();

                // Dispose
                command.Dispose();
            }
            return numRowsAffected;
        }

        /// <summary>
        /// Opens the connection 
        /// </summary>
        public void OpenConnection()
        {
            Connection.Open();
        }

        /// <summary>
        /// Close the Connection
        /// </summary>
        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
