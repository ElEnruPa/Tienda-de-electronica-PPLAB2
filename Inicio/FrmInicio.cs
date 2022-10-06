using BiblioDeClasesTP1;
using Forms;

namespace Inicio
{
    public partial class FrmInicio : Form
    {
        private Due�o due�oGlobal = new Due�o();
        private Usuario usuarioVentas = new Usuario();

        public FrmInicio()
        {
            InitializeComponent();
            due�oGlobal.ListaDefault();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string email;
            string contrase�a;

            email = txtEmail.Text;
            contrase�a = txtContrase�a.Text;

            if(email == "1" && contrase�a == "1")
            {
                FrmMenuDue�o frmMenuDue�o = new FrmMenuDue�o(due�oGlobal, usuarioVentas);
                frmMenuDue�o.ShowDialog();
                //this.Close();
            }
            else
            {
                if(email == "2" && contrase�a == "2")
                {
                    FrmAdministradorDeVentas frmAdministradorDeVentas = new FrmAdministradorDeVentas(due�oGlobal, usuarioVentas);
                    frmAdministradorDeVentas.ShowDialog();
                    //this.Close();
                }
                else
                {
                    if(email == "3" && contrase�a == "3")
                    {
                        FrmContadorVentas frmContadorVentas = new FrmContadorVentas(usuarioVentas);
                        frmContadorVentas.ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ingreso mal el Email o la Contrase�a, intentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Clear();
                        txtContrase�a.Clear();
                    }
                }
            }
        }
    }
}