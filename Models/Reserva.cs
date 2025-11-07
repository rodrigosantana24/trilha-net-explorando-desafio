namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {}

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            bool capacidadeSuficiente = hospedes.Count <= Suite.Capacidade;
            if (capacidadeSuficiente){
                Hospedes = hospedes;
            }
            else{
                throw new InvalidOperationException("Capacidade insuficiente para o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria(){
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10){
                valorTotal -= valorTotal * 0.1M; ;
            }

            return valorTotal;
        }
    }
}