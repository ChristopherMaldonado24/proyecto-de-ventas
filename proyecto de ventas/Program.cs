using System;
using System.ComponentModel.Design;
class Proyecto
{


    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de Ventas el Ranchito");
        Console.Write("Favor Ingrese su Nombre: ");
        string Nombre = Console.ReadLine();
        Console.Write("Favor Ingrese Edad :");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Seleccione la Categoria del Producto a comprar");
        Console.WriteLine("1. Carnes");
        Console.WriteLine("2. Refrescos");
        Console.WriteLine("3. Cereales");
        Console.WriteLine("4. Lacteos");
        Console.WriteLine("5. churros");
        string categoria = Console.ReadLine();
        double Precio = 0;


        string producto;
        if (categoria == "1")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Tajo Premiun 110 Lps");
            Console.WriteLine("2. Carne para bistec 90 Lps");
            Console.WriteLine("3. Pollo deshuesado 60 Lps");
            producto = Console.ReadLine();

            if (producto == "1")
            {
                Precio = 110;
            }
            else if (producto == "2")
            {
                Precio = 90;
            }
            else if (producto == "3")
            {
                Precio = 60;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }
        }
        else if (categoria == "2")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Coca Cola 25Lps");
            Console.WriteLine("2. Fresca 23 Lps");
            Console.WriteLine("3. Canada Dry 28 Lps");
            producto = Console.ReadLine();

            if (producto == "1")
            {
                Precio = 25;
            }
            else if (producto == "2")
            {
                Precio = 23;
            }
            else if (producto == "3")
            {
                Precio = 28;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }

        }
        else if (categoria == "3")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Zucaritas 80 Lps");
            Console.WriteLine("2. Fruts Loops 95 Lps");
            Console.WriteLine("3. Choco Crispis 110 Lps");
            producto = Console.ReadLine();

            if (producto == "1")
            {
                Precio = 80;
            }
            else if (producto == "2")
            {
                Precio = 95;
            }
            else if (producto == "3")
            {
                Precio = 110;
            }
            else
            {
                Console.WriteLine("no tenemos el producto seleccionado");
            }
            Console.WriteLine("Seleccione el tamaño del producto");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Mediano");
            Console.WriteLine("3. Grande");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño == 1)
            {
                Precio = Precio;

            }
            else if (tamaño == 2)
            {
                Precio = Precio * 1.2;
            }
            else if (tamaño == 3)
            {
                Precio = Precio * 1.2 * 1.3;
            }
            Console.WriteLine($"El precio del producto es : {Precio}");
            Console.Write($"Ingrese la cantidad deseada:");
            int Cantidad = Convert.ToInt32(Console.ReadLine());
            double subtotal = (Precio * Cantidad);
            double impuesto = 0;
            if (categoria == "1")
            {
                impuesto = 0;
            }
            else
            {
                impuesto = subtotal * 0.15;
            }
            double descuento = 0;
            if (Edad >= 60)
            {
                descuento = subtotal * 0.3;
            }
            else
            {
                descuento = 0;
            }

            double Total = subtotal + impuesto - descuento;
            Console.WriteLine($"El valor a pagar es de: {Total} usted esta pagando un impuesto de {impuesto} y un descuento de: {descuento}");

        }
    }
}