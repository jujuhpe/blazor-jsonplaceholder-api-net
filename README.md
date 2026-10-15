# Lista de exercícios - Desenvolvimento Web

**Aluna:** Julia Andrade Silva  
**Período:** 2º período  
**Professor:** Daniel Henrique Matos de Paiva

## Exercício 1

Aplicação Blazor em C#/.NET que consulta `https://jsonplaceholder.typicode.com/users`, seleciona a primeira pessoa da lista e imprime seu nome, sua cidade e sua empresa no console. A página também exibe esses dados para facilitar a conferência.

Nome da aplicação: **BlazorUsersJsonPlaceHolderApi**.  
Nome do repositório: **blazor-jsonplaceholder-api-net**.

## Como executar

É necessário ter o **SDK do .NET 10** instalado e conexão com a internet.

1. Extraia o ZIP, se estiver usando a versão compactada.
2. Abra um terminal na pasta que contém este README.
3. Execute:

```sh
dotnet run --project BlazorUsersJsonPlaceHolderApi --no-launch-profile --urls http://localhost:5080
```

4. Abra `http://localhost:5080` no navegador. A consulta ocorre quando a página é aberta.
5. Confira os dados na página e no terminal em que executou o projeto.
6. Para encerrar, pressione `Ctrl+C` no terminal.

Saída esperada no console, além das mensagens normais de inicialização do .NET:

```text
Nome: Leanne Graham
Cidade: Gwenborough
Empresa: Romaguera-Crona
```

Os valores são obtidos da API durante a execução. Eles não foram fixados no código. Neste projeto, o console é o terminal do servidor .NET.

## Explicação básica do código

- `Program.cs`: configura o Blazor e registra o cliente HTTP.
- `Models/Usuario.cs`: representa o usuário e contém nome, endereço e empresa.
- `Models/Endereco.cs`: representa o endereço, com o campo de cidade.
- `Models/Empresa.cs`: representa a empresa, com seu nome.
- `Components/Pages/Home.razor`: consulta a API, seleciona o primeiro usuário, imprime no console e mostra o resultado na página.

`OnInitializedAsync` é executado ao carregar o componente. `GetFromJsonAsync<List<Usuario>>` faz a requisição e transforma o JSON em uma lista de objetos C#. O índice `[0]` seleciona o primeiro elemento dessa lista. Os campos consultados são `Name`, `Address.City` e `Company.Name`. `Console.WriteLine` escreve cada dado no terminal.

Os blocos `try` e `catch` mostram uma mensagem caso ocorra um problema de conexão, demora na resposta ou JSON inválido. Antes de acessar o índice zero, o código verifica se a lista está vazia.

## Publicação no GitHub (item c)

Caso o projeto ainda não tenha sido publicado:

1. Entre na sua conta do GitHub e crie um repositório chamado exatamente `blazor-jsonplaceholder-api-net`.
2. Na página do repositório, selecione **Add file > Upload files**.
3. Envie este README, o arquivo `.gitignore` e a pasta `BlazorUsersJsonPlaceHolderApi` com seus arquivos. Envie os arquivos extraídos, não apenas o ZIP. Não envie as pastas `bin` e `obj`, caso tenham sido criadas ao executar o projeto.
4. Confirme o envio em **Commit changes**.
5. Confira se os arquivos aparecem no repositório e copie seu link.

## Entrega no Google Classroom (item d)

Abra a atividade correspondente no Classroom, anexe o link do repositório em **Adicionar ou criar > Link** e finalize em **Entregar**, conforme as opções da sua turma. Confira o prazo informado pelo professor, pois ele não aparece na lista. Se o professor pedir arquivos anexos, inclua também o ZIP do projeto.

## Referências

- API utilizada: https://jsonplaceholder.typicode.com/users
- Documentação oficial do Blazor: https://learn.microsoft.com/aspnet/core/blazor/call-web-api?view=aspnetcore-10.0
