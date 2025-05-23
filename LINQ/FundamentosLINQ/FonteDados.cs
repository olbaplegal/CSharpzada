﻿namespace FundamentosLINQ
{
    class FonteDados
    {
        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1, 2, 4, 8, 16, 32, 64, 128, 512
            };
            return numeros;
        }
        public static List<int> GetListaNegra()
        {
            List<int> numeros = new List<int>()
            {
                16, 138, 512
            };
            return numeros;
        }
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { Nome = "Maria", Idade = 42 },
                new Aluno() { Nome = "Manoel", Idade = 34 },
                new Aluno() { Nome = "Amanda", Idade = 21 },
                new Aluno() { Nome = "Carlos", Idade = 18 },
                new Aluno() { Nome = "Alicia", Idade = 15 },
            };
            return alunos;
        }
    }
}
