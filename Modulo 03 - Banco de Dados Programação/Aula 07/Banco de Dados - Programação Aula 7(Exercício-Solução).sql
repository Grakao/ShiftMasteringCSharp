-------------------------------------------------------------------------------
-- Exercícios: Banco de Dados - Programação Aula 7(Exercício-Solução).sql
-------------------------------------------------------------------------------
-- Exercício 1
SELECT INITCAP(NM_FUNCIONARIO)
FROM DB_FUNCIONARIO;

-- Exercício 2
SELECT NM_FUNCIONARIO,
       DT_NASCIMENTO, 
       ROUND((months_between(sysdate,to_date(DT_NASCIMENTO,'dd/mm/rrrr')))/12)as idade 
       ROUND(((SYSDATE-DT_NASCIMENTO)/365.25)) IDADE
FROM DB_FUNCIONARIO;

-- Exercício 3
SELECT NM_FUNCIONARIO,DT_NASCIMENTO, 
      TRUNC(((SYSDATE-DT_NASCIMENTO)/365.25)) IDADE,
      CASE MOD(TRUNC(((SYSDATE-DT_NASCIMENTO)/365.25)),2) 
         WHEN 0 THEN 'Par'
         ELSE 'Impar'
       END "Idade Par ou Ímpar"
FROM DB_FUNCIONARIO;

-- Exercício 4
SELECT NM_FUNCIONARIO, CEIL(VL_SALARIO_BRUTO + VL_SALARIO_FAMILIA) SALARIO
FROM DB_FUNCIONARIO;

-- DESAFIO

-- Supondo que, com 55 anos de idade, uma pessoa se aposente. Quais são os 
-- profissionais que estarão aposentados em 2025?

select nm_funcionario,
       round((sysdate - DT_NASCIMENTO)/365.25)
from db_funcionario
where  round((sysdate - DT_NASCIMENTO)/365.25)>= 55;

-- Quais funcionários não estarão aposentados em 2025 e quantos anos faltarão 
-- para se aposentarem?
select nm_funcionario,
       round((to_date('01/01/2025') - DT_NASCIMENTO)/365.25) idade_em_2025,
       55 - round((to_date('01/01/2025') - DT_NASCIMENTO)/365.25) anos_p_aposentadoria
from db_funcionario;

--Supondo que, após se aposentar, o funcionário passe a receber 70% do valor de
-- seu salário atual, quanto ele receberá?
select nm_funcionario,
       to_char(round((70*(VL_SALARIO_BRUTO - VL_SALARIO_FAMILIA))/100.2),'fmL99G999999D00') "70%_salário"
from db_funcionario;
