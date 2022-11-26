// pegar o botão passando para o JS e assim manipular.JS
const btnCalcular = document.querySelector('#calcular');

// colocar um escutador de eventos que quando o botão for clicado ele executará a função
btnCalcular.addEventListener('click', () => {

    // pegando todos os elementos que têm a class heroi
    const herois = document.querySelectorAll('.heroi')

    // usando um for qq vamos pegar as informações
    herois.forEach((heroi) => {
        const forca = Number(heroi.querySelector('.forca').textContent);
        const velocidade = Number(heroi.querySelector('.velocidade').textContent);
        const agilidade = Number(heroi.querySelector('.agilidade').textContent);
        const xpFinal = (forca + velocidade + agilidade) / 3;

        // heroi.querySelector('.xp').textContent = xpFinal.toFixed(2);
        heroi.querySelector('.xp').textContent = parseInt(xpFinal);

        if (xpFinal < 80) {
            heroi.classList.add('bg-danger', 'text-light');
            const linha = document.querySelector("#linha");
        }

    });

    linha.textContent += ` - Linha vermelha = Rever Herói`
})