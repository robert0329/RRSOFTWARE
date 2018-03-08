using RRSOFTWARE.BLL;
using RRSOFTWARE.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRSOFTWARE.Register.Users
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            Id();
        }
        
        
        #region Button
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if(validarId() == true)
            {
                var Result = UserBLL.Search(Utilidades.ToInt(userIdTextBox.Text));

                if (Result != null)
                {
                    if(Result.Disable == 0)
                    {
                        usuarioTextBox.Text = Result.Usuario;
                        passwordTextBox.Text = Result.Password;
                        nameTextBox.Text = Result.Name;
                        apellidoTextBox.Text = Result.Apellido;
                        userIdTextBox.Enabled = false;
                    }
                    else
                    Error(1);
                }
                else
                {
                    Error(0);
                }
            }          
            else
            {
                Error(0);
            }
        }  
        private void Savebutton_Click(object sender, EventArgs e)
        {
            User user = new User();
            if(ValidarTextbox() == true)
            {
                try
                {
                    user = CreateUserAndDisable(0);
                    if (BLL.UserBLL.Create(user))
                    {
                        Newbutton.PerformClick();
                        MessageBox.Show("Proceso Realizado", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No se pudo realizar", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {

                    throw;
                }
            }          
        }
        private void Disablebutton_Click(object sender, EventArgs e)
        {

            var search = BLL.UserBLL.Search(Convert.ToInt32(userIdTextBox.Text));
            if (search != null)
            {
                User user = new User();
                user = CreateUserAndDisable(1);
                if (BLL.UserBLL.Create(user))
                {
                    MessageBox.Show("Usuario Desabilitado", "<- Proceso Exitoso ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha desabilitado", "<- Proceso Fallido ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Newbutton.PerformClick();
            }
        }
        private void Newbutton_Click(object sender, EventArgs e)
        {
            usuarioTextBox.Text =
            passwordTextBox.Text =
            nameTextBox.Text =
            apellidoTextBox.Text = "";
            userIdTextBox.Text = "";
            Id();
            userIdTextBox.Enabled = true;
            Searchbutton.Enabled = true;
        }
        #endregion
        #region Configuration
        private User CreateUserAndDisable(int N)
        {
            Entidades.User user = new User();
            if (N == 0)
            {
                user.UserId = Convert.ToInt32(userIdTextBox.Text);
                user.Usuario = usuarioTextBox.Text;
                user.Password = passwordTextBox.Text;
                user.Name = nameTextBox.Text;
                user.Apellido = apellidoTextBox.Text;
                user.Disable = N;
            }
            else
            {
                user.UserId = Convert.ToInt32(userIdTextBox.Text);
                user.Usuario = usuarioTextBox.Text;
                user.Password = passwordTextBox.Text;
                user.Name = nameTextBox.Text;
                user.Apellido = apellidoTextBox.Text;
                user.Disable = N;
            }
            return user;
        }
        public void Id()
        {
            int id = BLL.UserBLL.Identity();
            if (id > 1 || BLL.UserBLL.GetList().Count > 0)
                userIdTextBox.Text = (id + 1).ToString();
            else
                userIdTextBox.Text = id.ToString();
        }
        #endregion
        #region Validaciones
        public void Validar()
        {
            var u1 = new Utilidades(userIdTextBox, "N");
            var u2 = new Utilidades(usuarioTextBox, "LN");
            var u3 = new Utilidades(passwordTextBox, "LN");
            var u4 = new Utilidades(nameTextBox, "L");
            var u5 = new Utilidades(apellidoTextBox, "L");
        }
        private new void MouseClick()
        {
            userIdTextBox.Enabled = false;
            Searchbutton.Enabled = false;
        }
        private bool validarId()
        {
            if (string.IsNullOrEmpty(userIdTextBox.Text))
            {
                UsererrorProvider.SetError(userIdTextBox, "Ingresar el ID");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarTextbox()
        {
            if (string.IsNullOrEmpty(usuarioTextBox.Text))
            {
                UsererrorProvider.SetError(usuarioTextBox, "Username");
                return false;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                UsererrorProvider.SetError(passwordTextBox, "Password");
                return false;
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                UsererrorProvider.SetError(nameTextBox, "Name");
                return false;
            }
            if (string.IsNullOrEmpty(apellidoTextBox.Text))
            {
                UsererrorProvider.SetError(apellidoTextBox, "LastName");
                return false;
            }
            return true;
        }
        public void Error(int N)
        {
            if (N == 0)
            {
                userIdTextBox.Enabled = true;
                MessageBox.Show("Este Id no contiene un usuario", "<- Busqueda Fallida ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsererrorProvider.Clear();
            }else
            if (N == 1)
            {
                userIdTextBox.Enabled = true;
                MessageBox.Show("Este Id esta desabilitado", "<- Busqueda Fallida ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsererrorProvider.Clear();
                Newbutton.PerformClick();
            }
        }
        #endregion
        #region Enable
        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            MouseClick();
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            MouseClick();
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            MouseClick();
        }
        private void apellidoTextBox_TextChanged(object sender, EventArgs e)
        {
            MouseClick();
        }
        #endregion

    }
}
