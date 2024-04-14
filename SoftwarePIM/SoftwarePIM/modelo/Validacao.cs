using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SoftwarePIM.modelo
{
    public class Validacao
    {
        public int idadei;
        public string tamanhonome;
        public string tamanhoidade;
        public string mensagem;

        public void Validar(string nome, string idade)
        {
            mensagem = "";
            try 
            { 
                idadei=Convert.ToInt32(idade);
                string pattern = @"[^\w]"; // Identifica qualquer caractere que não seja alfanumérico

                if (Regex.IsMatch(nome, pattern))
                {
                    throw new Exception("O nome não pode conter caracteres especiais.");
                }

            }
            catch (Exception)
            {               
                mensagem = "Digite números válidos";
            }
        }
    }
}
