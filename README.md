# Projeto de Álgebra

Programa desenvolvido em C# para calcular o determinante de uma matriz quadrada de ordem *n*, utilizando o método de eliminação gaussiana (transformação em matriz triangular).

## Sobre o projeto

Este projeto foi criado como trabalho para a disciplina de Álgebra, a pedido do professor, por alunos do curso de **Bacharelado em Tecnologia da Informação (BTI)** da **UFERSA – Campus Pau dos Ferros**.

## Integrantes

- José Vítor do Nascimento Duarte Bezerra
- Francisco Eduardo de Andrade Oliveira
- Samuel Levi de Lima Lopes

## Como funciona

O programa solicita ao usuário:
1. A ordem *n* da matriz;
2. Os valores da matriz, linha por linha.

Em seguida, calcula o determinante aplicando eliminação gaussiana:
- Realiza trocas de linha quando necessário (pivô igual a zero), invertendo o sinal do determinante a cada troca;
- Zera os elementos abaixo de cada pivô;
- Multiplica os elementos da diagonal principal da matriz triangularizada para obter o determinante final.

## Como executar

```bash
dotnet run
```

Ou compile e execute normalmente um projeto C# (.NET).

## Exemplo de uso

```
Digite a ordem da matriz (n para uma matriz n x n): 3
Digite os valores da matriz, linha por linha (separados por espaço):
Linha 1: 1 2 3
Linha 2: 4 5 6
Linha 3: 7 8 10

Determinante = -3
```
