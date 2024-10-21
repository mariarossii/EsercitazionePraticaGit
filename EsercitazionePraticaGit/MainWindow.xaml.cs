using System.Runtime.InteropServices;
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
        public string titolo;
        public string autore;
        public int pagine;

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

    class Bilioteca
    {
        private string nome,indirizzo,open_time,close_time;

        private List<Libro> libri = new List<Libro>();

        public void addLibro(Libro libro)
        {
            if (libri.Count < 1000)
            {
                libri.Add(libro);
            }
        }
        
        public bool CercaLibro(string titolo)
        {
            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].titolo == titolo)
                {
                    return true;
                }
            }

            return false;
            
        }

        public string CercaLibriAutore(string autore)
        {
            string lista = "";
            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].autore == autore)
                {
                    lista += libri[i].titolo;
                }
            }
            return lista;
        }

        public int nLibri()
        {
            return libri.Count;
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