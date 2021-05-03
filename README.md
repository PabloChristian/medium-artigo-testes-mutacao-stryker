## Objetivo
Esse artigo possui como objetivo de ser uma referência de implementação técnica, do artigo criado no medium "Testes de Mutação👽️: implemente testes eficazes e de alta qualidade"

## Testes de Mutação
A ferramenta utilizada realiza uma cópia da nossa aplicação, para introduzir erros e alterações no código, com o objetivo de verificar se os nossos testes irão identificar essas falhas. Bugs, ou mutantes 👽️, são inseridos no código e os testes são executados em cima do código mutado. Se o teste falhar, o mutante é considerado morto 💀, e aquele trecho de código alterado é considerado como coberto pelos testes. Se o teste não falhar, então o mutante sobreviveu 👾️. Veja que o nosso objetivo aqui é fazerem os testes falharem, e os mutantes serem eliminados.

Ao final do processo, a ferramenta irá gerar um relatório detalhando quais mutantes foram mortos e quais sobreviveram. Este relatório irá incluir uma métrica importante, chamada de Mutation Score, a qual é calculada da seguinte maneira:

Mutation Score = Mutantes mortos / Total de mutantes

Assim, se matarmos oito de dez mutantes, teremos uma pontuação de 80%.

## Tecnologias
<ul>
<li>.NET</li>
<li>C#</li>
<li>xUnit</li>
<li>Stryker</li>
</ul>

## Executando o Stryker

<img src="https://cdn-images-1.medium.com/max/800/1*SuBf3wev2NB32TAslXOYyQ.png" />


Na raiz do projeto de testes, execute o comando abaixo:
```bash
dotnet-stryker
```