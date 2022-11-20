// DOM - Document Object Model
// Manipular HTML e CSS -> inserir - excluir - consultar - alterar qq elemento HTML
// -DOM entende as tags como sendo um NÓ de uma árvore onde o Nó principal é o HTML
// -Pegar qq elemento do HTML e passar para o JS
// -Lembrar = quando vc leva para o JS, ele irá levar:
// -todas as propriedades, métodos, classes, todo conteúdo
// -LEVA PARA O JS TUDO DO ELEMENTO, inclusive seus descendentes

// pegando pelo id
const getID1 = document.getElementById('herois');
console.log(getID1);

const getID2 = document.querySelector('#heroi-um');
console.log(getID2);

// pegar pela class
const getClass1 = document.getElementsByClassName('heroi');
console.log(getClass1);

// querySelector pega o primeiro elemento(nó) que ele encontrar
// se quiser pegar todos use querySelectorAll
const getClass2 = document.querySelectorAll('.nome');
console.log(getClass2);
console.log(getClass2[3]);
console.log(getClass2[3].textContent);
getClass2[3].textContent = 'Eu mesmo';

// //pegar pela tag
const getTag1 = document.getElementsByTagName('tr');
console.log(getTag1);

const getTag2 = document.querySelectorAll('td');
console.log(getTag2);
