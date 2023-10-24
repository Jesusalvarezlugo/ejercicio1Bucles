using ejercicio1Bucles.servicios;

namespace ejercicio1Bucles.controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            operacionesInterfaz mi = new operacionesImplementacion();

            numero=mi.PedirNumero();

            mi.Suma(numero);
        }
    }
}
