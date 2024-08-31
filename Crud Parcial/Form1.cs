using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace Crud_Parcial
{
    public partial class Form1 : Form
    {
        int NumValido, Eliminar;
        private BankAccountRepository bankAccount;
        public Form1()
        {
            bankAccount = new BankAccountRepository();
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

         void Cargar_Click(object sender, EventArgs e)
        {
            borrarVariables();
            try
            {
                if (NumValido == 1)
                {

                    var banks = bankAccount.ObtenerTodos();
                    foreach (var i in banks)
                    {
                        if (i.AccountNumber == NumCuentaTransaccion.Text)
                        {
                            Bank UpdateBalance = new Bank();
                            UpdateBalance.AccountID = i.AccountID;
                            UpdateBalance.Balance = i.Balance + decimal.Parse(Monto.Text);
                            var balance_ = bankAccount.ActualizarBalance(UpdateBalance);
                            MessageBox.Show("El Deposito se completo con exito");
                            break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Coloca un Monto valido");
            }

        }

        private void Numcuenta_Click(object sender, EventArgs e)
        {

        }
        
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ValidarNum_Click(object sender, EventArgs e)
        {
            borrarVariables();
            var banks = bankAccount.ObtenerTodos();

            //Variable en la cual se guardara si es valido la cuenta
            NumValido = 0;
            foreach (var i in banks)
            {
                if(i.AccountNumber == NumCuentaTransaccion.Text)
                {
                    NumValido = 1;
                    MessageBox.Show("El número de cuenta es valido");
                    BalanceTotal.Text = $"Balance: ${i.Balance}";
                    break;
                }
            }

            if(NumValido == 0)
            {
                BalanceTotal.Text = $"Balance";
                MessageBox.Show("El número de cuenta no es valido");
            }    

        }

        private void Retiro_Click(object sender, EventArgs e)
        {
            borrarVariables();
            try
            {
                if(NumValido == 1)
                {
                    
                    var banks = bankAccount.ObtenerTodos();
                    foreach (var i in banks)
                    {
                        if (i.AccountNumber == NumCuentaTransaccion.Text)
                        {
                            if(i.Balance > decimal.Parse(Monto.Text))
                            {
                                Bank UpdateBalance = new Bank();
                                UpdateBalance.AccountID = i.AccountID;
                                UpdateBalance.Balance = i.Balance - decimal.Parse(Monto.Text);
                                var balance_ = bankAccount.ActualizarBalance(UpdateBalance);
                                MessageBox.Show("Retiro con exito");
                                
                            }
                            else if(i.Balance < decimal.Parse(Monto.Text))
                            {
                                MessageBox.Show("Balance insuficiente");
                            }
                            break;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coloca un Monto valido");
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            borrarVariables();
            try
            {
                int agregar = 0;
                Bank usuarioNuevo = new Bank();

                usuarioNuevo.AccountHolderName = NombreUsuario.Text;
                usuarioNuevo.AccountNumber = NumeroCuentas.Text;
                usuarioNuevo.AccountType = Tipo.Text;
                usuarioNuevo.CreationDate = DateTime.Now;

                var NumeroUnico = bankAccount.ObtenerTodos();
                foreach (var i in NumeroUnico)
                {
                    if(i.AccountNumber == usuarioNuevo.AccountNumber)
                    {
                        agregar = 1;
                        MessageBox.Show("Ese numero de cuenta ya existe");
                    }
                }
                if(agregar == 0)
                {
                    var banks = bankAccount.InsertarCuenta(usuarioNuevo);
                    MessageBox.Show("Registro completo...");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var banks = bankAccount.ObtenerTodos();

            //Variable en la cual se guardara si es valido la cuenta
            NumValido = 0;
            foreach (var i in banks)
            {
                if (i.AccountNumber == NumeroCuentaUpdate.Text)
                {
                    NumValido = 1;
                    NombreUpdate.Text = i.AccountHolderName;
                    TipoUpdate.Text = i.AccountType;
                    MessageBox.Show("El número de cuenta es valido");
                    Eliminar = 1;
                    break;
                }
            }

            if (NumValido == 0)
            {
                Eliminar = 0;
                MessageBox.Show("El número de cuenta no es valido");
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            borrarVariables();
            try
            {
                if(Eliminar == 1)
                {
                    var banks = bankAccount.ObtenerTodos();
                    foreach (var i in banks)
                    {
                        if (i.AccountNumber == NumeroCuentaUpdate.Text)
                        {
                            var bankss = bankAccount.EliminarCuenta(i.AccountID);
                            break;
                        }
                          
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hay un error, verifica el numero de cuenta..");
            }
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            borrarVariables();
            try
            {
                if (Eliminar == 1)
                {
                    var banks = bankAccount.ObtenerTodos();
                    foreach (var i in banks)
                    {
                        if (i.AccountNumber == NumeroCuentaUpdate.Text)
                        {
                            Bank update = new Bank();
                            update.AccountHolderName = NombreUpdate.Text;
                            update.AccountType = TipoUpdate.Text;
                            update.AccountID = i.AccountID;
                            var bankss = bankAccount.ActualizarCuenta(update);
                            MessageBox.Show("Se hizo una actualizacion en los datos");
                            break;
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error, verifica el numero de cuenta..");
                MessageBox.Show(ex.Message);
            }
        }

        private void borrarVariables()
        {

            Bank Tabla = new Bank();

            Tabla.AccountHolderName = null;
            Tabla.AccountNumber = null;
            Tabla.AccountType = null;
            
            
        }
    }
}
