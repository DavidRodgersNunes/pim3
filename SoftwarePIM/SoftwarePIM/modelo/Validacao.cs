using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace SoftwarePIM.modelo
{
    public class Validacao
    {
        private int idadei;
        private string mensagem;
        private string nome;
        private string idade;

        public Validacao(string nome, string idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.Validar(nome, idade);
        }


        private void Validar(string nome, string idade)
        {
            this.mensagem = "ok";
            int contadorEspacos = 1;
            char i = '0';

            try
            {
                this.idadei = Convert.ToInt32(idade);
                string pattern = @"[^\w\s]"; // Identifica qualquer caractere que não seja alfanumérico

                if (Regex.IsMatch(nome, pattern))
                {
                    this.mensagem = "O nome não pode conter caracteres especiais.";
                }

                foreach (char c in nome)
                {

                    if (c == ' ' && i == ' ')

                    {

                        contadorEspacos++;


                        if (contadorEspacos >= 1)
                        {
                            this.mensagem = "existem 2 ou mais espaços entre os caracteres";
                        }
                    }
                    else
                    {

                        contadorEspacos = 0;
                    }
                    i = c;


                }

                foreach (char c in nome)//verifica se tem numero no nome
                {
                    if (char.IsDigit(c))
                    {
                        this.mensagem = "nome não pode ter numero ";
                    }
                }


                if (nome.Length > 255 || nome.Length < 3)
                {
                    this.mensagem = "O nome deve conter entre 3 a 255 caracteres";
                }
                if (this.idadei < 1 || this.idadei > 110)
                {
                    this.mensagem = "Idade com valor invalido, digite um numero com valor entre 1 a 110";
                }




            }
            catch (Exception)
            {
                this.mensagem = "Digite dados válidos";


            }

        }

        public string Mensagem
        {
            get { return this.mensagem; }
        }
    }

}
