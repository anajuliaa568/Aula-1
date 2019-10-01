UPDATE -- Palavra reservada que utiliza informaçoes
LIVROS -- Nossa tabela re será alterado a informação
SET -- set inicializa a primeira alteração a informação
Ativo = 0 -- Expressão que vai ser alternada
where -- Palavraa que inicializada as condiçoes para realizar esta alteração
ID = 
(select id from  (SELECT id FROM Livros ORDER BY id desc OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY) temp
ORDER BY id desc OFFSET 1 ROWS FETCH NEXT 2 ROWS ONLY)
