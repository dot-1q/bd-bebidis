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
		-- inserir a venda do produto
		INSERT INTO BW.VendaSobre(num_venda,produtos,quantidade) VALUES(@venda,@codigo,@quantidade)
		-- subtrair a quantidade do produto ao inventario
		UPDATE BW.Inventario SET BW.Inventario.n_unidades = BW.Inventario.n_unidades - @quantidade WHERE BW.Inventario.codigo=@codigo
		
		DECLARE @preco as DECIMAL(5,2)
		SET @preco= (SELECT preco from BW.Produto WHERE BW.Produto.codigo=@codigo)
		-- aumentar o preco da venda por cada produto inserido
		UPDATE BW.Venda SET BW.Venda.preco = BW.Venda.preco + (@preco*@quantidade) WHERE BW.Venda.numero=@venda
	COMMIT TRAN;
END


--) EXEC  BW.p_createEncomenda @data='1111-11-11',@transportador=4,@pesado='XX-XX-XX'
CREATE PROCEDURE BW.p_createEncomenda 
	@data DATE,
	@transportador INT,
	@pesado VARCHAR(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
		--) criar encomenda
		INSERT INTO BW.Encomenda(data_realizacao,transportador,veiculo_transp) VALUES (@data,@transportador,@pesado)
		--) adicionar como responsavel do pesado, o transportador desta encomenda
		UPDATE BW.Automoveis SET responsavel = @transportador WHERE BW.Automoveis.matricula=@pesado
	COMMIT TRAN;
END
GO


--) EXEC BW.p_createRoute @tipo='asc',@carro_usado='xx-xx-xx',@data='1111-11-11'
CREATE PROCEDURE BW.p_createRoute
	@tipo varchar(15),
	@carro_usado varchar(10),
	@data	DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
		--) inserir a rota
		INSERT INTO BW.Rotas(tipo) VALUES (@tipo)

		DECLARE @id_rota as INT
		--) ir buscar a rota mais recente
		SET @id_rota = (SELECT TOP 1 id from BW.Rotas ORDER BY id DESC)

		INSERT INTO BW.FezRota(id,carro_usado,data_realizacao) VALUES (@id_rota,@carro_usado,@data)
	COMMIT TRAN;
END
GO

--) EXEC BW.p_insertVendas @venda=1,@zona='asd'
ALTER PROCEDURE BW.p_insertVendas
	@venda INT,
	@zona VARCHAR(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
			--) adicionar vendas à encomenda
			--) buscar a encomenda mais recente
			DECLARE @encomenda as INT
			--) ir buscar a rota mais recente
			SET @encomenda = (SELECT TOP 1 numero from BW.Encomenda ORDER BY numero DESC)
			INSERT INTO BW.Contem(num_encomenda,num_venda) VALUES(@encomenda,@venda)
			--) por cada venda, adicionar a localizacao do comprador à rota que o pesado irá fazer
			DECLARE @id_rota as INT
			--) ir buscar a rota mais recente
			SET @id_rota = (SELECT TOP 1 id from BW.FezRota ORDER BY id DESC)
			INSERT INTO BW.ZonasRotas(id,zona) VALUES(@id_rota,@zona)
	COMMIT TRAN;
END



--) EXEC BW.p_updateFunc @num_func=1,@nome='asd',@n_telemovel=123123,@data='1111-11-11',@sal=123,@cargo='asd'
CREATE PROCEDURE BW.p_updateFunc
	@num_func INT,
	@nome varchar(30),
	@n_telemovel INT,
	@data DATE,
	@sal INT,
	@cargo varchar(15),
	@zona varchar(20),
	@responsavel INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
		--) update na tabela funcionario
		UPDATE BW.Funcionario SET nome=@nome,n_telemovel=@n_telemovel,data_nascimento=@data,salario=@sal WHERE num_funcionario=@num_func;

		IF @cargo='promotor'
			UPDATE BW.PromotorVendas SET zona_designada=@zona
		IF @cargo='operador'
			UPDATE BW.Operador SET num_responsavel=@responsavel
	COMMIT TRAN
END



CREATE PROCEDURE BW.p_createFunc
	@nome varchar(30),
	@n_telemovel INT,
	@data DATE,
	@sal INT,
	@cargo varchar(15),
	@zona varchar(20),
	@responsavel INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
		--) update na tabela funcionario
		INSERT INTO BW.Funcionario(nome,n_telemovel,data_nascimento,salario,armazem_trabalha) VALUES(@nome,@n_telemovel,@data,@sal,'Viana do Castelo')
		--) update na tabela de login
		DECLARE @funcionario as INT
		--) ir buscar a rota mais recente
		SET @funcionario = (SELECT TOP 1 num_funcionario from BW.Funcionario ORDER BY num_funcionario DESC)
		INSERT INTO BW.Login(num_funcionario,role) VALUES(@funcionario,@cargo)

		IF @cargo='promotor'
			INSERT INTO BW.PromotorVendas(num_funcionario,zona_designada) VALUES (@funcionario,@zona)
		IF @cargo='operador'
			INSERT INTO BW.Operador(num_funcionario,num_responsavel) VALUES (@funcionario,@responsavel)
		IF @cargo='transportador'
			INSERT INTO BW.Transportador(num_funcionario) VALUES (@funcionario)
	COMMIT TRAN
END

--) EXEC BW.p_createVehicle @matricula='asd', @carga=0
CREATE PROCEDURE BW.p_createVehicle 
	@matricula varchar(10),
	@carga INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
		INSERT INTO BW.Automoveis(matricula,responsavel,em_utilizacao,armazem_resp) VALUES (@matricula,2,0,'Viana do Castelo')
		
		--) se carga maior que zero, é um pesado
		IF @carga > 0
			INSERT INTO BW.Pesado(matricula,carga) VALUES (@matricula,@carga)
		ELSE
			INSERT INTO BW.Ligeiro(matricula,utilizado_por) VALUES(@matricula,2)
	COMMIT TRAN;
END
GO

CREATE PROCEDURE BW.p_deleteSell
	-- Add the parameters for the stored procedure here
	@id_venda INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRAN
	DELETE FROM BW.VendaAo Where BW.VendaAo.num_venda = @id_venda
	DELETE FROM BW.VendaSobre Where BW.VendaSobre.num_venda = @id_venda
	DELETE FROM BW.Venda WHERE BW.Venda.numero = @id_venda
	COMMIT TRAN;
END
GO





