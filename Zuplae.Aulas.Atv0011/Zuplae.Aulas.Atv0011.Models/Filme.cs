using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0011.Models
{
    public class Filme
    {
        public string titulo;
        public string genero;
        public int anoLancamento;
        public string diretor;
        
        
        
        public Filme(string titulo, string genero, int anoLancamento, string diretor)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.anoLancamento = anoLancamento;
            this.diretor = diretor;
            
        }

        public override string ToString()
        {
            return $"Título: {titulo}, Gênero: {genero}, Ano de Lançamento: {anoLancamento}, Diretor: {diretor}";
        }



    }
}
