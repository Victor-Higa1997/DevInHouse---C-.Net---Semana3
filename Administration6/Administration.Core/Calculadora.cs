namespace Administration.Core
{
    public static class Calculadora 
    {
        public static int somar(int valor1, int valor2)
        {
            return valor1 + valor2; 
        }

        public static int somar(int valor1, int valor2, int valor3)
        {
            return valor1 + valor2 + valor3;
        }
        public static int subtrair(int valor1, int valor2)
        {
            return valor1 - valor2; 
        }
        public static int subtrair(int valor1, int valor2, int valor3)
        {
            return valor1 - valor2 - valor3;
        }
        public static int multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public static int multiplicar(int valor1, int valor2, int valor3)
        {
            return valor1 * valor2 * valor3;
        }
        public static int dividir(int valor1, int valor2)
        {
            return (valor1 / valor2);
        }
    }
}