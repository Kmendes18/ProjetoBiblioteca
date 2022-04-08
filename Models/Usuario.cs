namespace Biblioteca.Models
{
    public class Usuario
    {
        public static int Admin = 0;

        public static int Padrao = 1;

        public int Id {get; set;} 

        public string nome {get; set;}

        public string login {get; set;}

        public string senha {get; set;}

        public int Tipo {get; set;}
    }

}