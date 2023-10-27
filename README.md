# Contact Sphere - Projeto .NET Core

O projeto "Contact Sphere" é uma aplicação de exemplo que demonstra a autenticação de usuário com tokens JWT e operações CRUD em uma coleção de contatos. Ele é desenvolvido em ASP.NET Core e utiliza Entity Framework Core para a persistência de dados.

### Informações Relevantes
1. Trata-se de uma primeira versão de um projeto CRUD de uma agenda.
2. O token JWT está funcionando de acordo com as roles.
3. Preferi por não utilizar a funcionalidade de remover contato. Optei por utilizar o update de uma flag status do contato na tabela de contatos, isso para preservar o histórico de dados.
4. Uma ideia de novas funcionalidades seria de recupar senha, utilizar um load balance para controle das requisições e adotar um sistema de logs para ficar registrado no banco de dados as movimentações o usuário.

## Requisitos

Antes de executar os projetos, você precisa ter o repositório baixado e o .NET Core instalado em sua máquina. Siga as instruções abaixo para instalá-lo por linha de comando:

### Clone do Repositório

1. Digite o seguinte comando no terminal:

```git clone https://github.com/domrms/ContactSphere.git```

### Instalação do .NET Core

#### Windows

1. Abra um prompt de comando ou PowerShell.
2. Execute o seguinte comando para verificar se o .NET Core já está instalado:

```dotnet --version```

#### macOS e Linux

1. Abra um terminal.
2. Execute o seguinte comando para verificar se o .NET Core já está instalado:

```dotnet --version```

Se uma versão for exibida, o .NET Core já está instalado. Caso contrário, siga os próximos passos.

3. Visite o site oficial do .NET Core em https://dotnet.microsoft.com/download/dotnet para baixar o instalador.
4. Selecione a versão mais recente do .NET Core SDK compatível com o seu sistema operacional e clique no link para baixar.
5. Siga as instruções do instalador para concluir a instalação.

## Executando os projetos

Após instalar o .NET Core, siga as etapas abaixo para executar os projetos:

1. Navegue até a pasta do trabalho que deseja executar. Por exemplo:

```cd ContactSphere\ContactSphere```

2. Restaure as dependências do projeto com o seguinte comando:

```dotnet restore```

3. Compile o projeto com o seguinte comando:

```dotnet build```

4. Execute o projeto com o seguinte comando:

```dotnet run```

Certifique-se de que seu ambiente esteja configurado corretamente para cada trabalho específico. Consulte os arquivos README.md dentro de cada pasta do trabalho para obter instruções adicionais, se necessário.

Se você encontrar algum problema durante a instalação ou execução dos projetos, consulte a documentação oficial do .NET Core em https://docs.microsoft.com/dotnet/core para obter mais informações.

