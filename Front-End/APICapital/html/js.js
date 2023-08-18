let cnxFilCodHeader;
let cnxUsnCodHeader;
let numeroPaginas;
let paginas;
let cont;
let currentPage = 1;
let itemsPerPage = 20; // Defina a quantidade de itens por página aqui

async function Login() {
    let username = document.querySelector('#username').value;
    let password = document.querySelector('#password').value;
    
    let login = {
        username,
        password
    };
    
    const options = {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(login)
    };
    
    try {
        const response = await fetch('https://localhost:44388/api/Login/Login', options);
        const data = await response.json();

        // Armazenar os valores dos cabeçalhos
        const cnxFilCod = data.filiais.map(filial => filial.filCod);
        const cnxUsnCod = data.usnCod;

        cnxFilCodHeader = cnxFilCod;
        cnxUsnCodHeader = cnxUsnCod;

        alert(JSON.stringify(data)); // Convertendo o objeto JSON para string antes de exibir
        return data;
    } catch (error) {
        alert(error);
        return error;
    }
}

async function ListaProcessos() {
    const options = {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
            'CNXFIL-COD': cnxFilCodHeader[0],
            'CNXUSN-COD': cnxUsnCodHeader
        }
    };

    try {
        const response = await fetch('https://localhost:44388/api/ListagemProcessos/ListaProcessos', options);
        if (response.ok) {
            const processos = await response.json();

            paginas = processos.count;
            numeroPaginas = processos.pageNumber;
            cont = processos.count;

            console.log(processos);
            return processos;
        } else {
            throw new Error('Erro na requisição GET');
        }
    } catch (error) {
        console.error(error);
        return null;
    }
}

async function PreencherTabela(pageNumber, itemsPerPage) {
    const processosTable = document.getElementById('processosTable');
    const tbody = processosTable.querySelector('tbody');

    // Limpar a tabela antes de preencher
    tbody.innerHTML = '';

    try {
        const response = await ListaProcessos();

        if (response) {
            const processos = response.rows;

            const startIdx = (pageNumber - 1) * itemsPerPage;
            const endIdx = startIdx + itemsPerPage;

            for (let i = startIdx; i < endIdx && i < processos.length; i++) {
                const processo = processos[i];
                const row = document.createElement('tr');

                const cellValues = [
                    processo.priVldTipo,
                    processo.priDtaAbertura,
                    processo.dtaFechFinanceiro,
                    processo.priEspRefcliente,
                    processo.filCod
                ];

                cellValues.forEach(value => {
                    const cell = document.createElement('td');
                    cell.textContent = value;
                    row.appendChild(cell);
                });

                tbody.appendChild(row);
            }
        }

        // Atualizar a exibição do número de páginas
        numeroPaginas.textContent = `Página ${pageNumber} de ${Math.ceil(paginas / itemsPerPage)}`;

    } catch (error) {
        console.error(error);
        // Aqui você pode lidar com o erro de acordo com a necessidade
    }
}

//inicializador de eventos

function cor(obj,cor){
   obj.style.backgroundColor=cor;
}


function EventLoginButton(){

    var loginButtonEvent = document.getElementById("loginButton");
    loginButtonEvent.addEventListener('click', Login);

    loginButtonEvent.addEventListener("mouseover",function(event){
        
        cor(loginButtonEvent,"#f00");

    });

    loginButtonEvent.addEventListener("mouseout", function(event){

        cor(loginButtonEvent, "#f0f0");
    });

}

function EventProcessosButton() {
    var processosButtonEvent = document.getElementById("getProcessosButton");
    processosButtonEvent.addEventListener('click', () => PreencherTabela(1, 20)); // Altere o número da página e a quantidade de itens por página

    const prevPageButton = document.getElementById("prevPageButton");
    const nextPageButton = document.getElementById("nextPageButton");

    prevPageButton.addEventListener('click', () => {
        if (currentPage > 1) {
            currentPage--;
            ListaProcessos();
            PreencherTabela();

        }
    });

    nextPageButton.addEventListener('click', () => {
        if ((currentPage * itemsPerPage) < cont) {
            currentPage++;
            ListaProcessos();
            PreencherTabela();
        }
    });
}

// Funções para navegação
function goToPage(page) {
    currentPage = page;
    PreencherTabela();
}

function goToNextPage() {
    goToPage(currentPage + 1);
}

function goToPreviousPage() {
    if (currentPage > 1) {
        goToPage(currentPage - 1);
    }
}

window.addEventListener("load", EventLoginButton);
window.addEventListener("load", EventProcessosButton);
