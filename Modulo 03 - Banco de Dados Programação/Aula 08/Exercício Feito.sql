-- CONSULTA UTILIZANDO FUNÇÕES DE AGREGAÇÃO
SELECT COUNT(*)
FROM DB_FUNCIONARIO
WHERE DT_DESLIGAMENTO IS NULL;

SELECT
	D.NM_DEPTO,
	COUNT(F.CD_FUNCIONARIO)
FROM DB_FUNCIONARIO F
INNER JOIN DB_DEPTO D ON (D.CD_DEPTO = F.CD_DEPTO)
WHERE DT_DESLIGAMENTO IS NULL
GROUP BY NM_DEPTO

SELECT 
	EXTRACT(MONTH FROM DT_PEDIDO) AS MES, 
	COUNT(NR_PEDIDO),
	SUM(VL_TOT_PEDIDO)
FROM DB_PEDIDO
GROUP BY EXTRACT(MONTH FROM DT_PEDIDO)
ORDER BY MES ASC;

SELECT 
	 C.NM_CLIENTE
	,COUNT(*)
FROM DB_CLIENTE C
INNER JOIN DB_PEDIDO P ON (P.NR_CLIENTE = C.NR_CLIENTE)
GROUP BY NM_CLIENTE
HAVING COUNT(NR_PEDIDO) > 5;

-- DESAFIO

-- QUANTIDADE DE PRODUTOS POR LOJA
SELECT 
	L.NM_LOJA,
	COUNT(*)
FROM DB_PRODUTO_LOJA P
INNER JOIN DB_LOJA L 
	ON (L.NR_LOJA = P.NR_LOJA)
GROUP BY NM_LOJA

-- FATURAMENTO POR PRODUTO
SELECT 
	SUM(F.VL_TOT_PRD_VENDIDOS)
	,P.DS_PRODUTO
FROM DB_FATURAMENTO_PRODUTO F
INNER JOIN DB_PRODUTO P
	ON (P.CD_PRODUTO = F.CD_PRODUTO)
GROUP BY DS_PRODUTO;