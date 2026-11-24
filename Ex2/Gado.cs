using System;

namespace Cadastro_de_Gado
{
    internal class CabecaGado
    {
        public string codigo = "";
        public double leite; 
        public double alim;  
        public Nasc nasc = new Nasc();
        public char abate = 'N'; // 'S' ou 'N'
    }
}