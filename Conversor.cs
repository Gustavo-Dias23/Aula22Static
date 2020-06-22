namespace Aula22Static
{
    public class Conversor
    {
        public static float CotacaoDolar = 5.28f;
        public static float CotacaoEuro = 5.91f;

        public static float ConverterDolarReal(float valor){
            return  valor * CotacaoDolar;
        }
        public static float ConverterRealDolar(float valor){
            return  valor / CotacaoDolar;
        }
        public static float ConverterEuroReal(float valor){
            return  valor * CotacaoEuro;
        }
        public static float ConverterRealEuro(float valor){
            return  valor / CotacaoEuro;
        }
    }
}