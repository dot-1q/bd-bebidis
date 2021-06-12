/* BEBIDIS Warehouse Manager 
   Tiago Barros 88963
   Miguel Ferreira 93419
   2021
*/

CREATE FUNCTION BW.getProdutos (@venda INT) RETURNS nvarchar(max)
AS
BEGIN
		DECLARE @produtos nvarchar(max)
		SELECT @produtos = STRING_AGG(CAST(quantidade as varchar)+ 'x '+nome,' , ')
		FROM BW.Produto JOIN BW.VendaSobre
		ON BW.Produto.codigo = BW.VendaSobre.produtos
		WHERE num_venda = @venda

		-- Return the result of the function
		RETURN @produtos
END
GO

CREATE FUNCTION BW.getVendasConc (@encomenda INT) RETURNS nvarchar(max)
AS
BEGIN
		DECLARE @vendas nvarchar(max)
		SELECT @vendas = STRING_AGG(CAST(BW.Contem.num_venda as varchar),' , ')
		FROM BW.Encomenda JOIN BW.Contem
		ON BW.Encomenda.numero = BW.Contem.num_encomenda
		WHERE BW.Encomenda.numero=@encomenda

		-- Return the result of the function
		RETURN @vendas
END
GO

CREATE FUNCTION BW.getVendaPeso (@venda INT) RETURNS DECIMAL(10,2)
AS
BEGIN
		DECLARE @peso DECIMAL(10,2)
		SELECT @peso = SUM(BW.VendaSobre.quantidade * BW.Produto.peso)
		FROM BW.Venda INNER JOIN
		BW.VendaSobre ON BW.Venda.numero = BW.VendaSobre.num_venda INNER JOIN
		BW.Produto ON BW.VendaSobre.produtos = BW.Produto.codigo
		WHERE BW.Venda.numero=@venda
		GROUP BY BW.Venda.numero

		-- Return the result of the function
		RETURN @peso
END
GO

CREATE FUNCTION BW.getEncomendaPeso (@encomenda INT) RETURNS DECIMAL(10,2)
AS
BEGIN
		DECLARE @peso DECIMAL(10,2)
		SELECT @peso = SUM(BW.getVendaPeso(BW.Contem.num_venda))
		FROM   BW.Encomenda INNER JOIN
               BW.Contem ON BW.Encomenda.numero = BW.Contem.num_encomenda
		WHERE BW.Encomenda.numero=@encomenda
		GROUP BY BW.Encomenda.numero
                      
		-- Return the result of the function
		RETURN @peso
END
GO

--) IR buscar a rota de ddistribuicão de determinada encomenda. indo buscar as localizaçoes dos compradores, das vendas que estao na encomenda
--) TEM DE SER ALTERADA NO FUTURO, PARA IR BUSCAR DIRETAMENTE A TABELA DAS ROTAS
CREATE FUNCTION BW.getRotaDist(@encomenda INT) returns nvarchar(max)
AS
BEGIN
	DECLARE @rotas nvarchar(max)
	SELECT @rotas=STRING_AGG(c.localizacao,' , ')
		FROM 
		(SELECT num_encomenda,num_venda from BW.Contem) as t 
		INNER JOIN	BW.VendaAo as v	ON v.num_venda=t.num_venda 
		INNER JOIN	BW.Comprador as c ON c.num_comprador=v.num_comprador
	WHERE num_encomenda=@encomenda
	
	-- Return the result of the function
	RETURN @rotas
END
GO

CREATE FUNCTION BW.getRotas(@id INT) RETURNS nvarchar(max)
AS
BEGIN
	DECLARE @rotas nvarchar(max)
	SELECT @rotas = STRING_AGG(zona,', ') 
	FROM BW.ZonasRotas
	WHERE id=@id
	GROUP BY id
	
	RETURN @rotas
END