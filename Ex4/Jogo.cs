using System;

namespace Cadastro_de_Jogos
{
    internal class Jogo
    {
        public string titulo = "";
        public string console = "";
        public int ano;
        public int ranking;
        public Emprestimo emprestimo = new Emprestimo();
    }
}