/* BEBIDIS Warehouse Manager 
   Tiago Barros 88963
   Miguel Ferreira 93419
   2021
*/

--)EXEC BW.p_insertAlterProduct @preco=0.55,@nome='Teste',@peso=0.5,@quantidade=0
CREATE PROCEDURE [BW].[p_insertAlterProduct]  
	@preco  MONEY,
	@nome	varchar(30),
	@peso	DECIMAL(4,1),
	@quantidade INT
AS
	BEGIN TRAN
	
	BEGIN
		DECLARE @codigo as int
		INSERT INTO BW.Produto(preco,nome,peso) VALUES(@preco,@nome,@peso);
		SET @codigo = (SELECT codigo FROM BW.Produto WHERE nome = @nome);
		IF @quantidade is NULL
			INSERT INTO BW.Inventario(codigo,n_unidades) VALUES(@codigo,0)
		ELSE
			INSERT INTO BW.Inventario(codigo,n_unidades) VALUES(@codigo,@quantidade)
	END;
	COMMIT TRAN;
RETURN;



--) EXEC BW.p_insertStock @codigo=92338,@quantidade=400,@responsavel=24772330,@data='2021-01-15'
CREATE PROCEDURE BW.p_insertStock 
	@codigo INT,
	@quantidade INT,
	@responsavel INT,
	@data	DATE
AS
BEGIN
	BEGIN TRAN
		IF @quantidade < 0
		BEGIN
			RAISERROR('Quantidade Negativa de Stock',16,1);
		END;
		ELSE
			UPDATE BW.Inventario SET n_unidades=@quantidade, data_adicao=@data,operador_resp=@responsavel WHERE codigo=@codigo
	COMMIT TRAN;
END
GO


--) EXEC BW.p_makeSellTo @data='1111-11-11',@feita_por=2,@num_comprador=1
CREATE PROCEDURE BW.p_makeSellTo
	@data  DATE,
	@feita_por	INT,
	@num_comprador INT,
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
		INSERT INTO BW.Venda(data_realizacao,preco,feita_por) VALUES(@data,0,@feita_por)
		DECLARE @id_venda as INT
		SET @id_venda= (SELECT TOP 1 numero from BW.Venda WHERE data_realizacao=@data ORDER BY data_realizacao DESC, numero DESC)
		INSERT INTO BW.VendaAo(num_venda,num_comprador) VALUES(@id_venda,@num_comprador)
	COMMIT TRAN;
	RETURN @id_venda
END
GO

--) EXEC BW.p_makeSellProd @venda=1,@produto=1,@quantidade=5
CREATE PROCEDURE BW.p_makeSellProd
	@venda  INT,
	@produto INT,
	@quantidade	INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
		-- subtrair a quantidade do produto ao inventario
		UPDATE BW.Inventario SET BW.Inventario.n_unidades = BW.Inventario.n_unidades - @quantidade WHERE BW.Inventario.codigo=@codigo
		-- inserir a venda do produto
		INSERT INTO BW.VendaSobre(num_venda,produtos,quantidade) VALUES(@venda,@codigo,@quantidade)
		
		DECLARE @preco as DECIMAL(5,2)
		SET @preco= (SELECT preco from BW.Produto WHERE BW.Produto.codigo=@codigo)
		-- aumentar o preco da venda por cada produto inserido
		UPDATE BW.Venda SET BW.Venda.preco = BW.Venda.preco + (@preco*@quantidade) WHERE BW.Venda.numero=@venda
	COMMIT TRAN;
END

