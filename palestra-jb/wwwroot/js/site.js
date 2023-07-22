function colunaAzul() {
    document.getElementById("coluna-azul").style.backgroundColor = "blue";
}

function colunaVermelha() {
    document.getElementById("coluna-vermelha").style.backgroundColor = "green";
}

function colunaAmarela() {
    document.getElementById("coluna-amarela").style.backgroundColor = "yellow";
}

async function sortear() {
    const apiUrl = 'https://localhost:7031/joaobley/sortear';
    try {
        //const response = await fetch(apiUrl);


        await fetch("https://localhost:7031/joaobley/sortear", {
            mode: "no-cors",
            headers: {
                "Content-type": "application/x-www-form-urlencoded; charset=UTF-8"
            },
        })
            .then(resp => console.log(resp));


        if (!response.ok) {
            throw new Error('Erro ao carregar os dados da API.');
        }

        const data = await response.json();
        console.log(data);
        document.getElementById("resultado-sorteio").innerHTML = "aaa";
    } catch (error) {
        //console.error(error);
    }


}