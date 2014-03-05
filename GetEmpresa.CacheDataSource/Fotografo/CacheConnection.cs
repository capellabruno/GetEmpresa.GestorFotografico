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
    public class CacheConnection : GetEmpresa.CacheDataSource.Fotografo.ICacheConnection
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

                DataTable _datableResult = new DataTable("Result");
                _datableResult.Load(_command.ExecuteReader());

                List<DataTable> _retorno = new List<DataTable>();

                foreach (DataRow row in _datableResult.Rows)
                {
                    DataTable dt;

                    dt = this.GetData(row[0].ToString());

                    _retorno.Add(dt);
                }
                return _retorno.ToArray();
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
            try
            {                
                this.OpenConnection();

                _command = new MySqlCommand();

                _command.CommandText = "SELECT distinct `Table` FROM updateondatabase WHERE UpdateSystem = 0";
                _command.CommandTimeout = 90000;
                _command.CommandType = CommandType.Text;
                _command.Connection = this._connection;
               

                DataTable _table = new DataTable("Result");
                _table.Load(_command.ExecuteReader());

                List<String> _retorno = new List<string>();

                foreach (DataRow row in _table.Rows)
                    _retorno.Add(row[0].ToString());

                return _retorno;
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

        public void SetUpdateDataOnUpdate(string _tableName) {
            try
            {
                DataTable _table = new DataTable(_tableName);
                this.OpenConnection();

                _command = new MySqlCommand();

                _command.CommandText = "update updateondatabase set UpdateSystem=1 where `Table` ='" + _tableName + "' and UpdateSystem = 0";
                _command.CommandTimeout = 90000;
                _command.CommandType = CommandType.Text;
                _command.Connection = this._connection;
                _command.ExecuteNonQuery();
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

        public void InsertControlDataOnUpdate(string _tableName)
        {
            try
            {
                DataTable _table = new DataTable(_tableName);
                this.OpenConnection();

                _command = new MySqlCommand();

                _command.CommandText = "insert into updateondatabase (`Table`) values ('" + _tableName + "')";
                _command.CommandTimeout = 90000;
                _command.CommandType = CommandType.Text;
                _command.Connection = this._connection;
                _command.ExecuteNonQuery();
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

    }
}
