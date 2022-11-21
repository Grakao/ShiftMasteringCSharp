-------------------------------------------------------------------------------
-- Exercícios: Banco de Dados - Programação Aula 5(Exercício-Solução).sql
-------------------------------------------------------------------------------

--------------------------------------------
-- CONSULTA SIMPLES (PROJEÇÃO)
--------------------------------------------
- Exercício 1
SELECT NM_FUNCIONARIO, DT_CADASTRAMENTO
FROM DB_FUNCIONARIO;

-- Exercício 2
SELECT NM_FUNCIONARIO, 
       VL_SALARIO_BRUTO, 
       VL_SALARIO_BRUTO + (VL_SALARIO_BRUTO * .05) SAL_5_PCT ,  
       VL_SALARIO_BRUTO + (VL_SALARIO_BRUTO * .08) SAL_8_PCT     
FROM DB_FUNCIONARIO;    

-- Exercício 3
SELECT NM_CLIENTE, QT_ESTRELAS
FROM DB_CLIENTE;

-- Exercício 4
SELECT DS_PRODUTO, VL_UNITARIO
FROM DB_PRODUTO;

--------------------------------------------
-- CONSULTA COM CONDIÇÕES (SELEÇÃO)
--------------------------------------------
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

--------------------------------------------
-- DESAFIO
--------------------------------------------
-- Exercício 1
select NR_PEDIDO,DT_PEDIDO , EXTRACT(MONTH FROM DT_PEDIDO)
from db_pedido
where EXTRACT(MONTH FROM DT_PEDIDO) <= 3;

-- Exercício  2
select NR_PEDIDO,DT_PEDIDO 
from   db_pedido
where  EXTRACT(MONTH FROM DT_PEDIDO) <= 3 
and    EXTRACT(year FROM DT_PEDIDO) = 2021;

-- ***** O correto é com subquery: 
select NR_PEDIDO,DT_PEDIDO 
from   db_pedido
where  EXTRACT(MONTH FROM DT_PEDIDO) <= 3 
and   EXTRACT(year FROM DT_PEDIDO) = (SELECT  MAX(EXTRACT(YEAR FROM DT_PEDIDO))
                                      FROM db_pedido);
-- Exercício 3
select * 
from   db_pedido 
Where  EXTRACT(year FROM DT_PEDIDO) = 2018;








