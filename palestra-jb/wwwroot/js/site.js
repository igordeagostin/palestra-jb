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
    try {
        $.ajax({
            url: "/Home/Sortear",
            success: function (response) {
                document.getElementById("resultado-sorteio").innerHTML = response;
            }
        });
    } catch (error) {
        console.error(error);
    }
}