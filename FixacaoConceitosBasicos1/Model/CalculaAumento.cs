namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAumento
    {
        public static double Calcular(double salario, double aumento)
        {
            return salario + (salario * aumento / 100);
        }
    }
}
