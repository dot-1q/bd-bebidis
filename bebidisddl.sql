/* BEBIDIS Warehouse Manager 
   Tiago Barros 88963
   Miguel Ferreira 93419
   2021
*/

-- Create DB
GO
CREATE DATABASE BEBIDIS_WAREHOUSE;
GO

-- Create Schema
GO
CREATE SCHEMA BW;
GO


-- Create Tables
CREATE TABLE BW.Armazem(
    localizacao    VARCHAR(40);
    n_telefone
    n_funcionarios
    n_automoveis
);
CREATE TABLE BW.Funcionario(
    num_funcionario
    nome
    n_telemovel
    data_nascimento
    salario
    armazem_trabalha --foreign key
);
CREATE TABLE BW.Gerente(
    num_funcionario
    gere_armazem
);
CREATE TABLE BW.Operador(
    num_funcionario
    num_responsavel
);
CREATE TABLE BW.Transportador(
    num_funcionario
);
CREATE TABLE BW.PromotorVendas(
    num_funcionario
    zona_designada
);
CREATE TABLE BW.Encomenda(
    numero
    data
    transportador
    veiculo_transp --foreign key 
);
CREATE TABLE BW.Contem(
    num_encomenda
    codigo_prod
);
CREATE TABLE BW.Produto(
    codigo
    preco
    nome
);
CREATE TABLE BW.Inventario(
    codigo
    n_unidades
    data_adicao
    operador_resp
);
CREATE TABLE BW.Venda(
    numero
    data
    preco
    feito_por
);
CREATE TABLE BW.VendaAo(
    num_venda
    num_comprador
);
CREATE TABLE BW.Comprador(
    num_comprador
    n_telefone
    nome
    localizaçao
);
CREATE TABLE BW.VendaSobre(
    num_venda
    produtos
);
CREATE TABLE BW.Automoveis(
    matricula
    responsavel
    em_utilizacao
    armazem_resp
);
CREATE TABLE BW.Pesado(
    matricula
    carga
);
CREATE TABLE BW.Ligeiro(
    matricula
    utilizado_por
);
CREATE TABLE BW.FezRota(
    id
    carro_usado
);
CREATE TABLE BW.Rotas(
    id
    data
);
CREATE TABLE BW.ZonasRotas(
    id
    lista_zona
);
