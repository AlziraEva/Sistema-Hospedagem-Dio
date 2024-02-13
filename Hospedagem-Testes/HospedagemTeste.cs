using DesafioProjetoHospedagem.Models;

namespace Hospedagem_Testes;

public class UnitTest1
{
    [Fact]
    public void CadastrarHospedesQuantidadeHospedesIgual2ECapacidadeSuiteIgual2RetornarQuantidadeDeHospedesCadastradosNaReservaIgualHa2()
    {
        //Arange
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 10);

        //Act
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        //Assert
        Assert.Equal(hospedes.Count(), reserva.Hospedes.Count());
    }

    [Fact]
    public void NaoCadastrar2HospedesParaCapacidadeSuiteDe1RetornarException()
    {
        //Arange
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 10);

        //Act
        reserva.CadastrarSuite(suite);

        //Assert
        Assert.Throws<ArgumentException>(() =>
        {
            reserva.CadastrarHospedes(hospedes);
        });
    }

    [Fact]
    public void ObterQuantidaHospedesNaReservaHospedesCadastrados2DeveSerIgualAhHospedesDaReserva2()
    {
        //Arange
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 10);

        //Act
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        //Assert
        Assert.Equal(2, reserva.ObterQuantidadeHospedes());
    }

    [Fact]
    public void AplicarDescontoDe10PorcentoEmValorDiario30ReaisPara10DiasReservadosRetornar270()
    {
        //Arange
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 10);

        //Act
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        //Assert
        Assert.Equal(270, reserva.CalcularValorDiaria());
    }

    [Fact]
    public void ValorDiaria30ReaiPara5DiasRetornar150()
    {
        //Arange
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 5);

        //Act
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        //Assert
        Assert.Equal(150, reserva.CalcularValorDiaria());
    }
}