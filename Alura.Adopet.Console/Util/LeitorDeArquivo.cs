using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    internal class LeitorDeArquivo
    {
        public List<Pet> RealizaLeitura(string caminhoDoArquivoASerLido)
        {
            List<Pet> listaDePet = new List<Pet>();
            using (StreamReader sr = new StreamReader(caminhoDoArquivoASerLido))
            {
                System.Console.WriteLine("----- Dados a serem importados -----");
                while (!sr.EndOfStream)
                {
                    var linha = sr.ReadLine() ?? "";
                    listaDePet.Add(linha.ConverteDoTexto());
                }
            }

            return listaDePet;
        }
    }
}
