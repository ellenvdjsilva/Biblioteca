using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class BibliotecaContext: DbContext
    {
        // criando uma classe construtora
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) 
        { 
            
        }
    }
}
