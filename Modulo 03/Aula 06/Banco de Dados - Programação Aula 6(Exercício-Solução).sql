-------------------------------------------------------------------------------
-- Exercícios: Banco de Dados - Programação Aula 6(Exercício-Solução).sql
-------------------------------------------------------------------------------
-- Ajuste para o primeiro exercício

ALTER TABLE DB_FUNCIONARIO
ADD CD_DEPTO NUMBER(3);

ALTER TABLE DB_FUNCIONARIO
ADD CONSTRAINT FK_DB_FUNC_DEPTO
FOREIGN KEY (CD_DEPTO)
REFERENCES DB_DEPTO;

UPDATE DB_FUNCIONARIO
SET CD_DEPTO = 1
WHERE NM_FUNCIONARIO LIKE 'A%'
OR NM_FUNCIONARIO LIKE 'C%'
OR NM_FUNCIONARIO LIKE 'D%';

UPDATE DB_FUNCIONARIO
SET CD_DEPTO = 5
WHERE NM_FUNCIONARIO LIKE 'J%'
OR NM_FUNCIONARIO LIKE 'H%'
OR NM_FUNCIONARIO LIKE 'K%';

UPDATE DB_FUNCIONARIO
SET CD_DEPTO =13
WHERE NM_FUNCIONARIO LIKE 'E%'
OR NM_FUNCIONARIO LIKE 'I%'
OR NM_FUNCIONARIO LIKE 'M%';

UPDATE DB_FUNCIONARIO
SET CD_DEPTO = 14
WHERE NM_FUNCIONARIO LIKE 'J%'
OR NM_FUNCIONARIO LIKE 'H%'
OR NM_FUNCIONARIO LIKE 'K%';

UPDATE DB_FUNCIONARIO
SET CD_DEPTO = 20
WHERE NM_FUNCIONARIO LIKE 'B%'
OR NM_FUNCIONARIO LIKE 'O%'
OR NM_FUNCIONARIO LIKE 'G%';

UPDATE DB_FUNCIONARIO
SET CD_DEPTO = 47
WHERE NM_FUNCIONARIO LIKE 'T%'
OR NM_FUNCIONARIO LIKE 'N%';

UPDATE DB_FUNCIONARIO
SET CD_DEPTO = 48
WHERE NM_FUNCIONARIO LIKE 'L%'
OR NM_FUNCIONARIO LIKE 'P%';

UPDATE DB_FUNCIONARIO
SET CD_DEPTO = 49
WHERE NM_FUNCIONARIO LIKE 'R%'
OR NM_FUNCIONARIO LIKE 'S%';

COMMIT;


-----------------------------------------------------------------
-- CONSULTA UTILIZANDO JOIN
-----------------------------------------------------------------

-- Exercício 1
SELECT F.CD_FUNCIONARIO, 
       F.NM_FUNCIONARIO,
       F.DT_NASCIMENTO, 
       D.NM_DEPTO
FROM DB_FUNCIONARIO F JOIN DB_DEPTO D
ON F.CD_DEPTO=D.CD_DEPTO
JOIN DB_END_FUNC E
ON F.CD_FUNCIONARIO=E.CD_FUNCIONARIO
JOIN DB_LOGRADOURO L
ON L.CD_LOGRADOURO = E.CD_LOGRADOURO
JOIN DB_BAIRRO B
ON B.CD_BAIRRO=L.CD_BAIRRO
WHERE B.NM_BAIRRO = 'Vila Mariana';

-- Exercício 2
SELECT C.NM_CLIENTE,
       L.NM_LOGRADOURO, 
       L.NR_CEP
FROM DB_CLIENTE C JOIN DB_END_CLI EC
ON C.NR_CLIENTE=EC.NR_CLIENTE
JOIN DB_LOGRADOURO L
ON  L.CD_LOGRADOURO = EC.CD_LOGRADOURO_CLI
JOIN DB_BAIRRO B
ON  B.CD_BAIRRO=L.CD_BAIRRO
WHERE NM_BAIRRO = 'Saúde'
AND QT_ESTRELAS >=4;

-----------------------------------------------------------------
-- CONSULTA UTILIZANDO JOIN E FILTROS
-----------------------------------------------------------------
-- Esses exercícios são do:
-- Banco de Dados - Programação Aula 5(Exercício-Solução).sql
-----------------------------------------------------------------
-- Exercício 1
SELECT NM_CLIENTE, QT_ESTRELAS
FROM DB_CLIENTE
WHERE QT_ESTRELAS >= 4;

-- Exercício 2
SELECT *
FROM DB_CLIENTE
WHERE QT_ESTRELAS >= 3
AND  VL_MEDIO_COMPRA > 100;

-- Exercício 3
SELECT NM_CLIENTE, QT_ESTRELAS
FROM DB_CLIENTE
AND  VL_MEDIO_COMPRA > 100;

-- Exercício 4
SELECT *
FROM DB_PRODUTO
WHERE VL_UNITARIO > 30;



-----------------------------------------------------------------
-- DESAFIO
-----------------------------------------------------------------
-- Exercício 1
select extract(month from DT_PEDIDO) meses_pedido, 
       sum(VL_TOT_PEDIDO) valor_total
from db_pedido
where extract(year from DT_PEDIDO)=2019
group by extract(month from DT_PEDIDO)
order by meses_pedido;

-- Exercício 2
select extract(month from DT_PEDIDO) meses_pedido, 
       sum(VL_TOT_PEDIDO) valor_total,
       count(NR_PEDIDO) Qtd_pedidos
from db_pedido
where extract(year from DT_PEDIDO)=2019
group by extract(month from DT_PEDIDO)
order by meses_pedido;