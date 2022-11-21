-------------------------------------------------------------------------------
-- Exercícios: Banco de Dados - Programação Aula 8(Exercício-Solução).sql
-------------------------------------------------------------------------------
-- Exercício 1

SELECT COUNT(*)
FROM DB_FUNCIONARIO
WHERE DT_DESLIGAMENTO IS NULL;

-- Exercício 2
SELECT D.NM_DEPTO, COUNT(F.CD_DEPTO) QTD
FROM DB_FUNCIONARIO F JOIN DB_DEPTO D
ON F.CD_DEPTO=D.CD_DEPTO
WHERE DT_DESLIGAMENTO IS NULL
GROUP BY D.NM_DEPTO;

-- Exercício 3
SELECT TO_CHAR(DT_PEDIDO,'Month') MES ,
       COUNT(*) TOTAL_PEDIDOS,
       SUM(VL_TOT_PEDIDO) TOTAL_VENDAS
FROM DB_PEDIDO
GROUP BY TO_CHAR(DT_PEDIDO,'Month');

-- Exercício 4
SELECT NM_CLIENTE, COUNT(*) QTD_COMPRAS
FROM DB_CLIENTE C JOIN DB_END_CLI E
ON C.NR_CLIENTE = E.NR_CLIENTE
JOIN DB_PEDIDO P
ON P.NR_CLIENTE = E.NR_CLIENTE
GROUP BY NM_CLIENTE
HAVING COUNT(*) > 5 ;

-- OU NESSE CASO COM ESSE MODELO DE DADOS

SELECT NM_CLIENTE, COUNT(*) QTD_COMPRAS
FROM DB_CLIENTE C JOIN DB_PEDIDO E
ON C.NR_CLIENTE = E.NR_CLIENTE
GROUP BY NM_CLIENTE
HAVING COUNT(*) > 5 ;