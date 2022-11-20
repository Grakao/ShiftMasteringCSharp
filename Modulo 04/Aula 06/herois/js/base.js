console.log('Eu sou o Consolera');
console.log(2 + 2);

let nomeUsuario = 'Israel Marques';
let emailUsuario = 'profisrael.copi@fiap.com.br';
let idadeUsuario = 51;
let loginUsuario = true;

console.log(nomeUsuario, emailUsuario, idadeUsuario, loginUsuario);

console.log(nomeUsuario, typeof nomeUsuario);
console.log(emailUsuario, typeof emailUsuario);
console.log(idadeUsuario, typeof (idadeUsuario));
console.log(loginUsuario, typeof (loginUsuario));

loginUsuario = 789.639;
console.log(loginUsuario, typeof (loginUsuario));

// constante  = usar const identificador = valor
const DATANASCIMENTO = '02/12/1970';
console.log(DATANASCIMENTO);
// Gera erro pois foi declarado como constante
// DATANASCIMENTO = 23123123

console.log('Nome: ' + nomeUsuario + ' email: ' + emailUsuario);

// template string 
// Começam e terminam com o sinal de crase `template`
// para chamar variáveis usamos um placeholder = ${variável}
console.log(`Usuario: ${nomeUsuario} idade: ${idadeUsuario}`);

//arrays 
const pessoas = ['Eu', 'Tu', 'Ele', 'Nós', 'Vós', 'Eles'];
console.log(pessoas);
console.table(pessoas);
console.table(pessoas[3]);
pessoas[3] = 'Eu mesmo';
console.table(pessoas);
pessoas[3] = 'Nós';
console.table(pessoas);

// inserir no fim do array
pessoas.push('Eu mesmo')
console.log(pessoas);

// excluir o último índice
pessoas.pop()
console.log(pessoas);

//inserir no ínicio do array
pessoas.unshift('Eu mesmo');
console.log(pessoas);

// excluir o primeiro índice
pessoas.shift();
console.log(pessoas);

// excluir em qq parte do array
pessoas.splice(2, 2);
console.log(pessoas);

//inserir em qq parte do array
pessoas.splice(2, 0, 'Ele', 'Nós', 'Eu mesmo');
console.log(pessoas);