namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;

            if (usuario.Length > 0 && password.Length > 0)
            {

                if (usuario == "Administrador")
                {
                    // Oculto el formulario Form1
                    this.Hide();

                    //Muestro el formulario para el perfil Administrador
                    FormAdministrador formAdministrador = new FormAdministrador();
                    formAdministrador.ShowDialog();
                }
                else if (usuario == "Supervisor")
                {
                    // Oculto el formulario Form1
                    this.Hide();

                    //Muestro el formulario para el perfil Supervisor
                    FormSupervisor formSupervisor = new FormSupervisor();
                    formSupervisor.ShowDialog();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Debe de ingresar un Usuario y Contraseña");
            }
        }
    }
}