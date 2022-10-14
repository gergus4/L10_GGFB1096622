internal class Program
{
    static bool Login(string contra, string usuario)
    {

        if (contra == "asdasd" && usuario == "usuario1")
        {
            return true;
        }
        else
        {

            return false;
        }


    }

    static void Main(string[] args)
    {
        string contra;
        string usuario;
        int intento = 0;

        bool entrada;
        do
        {
            Console.WriteLine("Bienvenido al inicio de sesión");
            
            Console.WriteLine("Ingrese el usuario");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña");
            contra = Console.ReadLine();

            entrada = Login(contra, usuario);
            if (entrada == true)
            {
                Console.WriteLine("Ha entrado con éxito");
                break;
            }
            else
            {
                intento++;

                Console.WriteLine("Credenciales inválidas, repita el proceso");
                Console.WriteLine("Cantidad de intentos: " + intento);
            }
        } while (intento < 3);
        Console.ReadKey();
    }

}

