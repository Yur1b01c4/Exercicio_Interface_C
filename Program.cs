using Exercicio_Interface;

// Criando como as classes específicas para acessar tudo
Relatorio relatorioVendas = new Relatorio("Relatório de Vendas Anual");
relatorioVendas.ExibirTitulo();
relatorioVendas.Processar();
relatorioVendas.Imprimir();

Console.WriteLine(new string('-', 30));

Contrato contratoCoca = new Contrato("Contrato Coca-Cola");
contratoCoca.ExibirTitulo();
contratoCoca.Processar();
contratoCoca.Imprimir();