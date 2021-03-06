/* BEBIDIS Warehouse Manager 
   Tiago Barros 88963
   Miguel Ferreira 93419
   2021
*/

-- Create DB
GO
CREATE DATABASE BEBIDIS_WAREHOUSE;
GO

USE BEBIDIS_WAREHOUSE;

-- Create Schema
GO
CREATE SCHEMA BW;
GO


-- Create Tables
CREATE TABLE BW.Armazem(
    localizacao    VARCHAR(40) NOT NULL,
    n_telefone     INT CHECK(n_telefone > 0),
    n_funcionarios INT DEFAULT 0,
    n_automoveis   INT DEFAULt 0,

    PRIMARY KEY (localizacao),
);
CREATE TABLE BW.Funcionario(
    num_funcionario INT NOT NULL IDENTITY(1,1), 
    nome            VARCHAR(30) NOT NULL,
    n_telemovel     INT CHECK(n_telemovel > 0),
    data_nascimento DATE,
    salario         INT CHECK(salario > 0),
    armazem_trabalha VARCHAR(40),
    
    PRIMARY KEY (num_funcionario),
    FOREIGN KEY (armazem_trabalha) REFERENCES BW.Armazem(localizacao) ON DELETE SET NULL ON UPDATE CASCADE
);
CREATE TABLE BW.Gerente(
    num_funcionario     INT NOT NULL,
    gere_armazem        VARCHAR(40),

    PRIMARY KEY(num_funcionario),
    FOREIGN KEY (num_funcionario) REFERENCES BW.Funcionario(num_funcionario) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (gere_armazem) REFERENCES BW.Armazem(localizacao) ON DELETE NO ACTION
);
CREATE TABLE BW.Operador(
    num_funcionario     INT NOT NULL,
    num_responsavel     INT,

    PRIMARY KEY(num_funcionario),
	FOREIGN KEY (num_responsavel) REFERENCES BW.Operador(num_funcionario),
    FOREIGN KEY (num_funcionario) REFERENCES BW.Funcionario(num_funcionario) ON DELETE CASCADE ON UPDATE CASCADE,
);
CREATE TABLE BW.Transportador(
    num_funcionario     INT NOT NULL,

    PRIMARY KEY(num_funcionario),
    FOREIGN KEY (num_funcionario) REFERENCES BW.Funcionario(num_funcionario) ON DELETE CASCADE,
);
CREATE TABLE BW.PromotorVendas(
    num_funcionario     INT NOT NULL,
    zona_designada      VARCHAR(40),

    PRIMARY KEY(num_funcionario),
    FOREIGN KEY (num_funcionario) REFERENCES BW.Funcionario(num_funcionario) ON DELETE CASCADE,
);
CREATE TABLE BW.Encomenda(
    numero      INT NOT NULL IDENTITY(1,1),
    data_realizacao    DATE,
    transportador INT,
    veiculo_transp VARCHAR(10),

    PRIMARY KEY(numero),
    FOREIGN KEY(transportador) REFERENCES BW.Transportador(num_funcionario)
    -- FOREIGN KEY DO VEICULO TRANSPORTADOR
);
CREATE TABLE BW.Produto(
    codigo      INT NOT NULL IDENTITY(1,1),
    preco       DECIMAL(5,2) CHECK(preco>=0.00),
    nome        VARCHAR(30),
	peso		DECIMAL(4,1) NOT NULL,

    PRIMARY KEY(codigo)
);
CREATE TABLE BW.Contem(
    num_encomenda   INT NOT NULL,
    num_venda     INT NOT NULL,

    PRIMARY KEY(num_encomenda,num_venda),
    FOREIGN KEY(num_encomenda) REFERENCES BW.Encomenda(numero),
	-- FOREIGN KEY NUMVENDA AT THE END
);
CREATE TABLE BW.Inventario(
    codigo      INT NOT NULL,
    n_unidades  INT CHECK (n_unidades>=0),
    data_adicao DATE,
    operador_resp INT,

    PRIMARY KEY(codigo,n_unidades),
    FOREIGN KEY(codigo) REFERENCES BW.Produto(codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY(operador_resp) REFERENCES BW.Operador(num_funcionario),
);
CREATE TABLE BW.Venda(
    numero  INT NOT NULL IDENTITY(1,1),
    data_realizacao    DATE,
    preco   DECIMAL(10,2) CHECK(preco>=0.00),
    feita_por INT,

    PRIMARY KEY(numero),
    FOREIGN KEY(feita_por) REFERENCES BW.PromotorVendas(num_funcionario),
);
CREATE TABLE BW.Comprador(
    num_comprador   INT NOT NULL IDENTITY(1,1),
    n_telefone      INT CHECK(n_telefone>0),
    nome            VARCHAR(30),
    localizacao     VARCHAR(40),

    PRIMARY KEY(num_comprador),
	UNIQUE(n_telefone)
);
CREATE TABLE BW.VendaAo(
    num_venda       INT NOT NULL,
    num_comprador   INT NOT NULL,

    PRIMARY KEY(num_venda,num_comprador),
    FOREIGN KEY(num_venda) REFERENCES BW.Venda(numero) ON UPDATE CASCADE,
    FOREIGN KEY(num_comprador) REFERENCES BW.Comprador(num_comprador) ON UPDATE CASCADE
);
CREATE TABLE BW.VendaSobre(
    num_venda       INT NOT NULL,
    produtos         INT NOT NULL,
	quantidade			INT,

    PRIMARY KEY(num_venda,produtos),
    FOREIGN KEY(num_venda) REFERENCES BW.Venda(numero) ON UPDATE CASCADE,
    FOREIGN KEY(produtos) REFERENCES BW.Produto(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE BW.Automoveis(
    matricula       VARCHAR(10) NOT NULL,
    responsavel     INT NOT NULL,
    em_utilizacao   BIT NOT NULL DEFAULT 0,
    armazem_resp    VARCHAR(40),

    PRIMARY KEY(matricula),
    FOREIGN KEY(armazem_resp) REFERENCES BW.Armazem(localizacao) ON UPDATE CASCADE,
);
CREATE TABLE BW.Pesado(
    matricula       VARCHAR(10) NOT NULL,
    carga           INT NOT NULL CHECK(carga>=0),

    PRIMARY KEY(matricula),
    FOREIGN KEY(matricula) REFERENCES BW.Automoveis(matricula) ON UPDATE CASCADE ON DELETE CASCADE,
);
CREATE TABLE BW.Ligeiro(
    matricula       VARCHAR(10) NOT NULL,
    utilizado_por   INT NOT NULL,

    PRIMARY KEY(matricula),
    FOREIGN KEY(matricula) REFERENCES BW.Automoveis(matricula) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY(utilizado_por) REFERENCES BW.Funcionario(num_funcionario) ON UPDATE CASCADE ON DELETE CASCADE,
);
CREATE TABLE BW.Rotas(
    id      INT NOT NULL IDENTITY(1,1),
	tipo	varchar(15),

    PRIMARY KEY(id)
);
CREATE TABLE BW.FezRota(
    id      INT NOT NULL,
    carro_usado VARCHAR(10),
	data_realizacao 		DATE,

    PRIMARY KEY(id,carro_usado,data_realizacao),
    FOREIGN KEY(id) REFERENCES BW.Rotas(id) ON UPDATE CASCADE,
    FOREIGN KEY(carro_usado) REFERENCES BW.Automoveis(matricula) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE BW.ZonasRotas(
    id      INT NOT NULL,
    zona VARCHAR(30) NOT NULL,

    PRIMARY KEY(id,zona),
    FOREIGN KEY(id) REFERENCES BW.Rotas(id) ON UPDATE CASCADE,
);
CREATE TABLE BW.Login(
	num_funcionario INT NOT NULL,
	role	varchar(15),
	
	PRIMARY KEY(num_funcionario),
	FOREIGN KEY(num_funcionario) REFERENCES BW.Funcionario(num_funcionario) ON UPDATE CASCADE ON DELETE CASCADE
)
-- ALTER TABLES PARA FOREIGN KEYS
ALTER TABLE BW.Encomenda    ADD FOREIGN KEY(veiculo_transp)     REFERENCES BW.Pesado(matricula) ON DELETE SET NULL;
ALTER TABLE BW.Contem 		ADD FOREIGN KEY(num_venda)		REFERENCES BW.Venda(numero);
