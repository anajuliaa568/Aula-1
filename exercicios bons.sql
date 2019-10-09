--Inserir 2 funcionarios diferentes
insert into Funcionarios (Nome) 
values
('Ana'),
('Estafanie');

--Devemos cadastrar 5 procutos AMBEV com seus valores
insert into Produtos (Nome,Valor)
values
('CERVEJA Skol Beats Senses', 5.49),   -- UNIDADE
('CERVEJA Budweiser',6.99),            -- UNIDADE
('CERVEJA Stella Artois',3.49),        -- UNIDADE
('CERVEJA Patagonia Bohemian Pil',15.90),  -- UNIDADE
('CERVEJA Corona',4.99)                -- UNIDADE

--Aqui os funcionarios fazem os pedidos
select * from Funcionarios;
select * from Produtos;

-- pedido deve contem no minimo 2 itens e maximo de 5
insert into Pedidos(FuncionarioId,ProdutoId,Quantidade)
values
(1,4,2),
(1,1,3),
(2,4,2);

--Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
select * from Funcionarios
order by Nome

--Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
select * from Produtos 
order by Valor DESC

-- Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario
SELECT ped.Id, fun.Nome,ped.ProdutoId, ped.Quantidade
FROM Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id

--Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e 
--somando sua respectiva quantidade de itens

select fun Nome, SUM(ped.Quantidade) as 'Quantidade' from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
group by fun.Nome

select fun.Nome SUM(ped.Quantidade * pro.Valor) as 'Total'
from Pedidos ped
inner join Funcionarios fun on ped.FuncionarioId = fun.Id
inner join Produtos pro on ped.ProdutoId = pro.Id
group by fun.Nome
select * from Produtos;
select * from Pedidos;

Select top 1
pro.Nome,
Sum (ped.Quantidade) as 'Quantidade'
From Produtos pro
inner join Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome
order by sum (ped.Quantidade) DESC

SELECT pro.Nome,SUM(ped.Quantidade * pro.Valor) as ReceitaTotal
FROM Produtos pro inner join 
Pedidos ped on pro.Id = ped.ProdutosId
group by pro.Nome
order by 'ReceitaTotal' DESC

select * from Produtos
where Id not in (SELECT ped.ProdutoId From Funcionarios fun
inner join Pedidos ped on fun.Id = ped.FuncionarioId
where fun.Nome like 'Ana%')

select pro.Nome, COUNT (ped.ProdutosId) from Produtos pro 
left join Pedidos ped on pro.Id = ped.ProdutosId
group by pro.Nome
order by 'Quantidade' DESC



