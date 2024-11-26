# Aplicação Console .NET - Bolsa Ninja

### Descrição
Esta aplicação console em .NET demonstra o uso de uma classe genérica `BolsaNinja` para armazenar e exibir diferentes tipos de itens ninja, como Kunais, Shurikens e Pergaminhos.

## Classes Utilizadas

### BolsaNinja
Classe genérica que armazena itens de diferentes tipos.

### Kunais
Classe que representa uma kunai com uma descrição.

### Shuriken
Classe que representa uma shuriken com um tamanho.

### Pergaminho
Classe que representa um pergaminho com uma descrição.

## Estrutura do Código

- Para utilizar a claasse generia é necessario declara-la na classe princial
- Após declarar a classe, utilizamos uma de seus metodos de adicionar um Objeto generico

Segue Exemplo:

```csharp
        BolsaNinja<Object> bolsaNinja = new BolsaNinja<Object>();

        bolsaNinja.AddItens(new Kunais("Explosiva"));
        bolsaNinja.AddItens(new Shuriken(4));
        bolsaNinja.AddItens(new Pergaminho("Invocação do sapo"));
````

## Como Executar
- **Clone o repositório** ou copie o código para o seu ambiente local.
- **Navegue até a pasta do projeto** no terminal.
- **Execute o comando** `dotnet run` para compilar e executar a aplicação.

### Requisitos
- .NET SDK instalado
- Ambiente de desenvolvimento configurado para C#
