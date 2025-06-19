using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0011.Models
{
    internal class Atores
    {
        public string nome;
        public int idade;
        public string nacionalidade;
        public Filme filme;

        public Atores(string nome, int idade, string nacionalidade, Filme filme)
        {
            this.nome = nome;
            this.idade = idade;
            this.nacionalidade = nacionalidade;
            this.filme = filme;
        }

        public override string ToString()
        {
            return $"Nome: {nome}, Idade: {idade}, Nacionalidade: {nacionalidade}, Filme: {filme}";
        }
    }
}
