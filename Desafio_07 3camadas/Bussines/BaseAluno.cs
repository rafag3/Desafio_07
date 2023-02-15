using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class BaseAluno
    {
   public string Nome { get; set; }
    public int Idade { get; set; }
    public int Nota { get; set; }

    public BaseAluno(string nome, int idade, int nota)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Nota = nota;
    }
         public BaseAluno() { }

        
    }
}
