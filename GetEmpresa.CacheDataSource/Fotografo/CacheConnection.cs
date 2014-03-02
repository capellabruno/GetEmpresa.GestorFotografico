using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;


namespace GetEmpresa.CacheDataSource.Fotografo
{
    public class CacheConnection
    {
        protected MySqlCommand _command;
        protected MySqlConnection _connection;
        protected MySqlDataAdapter _adp;
        private string _connectionString;

        public CacheConnection()
        {
            if (ConfigurationManager.ConnectionStrings["GestorConnection"] == null)
                throw new Exception("DataBase Cache Configuration Not Load.");

            _connectionString = ConfigurationManager.ConnectionStrings["GestorConnection"].ToString();

        }

        private void OpenConnection()
        {
            _connection = new MySqlConnection(_connectionString);

            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("DataBase Connection Closed.", ex);
            }
        }

        private void CloseConnetion()
        {
            if (_adp != null)
            {
                _adp.Dispose();
                _adp = null;
            }


            if (_command != null)
            {
                _command.Dispose();
                _command = null;
            }

            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }

        public System.Data.DataTable GetData(string _tableName)
        {

            try
            {
                DataTable _table = new DataTable(_tableName);
                this.OpenConnection();

                _command = new MySqlCommand();

                _command.CommandText = "SELECT * FROM " + _tableName;
                _command.CommandTimeout = 90000;
                _command.CommandType = CommandType.Text;
                _command.Connection = this._connection;
                _table.Load(_command.ExecuteReader());
                return _table;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                this.CloseConnetion();
            }
        }

        public System.Data.DataTable[] GetAllData()
        {
            try
            {
                this.OpenConnection();

                _command = new MySqlCommand();

                _command.CommandText = "show tables";
                _command.CommandTimeout = 90000;
                _command.CommandType = CommandType.Text;
                _command.Connection = this._connection;


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                this.CloseConnetion();
            }
        }

        public List<string> ExistsModificateData()
        {
            return null;
        }

        public void SetUpdateData(string _tableName) { }

    }
}
