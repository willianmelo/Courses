using CRUD.DAO;
using CRUD.Models;
using System.Windows;

namespace CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usu = new Usuario();

            usu.Nome = tNome.Text;

            dao.Inserir(usu);

            usu.Nome = "Igor";
            dao.Inserir(usu);
        }
    }
}
