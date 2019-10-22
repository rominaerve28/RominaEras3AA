using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciounocancha
{
    class Program
    {
        static void Main(string[] args)
        {

            // Subtotal, Descuento, IVA, Total Final, Valor Pagado y Saldo Pendiente. 
            Prestamo prestamo = new Prestamo();
        
            Prestamo Prestamo = new Prestamo();
            Console.WriteLine(Prestamo.Costo);
            Console.WriteLine("Ingrese las horas que va a usar la cancha");
            Prestamo.Horas = int.Parse(Console.ReadLine());
            Console.WriteLine(Prestamo.Horas);
            Console.WriteLine("Ingrese el descuento que desea aplicar");
            Prestamo.Descuento = int.Parse(Console.ReadLine());
            Console.WriteLine("El subtotal natural es:" +Prestamo.Subtotal);
            Console.WriteLine("El descuento es:"+ Prestamo.Descuento);
            Console.WriteLine("El subtotal con descuento es:"+ Prestamo.Subtotal2);
            Console.WriteLine("El valor del iva es:"+ Prestamo.Iva);
            Console.WriteLine("El total a pagar es:"+ Prestamo.Final);
            Console.WriteLine("Ingresar el anticipo");
            Prestamo.Pagado = int.Parse(Console.ReadLine());
            Console.WriteLine("El valor pagado es:"+ Prestamo.Pagado);
            
            //Console.WriteLine("El valor pendiente es:" + Prestamo.Pendiente);

           // Console.WriteLine("El estado de la compra es:" + Prestamo.Estado);
            Console.ReadKey();
        }
      

    }
}
