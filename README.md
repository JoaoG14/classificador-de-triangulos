# Classificador de Triângulos

![](https://i.imgur.com/s5YftXb.gif)

## Introdução

Um aplicativo de console que classifica triângulos com base nas medidas de seus lados, identificando se é um triângulo equilátero, isósceles, escaleno ou se não forma um triângulo válido.

## Funcionalidades

- **Validação de Triângulos**: Verifica se as medidas informadas podem formar um triângulo válido
- **Classificação de Triângulos**:
  - Equilátero (todos os lados iguais)
  - Isósceles (dois lados iguais)
  - Escaleno (todos os lados diferentes)
- **Entrada de Dados**: Interface de usuário para digitar as medidas dos três lados
- **Validação de Entrada**: Garante que apenas números inteiros válidos sejam aceitos
- **Opção de Continuar**: Ao final de cada classificação, você pode escolher se deseja continuar ou sair do programa
- **Interface Amigável**: Layout organizado com separadores visuais para facilitar a leitura

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:

```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real

```
dotnet run --project ClassificadorDeTriangulos.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./ClassificadorDeTriangulos.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:

```
ClassificadorDeTriangulos.ConsoleApp.exe
```

## Arquitetura

O projeto está estruturado seguindo princípios de orientação a objetos:

- **Program.cs**: Responsável pela interface com o usuário e fluxo do programa
- **ClassificadorDeTriangulos.cs**: Classe que encapsula a lógica de validação e classificação de triângulos

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
