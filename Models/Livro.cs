using System;

namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        internal static object toXPagedList(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}