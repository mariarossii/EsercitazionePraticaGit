using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Maria Rossi 4H
namespace EsercitazionePraticaGit
{
    class Libro()
    {
        private string titolo;
        private string autore;
        private int pagine;

        private Libro assegnazione(string titolo, string autore, int pagine)
        {
            Libro libro = new Libro();
            libro.titolo = titolo;
            libro.autore = autore;
            libro.pagine = pagine;
            return libro;
        }

        public string to_string(Libro libro)
        {
            return ($"{libro.titolo} {libro.autore} {libro.pagine}");
        }
        
        public int readingTime(Libro libro)
        {
            int pag = libro.pagine;
            if (pag <= 100)
            {
                return 1;
            }
            else if (pag>100 && pag <= 200)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}