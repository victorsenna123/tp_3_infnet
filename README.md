## Lógica para Implementação da Interface `Descontavel`

Neste exercício, foi solicitada a criação de uma interface chamada `Descontavel` com um método `AplicarDesconto(double porcentagem)`. Além disso, era necessário implementar essa interface nas classes `Produto` e `ProdutoPerecivel`, de forma que o desconto seja aplicado ao preço do produto.

### Interface Descontavel

A interface `Descontavel` foi criada com um único método `AplicarDesconto(double porcentagem)`. Esta interface permite que diferentes classes implementem uma lógica específica para aplicar descontos aos produtos.

### Implementação nas Classes Produto e ProdutoPerecivel

Ambas as classes `Produto` e `ProdutoPerecivel` implementam a interface `Descontavel`. Isso significa que ambas as classes devem conter a implementação do método `AplicarDesconto`.

Na classe `Produto`, o método `AplicarDesconto` é utilizado para reduzir o preço do produto de acordo com a porcentagem de desconto fornecida.

Na classe `ProdutoPerecivel`, o método `AplicarDesconto` também é implementado, mas nesta classe, ele utiliza a palavra-chave `new` para esconder o método da classe base `Produto`. Isso permite que a classe `ProdutoPerecivel` tenha sua própria implementação do método `AplicarDesconto`, que pode ser diferente da implementação na classe `Produto`. Neste caso, a lógica para aplicar descontos pode ser personalizada para produtos perecíveis, como aplicar um desconto adicional com base na proximidade da data de validade.

Essa abordagem permite uma maior flexibilidade e reutilização de código, pois as classes podem implementar a interface de maneira diferente de acordo com suas necessidades específicas.
