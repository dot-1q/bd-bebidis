/* BEBIDIS Warehouse Manager 
   Tiago Barros 88963
   Miguel Ferreira 93419
   2021
*/
GO
CREATE VIEW BW.viewVendas AS
SELECT        v.numero AS Venda, BW.Funcionario.nome AS Vendedor, v.data_realizacao AS Data, v.preco AS Valor, BW.getVendaPeso(v.numero) AS [Peso Total], BW.getProdutos(v.numero) AS Produtos
FROM            BW.Venda AS v INNER JOIN
                         BW.PromotorVendas ON v.feita_por = BW.PromotorVendas.num_funcionario INNER JOIN
                         BW.Funcionario ON BW.PromotorVendas.num_funcionario = BW.Funcionario.num_funcionario


GO
CREATE VIEW BW.viewEncomendas AS				
SELECT        BW.Encomenda.numero AS Encomenda, BW.Encomenda.data_realizacao AS Data, BW.Funcionario.nome AS Transportador, BW.Pesado.matricula AS Matrícula, BW.Pesado.carga AS Carga, 
                         BW.getVendasConc(BW.Encomenda.numero) AS Vendas, BW.getEncomendaPeso(BW.Encomenda.numero) AS [Peso Total], BW.getRotaDist(BW.Encomenda.numero) AS [Rota de Distribuição]
FROM            BW.Encomenda INNER JOIN
                         BW.Pesado ON BW.Encomenda.veiculo_transp = BW.Pesado.matricula INNER JOIN
                         BW.Transportador ON BW.Encomenda.transportador = BW.Transportador.num_funcionario INNER JOIN
                         BW.Funcionario ON BW.Transportador.num_funcionario = BW.Funcionario.num_funcionario

GO						 
CREATE VIEW BW.viewRotas AS
SELECT        BW.Rotas.id AS Rota, BW.FezRota.data_realizacao AS Data, BW.Automoveis.matricula AS Matrícula, BW.Funcionario.nome AS Funcionario, BW.getRotas(BW.Rotas.id) AS Circuito, BW.Rotas.tipo AS Tipo
FROM            BW.Rotas INNER JOIN
                         BW.FezRota ON BW.Rotas.id = BW.FezRota.id INNER JOIN
                         BW.Automoveis ON BW.FezRota.carro_usado = BW.Automoveis.matricula INNER JOIN
                         BW.Funcionario ON BW.Funcionario.num_funcionario = BW.Automoveis.responsavel
GO						 
CREATE VIEW BW.viewStock AS
SELECT        BW.Produto.codigo AS Código, BW.Produto.nome AS Nome, BW.Produto.peso AS Peso, BW.Inventario.n_unidades AS Stock, BW.Inventario.data_adicao AS Data, f.nome AS [Operador Contador], 
                         r.nome AS [Operador Responsável]
FROM            BW.Inventario INNER JOIN
                         BW.Produto ON BW.Inventario.codigo = BW.Produto.codigo INNER JOIN
                         BW.Operador AS o ON BW.Inventario.operador_resp = o.num_funcionario INNER JOIN
                         BW.Funcionario AS f ON o.num_funcionario = f.num_funcionario LEFT OUTER JOIN
                         BW.Funcionario AS r ON r.num_funcionario = o.num_responsavel

GO						 
CREATE VIEW BW.viewOperators AS
SELECT        BW.Operador.num_funcionario AS Operador, BW.Funcionario.nome AS Nome, BW.Funcionario.n_telemovel AS Telemóvel, BW.Funcionario.data_nascimento AS [Data de Nascimento], BW.Funcionario.salario AS Salário, 
                         r.nome AS Responsável
FROM            BW.Operador INNER JOIN
                         BW.Funcionario ON BW.Operador.num_funcionario = BW.Funcionario.num_funcionario LEFT OUTER JOIN
                         BW.Funcionario AS r ON BW.Operador.num_responsavel = r.num_funcionario

GO						 
CREATE VIEW BW.viewPromotors AS
SELECT        BW.PromotorVendas.num_funcionario AS [Promotor de Vendas], BW.Funcionario.nome AS Nome, BW.Funcionario.n_telemovel AS Telemóvel, BW.Funcionario.data_nascimento AS [Data de Nascimento], 
                         BW.Funcionario.salario AS Salário, BW.PromotorVendas.zona_designada AS Zona
FROM            BW.PromotorVendas INNER JOIN
                         BW.Funcionario ON BW.PromotorVendas.num_funcionario = BW.Funcionario.num_funcionario
						 
GO
CREATE VIEW BW.viewTruckers AS
SELECT        BW.Transportador.num_funcionario AS Transportador, BW.Funcionario.nome AS Nome, BW.Funcionario.n_telemovel AS Telemóvel, BW.Funcionario.data_nascimento AS [Data de Nascimento], 
                         BW.Funcionario.salario AS Salário
FROM            BW.Transportador INNER JOIN
                         BW.Funcionario ON BW.Transportador.num_funcionario = BW.Funcionario.num_funcionario
						 
GO
CREATE VIEW BW.viewProdutos AS
SELECT        BW.Produto.codigo AS Código, BW.Produto.nome AS Produto, BW.Produto.preco AS [Preço/Unidade], BW.Produto.peso AS [Peso (KG)], BW.Inventario.n_unidades AS Unidades
FROM            BW.Inventario INNER JOIN
                         BW.Produto ON BW.Inventario.codigo = BW.Produto.codigo

						 
GO
CREATE VIEW BW.viewVendasNaoEnc AS
SELECT        BW.Venda.numero AS Número, BW.Venda.data_realizacao AS [Data de Realização], BW.Venda.preco AS Preço, BW.getVendaPeso(BW.Venda.numero) AS [Peso Total], BW.getProdutos(BW.Venda.numero) AS Produtos, 
                         BW.Comprador.nome AS Comprador, BW.Comprador.n_telefone AS Telefone, BW.Comprador.localizacao AS Localização
FROM            BW.Venda INNER JOIN
                         BW.VendaAo ON BW.Venda.numero = BW.VendaAo.num_venda INNER JOIN
                         BW.Comprador ON BW.VendaAo.num_comprador = BW.Comprador.num_comprador LEFT OUTER JOIN
                         BW.Contem ON BW.Venda.numero = BW.Contem.num_venda
WHERE        (BW.Contem.num_venda IS NULL)

GO
-- FAZER LEFT OUTER JOINS, PARA CARROS QUE NAO FORAM UTILIZADOS
CREATE VIEW BW.viewVehiclesLig AS
SELECT        BW.Ligeiro.matricula, BW.Funcionario.nome AS [Último Condutor], BW.getLatestRoute(BW.FezRota.carro_usado) AS [Última Rota], BW.FezRota.data_realizacao AS Data
FROM            BW.FezRota INNER JOIN
                         BW.Ligeiro ON BW.FezRota.carro_usado = BW.Ligeiro.matricula INNER JOIN
                         BW.Funcionario ON BW.Funcionario.num_funcionario = BW.Ligeiro.utilizado_por

GO
-- FAZER LEFT OUTER JOINS, PARA CARROS QUE NAO FORAM UTILIZADOS						 
CREATE VIEW BW.viewVehiclesPes AS
SELECT        BW.Pesado.matricula AS Matrícula, BW.Pesado.carga, BW.Funcionario.nome AS [Último Condutor], BW.getLatestRoute(BW.FezRota.carro_usado) AS [Última Rota], BW.FezRota.data_realizacao AS Data
FROM            BW.Pesado INNER JOIN
                         BW.Automoveis ON BW.Pesado.matricula = BW.Automoveis.matricula INNER JOIN
                         BW.FezRota ON BW.Automoveis.matricula = BW.FezRota.carro_usado INNER JOIN
                         BW.Funcionario ON BW.Funcionario.num_funcionario = BW.Automoveis.responsavel