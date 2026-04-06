using Exercicio_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interface
{
    public class Contrato(string titulo) : Documento(titulo), IImprimivel
    {
        public override void Processar() => Console.WriteLine("Processando o relatório...");
        public void Imprimir()
        {
            Console.WriteLine("--- IMPRIMINDO RELATÓRIO ---");
            Console.WriteLine(" ________________________________________________\r\n      /                                                \\\r\n     |    __________________________________________    |\r\n     |   |                                          |   |\r\n     |   |               CONTRATO                   |   |\r\n     |   |                                          |   |\r\n     |   |  Este documento estabelece os termos e   |   |\r\n     |   |  condições entre as partes citadas...    |   |\r\n     |   |                                          |   |\r\n     |   |  1. CLÁUSULA: O objeto do contrato...    |   |\r\n     |   |  2. CLÁUSULA: Das obrigações e prazos...  |   |\r\n     |   |  3. CLÁUSULA: Das penalidades...         |   |\r\n     |   |                                          |   |\r\n     |   |                                          |   |\r\n     |   |  Assinatura: ________________________    |   |\r\n     |   |                                          |   |\r\n     |   |  Data: ____/____/2026      .-------.     |   |\r\n     |   |                           /   SELO  \\    |   |\r\n     |   |                           \\  OFICIAL /   |   |\r\n     |   |                            '-------'     |   |\r\n     |   |__________________________________________|   |\r\n     |                                                  |\r\n      \\________________________________________________/\r\n             jgs  ||                        ||\r\n                  ||                        ||\r\n                  '--------------------------' ");
        }

        public void exibirTudo(string titulo)
        {
            Console.WriteLine($"Titulo Relatorio: {titulo}");
        }
    }
}