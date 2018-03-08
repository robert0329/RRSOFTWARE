using RRSOFTWARE.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRSOFTWARE.Consultas
{
    public partial class UserQuery : Form
    {
        public UserQuery()
        {
            InitializeComponent();
        }

        

        private void UserQuery_Load(object sender, EventArgs e)
        {
            

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            
             //if (FiltrocomboBox.SelectedIndex == 0)
             //    ClientedataGridView.DataSource = ClientesBLL.GetListaId(Utilidades.ToInt(FiltrotextBox.Text));
             //if (FiltrocomboBox.SelectedIndex == 1)
             //    ClientedataGridView.DataSource = ClientesBLL.GetListaNombre(FiltrotextBox.Text);
                    userDataGridView.DataSource = UserBLL.GetList();
            
        }
    }
}
