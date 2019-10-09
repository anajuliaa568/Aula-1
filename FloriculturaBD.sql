--inserir ao menos 5 flores dentro de nossa tabelas
insert into Flores(Nome,Quantidade) 
values 
('Rosa',3),
('Margarida',4),
('Girassol',2),
('Azaléia',5),
('Violeta',4)
--Seleção ordenada das flores, da que contem a maior quantidade para a menor
select * from Flores order by Quantidade desc
select count(*) 
from Flores -- NOSSA TABELA DE DADOS
