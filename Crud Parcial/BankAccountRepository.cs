using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Parcial
{
    public class BankAccountRepository
    {
        public List<Bank> ObtenerTodos()
        {
            using (var conexion = Datos.GetSqlConnection())
            {
                String selectFrom = "";
                selectFrom = selectFrom + "SELECT [AccountID] " + "\n";
                selectFrom = selectFrom + "      ,[AccountHolderName] " + "\n";
                selectFrom = selectFrom + "      ,[AccountNumber] " + "\n";
                selectFrom = selectFrom + "      ,[AccountType] " + "\n";
                selectFrom = selectFrom + "      ,[Balance] " + "\n";
                selectFrom = selectFrom + "      ,[CreationDate] " + "\n";
                selectFrom = selectFrom + "  FROM [dbo].[BankAccount]";

                using (SqlCommand comando = new SqlCommand(selectFrom, conexion))
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    List<Bank> accounts = new List<Bank>();

                    while (reader.Read())
                    {
                        var account = LeerDelDataReader(reader);
                        accounts.Add(account);
                    }
                    return accounts;
                }
            }
        }

        public Bank ObtenerPorID(int id)
        {
            using (var conexion = Datos.GetSqlConnection())
            {
                String selectForID = "";
                selectForID = selectForID + "SELECT [AccountID] " + "\n";
                selectForID = selectForID + "      ,[AccountHolderName] " + "\n";
                selectForID = selectForID + "      ,[AccountNumber] " + "\n";
                selectForID = selectForID + "      ,[AccountType] " + "\n";
                selectForID = selectForID + "      ,[Balance] " + "\n";
                selectForID = selectForID + "      ,[CreationDate] " + "\n";
                selectForID = selectForID + "  FROM [dbo].[BankAccount] " + "\n";
                selectForID = selectForID + "  WHERE AccountID = @AccountID";

                using (SqlCommand comando = new SqlCommand(selectForID, conexion))
                {
                    comando.Parameters.AddWithValue("@AccountID", id);
                    SqlDataReader reader = comando.ExecuteReader();
                    Bank account = null;

                    if (reader.Read())
                    {
                        account = LeerDelDataReader(reader);
                    }
                    return account;
                }
            }
        }

        public Bank LeerDelDataReader(SqlDataReader reader)
        {
            Bank account = new Bank();
            account.AccountID = reader["AccountID"] == DBNull.Value ? 0 : (int)reader["AccountID"];
            account.AccountHolderName = reader["AccountHolderName"] == DBNull.Value ? "" : (string)reader["AccountHolderName"];
            account.AccountNumber = reader["AccountNumber"] == DBNull.Value ? "" : (string)reader["AccountNumber"];
            account.AccountType = reader["AccountType"] == DBNull.Value ? "" : (string)reader["AccountType"];
            account.Balance = reader["Balance"] == DBNull.Value ? 0 : (decimal)reader["Balance"];
            account.CreationDate = reader["CreationDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["CreationDate"];
            return account;
        }

        public int InsertarCuenta(Bank account)
        {
            using (var conexion = Datos.GetSqlConnection())
            {
                String insertInto = "";
                insertInto = insertInto + "INSERT INTO [dbo].[BankAccount] " + "\n";
                insertInto = insertInto + "           ([AccountHolderName] " + "\n";
                insertInto = insertInto + "           ,[AccountNumber] " + "\n";
                insertInto = insertInto + "           ,[AccountType] " + "\n";
                insertInto = insertInto + "           ,[Balance] " + "\n";
                insertInto = insertInto + "           ,[CreationDate]) " + "\n";
                insertInto = insertInto + "     VALUES " + "\n";
                insertInto = insertInto + "           (@AccountHolderName " + "\n";
                insertInto = insertInto + "           ,@AccountNumber " + "\n";
                insertInto = insertInto + "           ,@AccountType " + "\n";
                insertInto = insertInto + "           ,@Balance " + "\n";
                insertInto = insertInto + "           ,@CreationDate)";

                using (var comando = new SqlCommand(insertInto, conexion))
                {
                    int insertados = ParametrosCuenta(account, comando);
                    return insertados;
                }
            }
        }

        public int ActualizarCuenta(Bank account)
        {
            using (var conexion = Datos.GetSqlConnection())
            {
                String actualizarCuentaPorID = "";
                actualizarCuentaPorID = actualizarCuentaPorID + "UPDATE [dbo].[BankAccount] " + "\n";
                actualizarCuentaPorID = actualizarCuentaPorID + "   SET [AccountHolderName] = @AccountHolderName " + "\n";
                actualizarCuentaPorID = actualizarCuentaPorID + "      ,[AccountType] = @AccountType " + "\n";
                actualizarCuentaPorID = actualizarCuentaPorID + " WHERE AccountID = @AccountID";

                using (var comando = new SqlCommand(actualizarCuentaPorID, conexion))
                {
                    // Añadir los parámetros necesarios desde el objeto account
                    comando.Parameters.AddWithValue("@AccountID", account.AccountID);
                    comando.Parameters.AddWithValue("@AccountHolderName", account.AccountHolderName);
                    comando.Parameters.AddWithValue("@AccountType", account.AccountType);
                    int filasActualizadas = comando.ExecuteNonQuery();
                    return filasActualizadas;
                }
            }
        }

        public int ActualizarBalance(Bank account)
        {
            using (var conexion = Datos.GetSqlConnection())
            {
                string actualizarBalancePorID = "";
                actualizarBalancePorID = actualizarBalancePorID + "UPDATE [dbo].[BankAccount] " + "\n";
                actualizarBalancePorID = actualizarBalancePorID + "   SET [Balance] = @Balance " + "\n";
                actualizarBalancePorID = actualizarBalancePorID + " WHERE [AccountID] = @AccountID";

                using (var comando = new SqlCommand(actualizarBalancePorID, conexion))
                {
                    // Añadir los parámetros necesarios desde el objeto account
                    comando.Parameters.AddWithValue("@AccountID", account.AccountID);
                    comando.Parameters.AddWithValue("@Balance", account.Balance);

                    // Ejecutar la consulta y devolver el número de filas afectadas
                    int filasActualizadas = comando.ExecuteNonQuery();

                    return filasActualizadas;
                }
            }
        }

        public int ParametrosCuenta(Bank account, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("AccountHolderName", account.AccountHolderName);
            comando.Parameters.AddWithValue("AccountNumber", account.AccountNumber);
            comando.Parameters.AddWithValue("AccountType", account.AccountType);
            comando.Parameters.AddWithValue("Balance", account.Balance);
            comando.Parameters.AddWithValue("CreationDate", account.CreationDate);
            var result = comando.ExecuteNonQuery();
            return result;
        }

        public int EliminarCuenta(int id)
        {
            using (var conexion = Datos.GetSqlConnection())
            {
                String eliminarCuenta = "";
                eliminarCuenta = eliminarCuenta + "DELETE FROM [dbo].[BankAccount] " + "\n";
                eliminarCuenta = eliminarCuenta + "      WHERE AccountID = @AccountID";
                using (SqlCommand comando = new SqlCommand(eliminarCuenta, conexion))
                {
                    comando.Parameters.AddWithValue("@AccountID", id);
                    int eliminados = comando.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la cuenta...");
                    return eliminados;
                }
            }
        }
    }

}
