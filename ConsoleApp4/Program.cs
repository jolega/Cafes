using System;

// Aplicacion maquina de cade
namespace ConsoleApp4

{
    class Program
    {
        static void Main(string[] args)
        {
            // variables a utilizar e inicializacion
            int tipo=0;
            int pequeño = 1500;
            int mediano = 2000;
            int grande = 2500;
            int seleccionado = 0;
            Boolean bandera = true;
            Boolean otro = false;
            double dinero=0;
            Double devuelta = 0;

            // parte donde se solicita el servicio a utilizar
            Console.WriteLine("Maquina de cafe");

            // retorna para realizar varias compras
            do
            {

                // seleccion valida del producto
                do
                {
                    Console.WriteLine("Seleccione el tipo de Cafe que desea comprar \n 1. Pequeño $ 1500  \n 2. Mediano $ 2.000  \n 3. Grande  $2500 ");
                    tipo = int.Parse(Console.ReadLine());

                    // agregar valor a cobrar
                    switch (tipo)
                    {
                        case 1:
                            seleccionado = pequeño;
                            bandera = false;
                            break;
                        case 2:
                            seleccionado = mediano;
                            bandera = false;
                            break;
                        case 3:
                            seleccionado = grande;
                            bandera = false;
                            break;

                        default:
                            Console.WriteLine("Por favor Seleccione una opcion valida \n");
                            bandera = true;
                            seleccionado = 0;
                            break;



                    }
                } while (bandera);


                Console.WriteLine("ingrese el dinero para pagar");
                dinero = double.Parse(Console.ReadLine());

                if (dinero >= seleccionado)
                {

                    Console.WriteLine("Procesando compra .........");

                    devuelta = dinero - seleccionado;

                    Console.WriteLine("Gracias por comprar, su devuelta es de $ " + devuelta);



                }
                else
                {

                    Console.WriteLine("Procesando compra .........");
                    Console.WriteLine("El dinero no es suficiente para cancelar el producto se realiza devolucion por el valor de " + dinero);


                }


                Console.WriteLine("\n Desea Comprar otro Producto  \n 1. Si  \n 2. No ");
                tipo = int.Parse(Console.ReadLine());

                if (tipo == 1) { otro = true;  Console.Clear(); }
                else { otro = false; }


            } while (otro);




        }
    }
}
