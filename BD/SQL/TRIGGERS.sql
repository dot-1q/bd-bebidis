/* BEBIDIS Warehouse Manager 
   Tiago Barros 88963
   Miguel Ferreira 93419
   2021
*/

CREATE TRIGGER BW.checkWeight ON BW.VendaSobre
INSTEAD OF INSERT
AS
BEGIN
	BEGIN TRAN;
		DECLARE @id_venda INT
		DECLARE @peso INT
		DECLARE @pesoInsercao INT
		DECLARE @cargaMax INT

		--) ir buscar o peso da insercao, no caso de 1 só produto enorme
		SET @pesoInsercao = (SELECT SUM(peso*quantidade) from inserted
					JOIN BW.Produto
					ON inserted.produtos=BW.Produto.codigo
					GROUP BY inserted.num_venda
					) 
		PRINT(@pesoInsercao)
		--) ir buscar o pesado com maior carga
		SET @cargaMax = (SELECT TOP 1 carga from BW.Pesado ORDER BY carga DESC)
		--) se o peso da venda for maior que a cargado pesado com mais carga, abortamos
		IF @pesoInsercao>@cargaMax
			RAISERROR('Carga máxima excedida',17,1);
		ELSE
		BEGIN
			INSERT INTO BW.VendaSobre SELECT * from inserted
			-- subtrair a quantidade do produto ao inventario
			UPDATE BW.Inventario SET BW.Inventario.n_unidades = BW.Inventario.n_unidades - inserted.quantidade FROM inserted WHERE BW.Inventario.codigo=inserted.produtos
		END;
	COMMIT TRAN;
END




CREATE TRIGGER BW.checkDeliveryWeight ON BW.Contem
INSTEAD OF INSERT
AS
BEGIN
	BEGIN TRAN;
		DECLARE @id_encomenda INT
		DECLARE @pesoVenda INT
		DECLARE @pesoEncomenda INT
		DECLARE @cargaMax INT

		--) ir buscar o peso da venda a ser inserida
		SET @pesoVenda = (SELECT BW.getVendaPeso(inserted.num_venda) FROM inserted) 
		--) ir buscar o peso das vendas já inseridas
		SET @pesoEncomenda = (SELECT BW.getEncomendaPeso(inserted.num_encomenda)FROM inserted)
		--) ir buscar o pesado responsável pela encomenda
		SET @id_encomenda = (SELECT num_encomenda FROM inserted)
		SET @cargaMax = (SELECT carga FROM BW.Pesado JOIN BW.Encomenda 
						 ON BW.Encomenda.numero=@id_encomenda
						 WHERE BW.Pesado.matricula=BW.Encomenda.veiculo_transp
						 )
		--) se o peso da venda for maior que a cargado pesado com mais carga, abortamos
		IF (@pesoVenda+@pesoEncomenda)>@cargaMax
			RAISERROR('Carga máxima do Pesado excedida',17,1);
		ELSE
		BEGIN
			INSERT INTO BW.Contem SELECT * from inserted
		END;
	COMMIT TRAN;
END

