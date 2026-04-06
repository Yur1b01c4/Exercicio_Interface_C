using Exercicio_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interface
{
    public class Relatorio : Documento, IImprimivel
    {
        public Relatorio(string titulo) : base(titulo) { }

        public override void Processar() => Console.WriteLine("Processando o relatório...");

        public void Imprimir()
        {
            Console.WriteLine("--- IMPRIMINDO RELATÓRIO ---");
            Console.WriteLine(" __________________________________________________\r\n     /                                                  \\\r\n    |    ____________________________________________    |\r\n    |   |                                            |   |\r\n    |   |  [ LOGO ]        RELATÓRIO ANUAL           |   |\r\n    |   |                EXECUTIVE SUMMARY           |   |\r\n    |   |  ________________________________________  |   |\r\n    |   |                                            |   |\r\n    |   |  DESEMPENHO TRIMESTRAL:                    |   |\r\n    |   |                                            |   |\r\n    |   |   100 |          _                         |   |\r\n    |   |    80 |         | |    _                   |   |\r\n    |   |    60 |    _    | |   | |                  |   |\r\n    |   |    40 |   | |   | |   | |    _             |   |\r\n    |   |    20 |   | |   | |   | |   | |            |   |\r\n    |   |     0 |___|_|___|_|___|_|___|_|_______     |   |\r\n    |   |          Q1    Q2    Q3    Q4              |   |\r\n    |   |                                            |   |\r\n    |   |  ANÁLISE: Os dados indicam um crescimento  |   |\r\n    |   |  sustentável no segundo trimestre, com     |   |\r\n    |   |  estabilização prevista para o período.    |   |\r\n    |   |                                            |   |\r\n    |   |  CONFIDENCIAL  [#######]  PÁGINA 01/42     |   |\r\n    |   |____________________________________________|   |\r\n    |                                                    |\r\n     \\__________________________________________________/\r\n            ||                                  ||\r\n            ||__________________________________|| ");
        }
    }
}