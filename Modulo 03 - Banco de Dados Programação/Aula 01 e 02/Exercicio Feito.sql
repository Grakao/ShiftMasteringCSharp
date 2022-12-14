/*

DROP TABLE PRODUTO;
DROP TABLE ITEM_PRODUTO;
DROP TABLE CATEGORIA;
DROP TABLE MATERIA_PRIMA;

*/

-- CRIANDO AS TABELAS COM SUAS CHAVES PRIMARIAS E REGRAS
CREATE TABLE CATEGORIA (
	COD_CATEGORIA INT,
	CATEGORIA VARCHAR(255),
	CONSTRAINT PK_CATEGORIA PRIMARY KEY (COD_CATEGORIA),
	CONSTRAINT CK_CATEG_TIPOS CHECK (CATEGORIA IN ('DOCE', 'BEBIDA', 'CONGELADO'))
);

CREATE TABLE MATERIA_PRIMA (
	COD_MATERIA_PRIMA INT,
	MATERIA_PRIMA VARCHAR(255),
	CONSTRAINT PK_MATERIA_PRIMA PRIMARY KEY (COD_MATERIA_PRIMA)
);


CREATE TABLE ITEM_PRODUTO (
	COD_PRODUTO INT NOT NULL,
	COD_MATERIA_PRIMA INT NOT NULL,
	QUANTIDADE INT NOT NULL,	
	CONSTRAINT PK_ITEM_PRODUTO PRIMARY KEY (COD_PRODUTO,COD_MATERIA_PRIMA)
);


CREATE TABLE PRODUTO (
	COD_PRODUTO INT NOT NULL,
	COD_CATEGORIA INT,
	PRODUTO VARCHAR(255),
	CONSTRAINT PK_PRODUTO PRIMARY KEY (COD_PRODUTO)
);

-- CRIANDO AS FKS
ALTER TABLE ITEM_PRODUTO ADD CONSTRAINT FK_ITEM_PROD FOREIGN KEY (COD_PRODUTO) REFERENCES PRODUTO (COD_PRODUTO);

ALTER TABLE ITEM_PRODUTO ADD CONSTRAINT FK_ITMPRD_MATPRIM FOREIGN KEY (COD_MATERIA_PRIMA) REFERENCES MATERIA_PRIMA (COD_MATERIA_PRIMA);

ALTER TABLE PRODUTO ADD CONSTRAINT FK_PROD_CAT FOREIGN KEY (COD_CATEGORIA) REFERENCES CATEGORIA (COD_CATEGORIA);

-- VALIDANDO
SELECT TABLE_NAME,
       CONSTRAINT_TYPE,
       CONSTRAINT_NAME,
       SEARCH_CONDITION
FROM USER_CONSTRAINTS 
WHERE TABLE_NAME IN ('CATEGORIA','PRODUTO','MATERIA_PRIMA','ITEM_PRODUTO')
ORDER BY 1,2,3;