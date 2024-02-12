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
}