namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            double valorDiario = 100.0;
            double valorKm = 0.50;

            int quilometragemRodada = quilometragemInicial - quilometragemFinal;
            double valorTotal = (dias * valorDiario) + (quilometragemRodada * valorKm);

            return valorTotal;
        }
    }
}
