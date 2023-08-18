import { cnxFilCodHeader, cnxUsnCodHeader } from './config.js';

async function ListaProcessos() {
    const options = {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
            'CNX-FILCOD': cnxFilCodHeader[0],
            'CNX-USNCOD': cnxUsnCodHeader
        }
    };

    try {
        const response = await fetch('https://localhost:44388/api/ListagemProcessos/ListaProcessos', options);
        if (response.ok) {
            const processos = await response.json();
            return processos;
        } else {
            throw new Error('Erro na requisição GET');
        }
    } catch (error) {
        console.error(error);
        return null;
    }
}

// async function PreencherTabela() {
//     const processosTable = document.getElementById('processosTable');
//     const tbody = processosTable.querySelector('tbody');

//     Limpar a tabela antes de preencher
//     tbody.innerHTML = '';

//     const processos = await ListaProcessos();

//     if (processos) {
//         processos.forEach(processo => {
//             const row = document.createElement('tr');
//             row.innerHTML = `
//                 <td>${processo.tipo}</td>
//                 <td>${processo.abertura}</td>
//                 <td>${processo.fechamentoFinanceiro}</td>
//                 <td>${processo.referenciaCliente}</td>
//                 <td>${processo.filial}</td>
//             `;
//             tbody.appendChild(row);
//         });
//     }
// }

// document.addEventListener('DOMContentLoaded', () => {
//     PreencherTabela();  // Call the function directly
//     const getProcessosButton = document.getElementById('getProcessosButton');
//     getProcessosButton.addEventListener('click', PreencherTabela);
// });

export { ListaProcessos };