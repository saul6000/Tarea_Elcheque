using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores.clases
{
    public class NumLetras
    {
        public static string[] unidades = new string[]{"  ","Uno"," Dos ","Tres","Cuatro","Cinco","Seis","Siete",
            "Ocho","Nueve","Diez","Once","Doce","Trece","Catorce","Quince","Dieciseis,","Diecisiete","Dieciocho","Diecinueve"};
        public static string[] decenas = new string[]{" "," Diez " ,"Veinte ", "Treinta","Cuarenta","Cincuenta","Sesenta","Setenta",
            "Ochenta","Noventa"};
        public static string[] centenas = new string[]{" ","Ciento","Dociento ","Tresciento","Cuatrociento","Quinientos","Seiscientos","Setecientos",
            "Ochocientos","Novecientos"};
        public static string[] complementos = new string[] { " Mil ", " Un Millon ", " Millones ", " Veinti ", " Cero " };
        public static string getunidades(int num)
        {
            string aux = " ";
            if (num < 20)
            {
                aux = unidades[num];
            }
            return aux;
        }
        public static string getdecenas(int num)
        {
            string aux = " ";

            if (num >= 20 && num < 100)
            {
                aux = decenas[num / 10];
                if (num % 10 != 0) aux = aux + " y " + unidades[num % 10];

            }
            return aux;
        }
        public static string getcentenas(int num)
        {
            string aux = " ";
            if (num < 1000)
            {
                aux = centenas[num / 100];
                if (num % 100 < 20)
                {
                    aux = aux + " " + getunidades(num % 100);
                }
                else
                    aux = aux + " " + getdecenas(num % 100);
            }
            return aux;
        }
        public static string getmillares(int num)
        {
            string aux = " ";
            if (num > 100000 && num < 200000)
            {
                aux = getcentenas((num / 1000)) + complementos[0] + getcentenas(num % 1000);
            }
            if (num < 1000000)
            {
                aux = getcentenas(num / 1000) + complementos[0] + getcentenas(num % 1000);
            }
            if (num < 2000)
            {
                aux = complementos[0] + getcentenas(num % 1000);
            }
            return aux;
        }
        public static string getmillones(int num)
        {
            string aux = " ";

            if (num == 1000000)
            {
                aux = complementos[1];
            }

            else if (num % 1000000 == 0)
            {

                aux = getunidades(num / 1000000) + complementos[2];
            }
         if (num > 1000000 && num <2000000 && num % 1000000 >999)
            {
                aux = complementos[1] + getcentenas((num / 1000) % 1000) + complementos[0] + getcentenas(num % 1000);
            }
         else
            {
                aux = complementos[1] + getcentenas((num / 1000) % 1000) + getcentenas(num % 1000);
            }
            
            if (num >=2000000 && num <10000000 && num % 1000000 > 999)
            {
                aux = getunidades(num / 1000000) + complementos[2] + getcentenas((num / 1000) % 1000) + complementos[0] + getcentenas(num % 1000);
            }
            else if (num >= 2000000 && num < 10000000 && num % 1000000 < 999)
            {
                aux = getunidades(num / 1000000) + complementos[2] + getcentenas((num / 1000) % 1000)  + getcentenas(num % 1000);
            }
            return aux;
        }
        public static string getLetras(int num)
        {
            string aux = "";

            if (num < 20) aux = getunidades(num);

            else if (num >= 20 && num < 100)
            {
                aux = getdecenas(num);
            }
            if (num == 100)
            {
                aux = getcentenas(num).Substring(0, 4);
            }
            else if (num < 1000)
            {
                aux = centenas[num / 100];
                if (num % 100 < 20)
                {
                    aux = aux + " " + getunidades(num % 100);
                }
                else
                    aux = aux + " " + getdecenas(num % 100);
            }
            else if (num == 100000)
            {
                aux = getmillares(num).Substring(0, 4) + complementos[0];
            }
            else if (num < 1000000)
            {
                aux = getmillares(num);
            }
            else if (num < 10000000)
            {
                aux = getmillones(num);
            }
            if (num == 0)
            {
                aux = "cero";
            }
            return aux;
        }
    }
}
