using LoginSystem007.Forms;
using LoginSystem007.Models;

namespace LoginSystem007
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Garante que o banco seja criado e as migrations aplicadas
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // Cria o banco se não existir
            }
            while (true)
            {
                using (var loginForm = new LoginForm())
                {
                    var result = loginForm.ShowDialog();
                    if (result == DialogResult.OK && Session.LoggedUser != null)
                    {
                        Application.Run(new MainForm());
                        // Se o MainForm fechar, volta para o loop (logout ou restart)
                        // Se quiser realmente encerrar, break;
                    }
                    else
                    {
                        break; // Fechou o login sem sucesso
                    }
                }
            }
        }
    }
}