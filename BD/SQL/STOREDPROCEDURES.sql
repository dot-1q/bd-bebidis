/* BEBIDIS Warehouse Manager 
   Tiago Barros 88963
   Miguel Ferreira 93419
   2021
*/

--)EXEC BW.p_insertAlterProduct @codigo=6345334, @preco=0.55,@nome='Teste',@peso=0.5,@quantidade=0,@oper='i'
CREATE PROCEDURE BW.p_insertAlterProduct  
	@codigo INT,
	@preco  MONEY,
	@nome	varchar(30),
	@peso	DECIMAL(4,1),
	@quantidade INT,
	-- If Oper = 'i' => insert operation, else, it's update
	@oper	varchar(1)
AS
	BEGIN TRAN
	
	-- insert
	IF @oper = 'i'
	BEGIN
		INSERT INTO BW.Produto(codigo,preco,nome,peso) VALUES(@codigo,@preco,@nome,@peso);
		IF @quantidade is NULL
			INSERT INTO BW.Inventario(codigo,n_unidades) VALUES(@codigo,0)
		ELSE
			INSERT INTO BW.Inventario(codigo,n_unidades) VALUES(@codigo,@quantidade)
	END;
	-- update
	ELSE
		UPDATE BW.Produto SET preco = @preco, nome=@nome, peso=@peso WHERE codigo=@codigo;
	COMMIT TRAN;
RETURN;
GO



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

