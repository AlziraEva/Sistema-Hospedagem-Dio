# Sistema de Hospedagem 🏨
![status](https://img.shields.io/badge/status-%20concluido-green)

## Sobre o projeto 📝
Construção de um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Utilizando a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos. Sendo feito o cálculo correto nos valores dos métodos da classe Reserva, que trás a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Funcionalidades 🔄
- Cadastrar hospedes
- Cadastrar suites
- Obtem a quantidade de hospedes cadastrados na reserva
- Calcular valor da diaria na reserva

## Regras e validações 📌
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## ⚙Tecnologias e Linguagens Utilizadas
<div>
<img align="center" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" 
title="C#"  width="50" height="50"/>
<img align="center" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" 
title=".Net"  width="50" height="50"/>
<img align="center" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-plain-wordmark.svg" 
title="Git" width="50" height="50"/>
</div>          

## 🤝Contribuindo

1. Faça um fork deste repositório

2. Crie uma branch para sua feature:

```
    git checkout -b feature/nova-feature
```
3. Faça commit das suas alterações:

```
    git commit -m Adiciona nova feature
```
    
4. Envie as alterações para o seu fork:

```     
    git push origin feature/nova-feature
``` 
 
5. Abra um pull request neste repositório

## 👩‍💻Autora

- [Alzira Eva](https://github.com/AlziraEva)👩
