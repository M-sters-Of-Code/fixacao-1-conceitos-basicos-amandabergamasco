namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaDesconto
    {
        public static double Calcular(double valor, double desconto)
        {
            return valor - (valor * desconto / 100);
        }
    }
}
