using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciounocancha
{
    public class Prestamo
    {

        

        private String cancha;

        public String Cancha
        {
            get { return cancha; }
            set { cancha = value; }
        }


        private float costo;

        public float Costo
        {
            get {
                Console.WriteLine("Seleccione la cancha ");
                Console.WriteLine("1. De Futbol");
                Console.WriteLine("2. De Futbolito");
                Console.WriteLine("3. De Indor");
                Console.WriteLine("4. De Básquet");
                int canch = int.Parse(Console.ReadLine());
                while (canch < 1 && canch > 4)
                {
                    Console.WriteLine("La opción ingresada no es validad, vuelva a intentarlo.");
                    canch = int.Parse(Console.ReadLine());
                }


                switch (canch)
                {

                    case 1:
                        costo = 20;
                        break;
                    case 2:
                        costo = 15;
                        break;
                    case 3:
                        costo = 5;
                        break;
                    case 4:
                        costo = 5;
                        break;

                }
                return costo;

            }
        }

        private int horas;

        public int Horas
        {
            get { return horas; }
            set { 
               while (horas >= 3)
                {
                    throw new Exception("No se hace prestamo mayor a 3 horas");
                    value = int.Parse(Console.ReadLine());

                }
                horas = value;
            }
        }

        private float descuento;

        public float Descuento
        {
            get { return descuento; }
            set
            {

                if (value != 10 && value != 20)
                {
                    throw new Exception(" el valor no puede ser diferente a 10 o 20 ");
                    value = int.Parse(Console.ReadLine());


                }

                descuento = value;

            }
        }



        private float subtotal;

        public float Subtotal
        {
            get { return subtotal = costo*horas; }
        }

        private float iva;

        public float Iva
        {

            get
            {
                return iva= Subtotal * 0.12f;

            }
            
        }



        private float subtotal2;

        public float Subtotal2
        {
            get {
                return subtotal2 = subtotal - descuento;

            }

        }


       

        private float final;

        public float Final
        {
           get {return final= subtotal2 + iva; }
           
        }


        private float pagado;

        public float Pagado
        {
            get { return pagado; }
            set {
                while ((final * 50) / 100 >= value)
                {
                    Console.WriteLine("El anticipo debe ser mayor al 50% del valor a pagar");
                    Console.WriteLine("Reingrese el anticipo");
                    value = int.Parse(Console.ReadLine());
                }
                pagado = value;
            }
        }

        private float pendiente;

        public float Pendiente
        {
            get { return pendiente=  final-pagado ; }
         
        }

        private string estado;

        public string Estado    
        {
            
           get { 
                if (pendiente==0 )
                {
                    Console.WriteLine("PAGADO");
                } else 
                {
                    Console.WriteLine("PENDIENTE");
                }



                return estado; }

        }












    }





    }

