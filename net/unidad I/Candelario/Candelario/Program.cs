using System.Numerics;

internal class Program
{


    private static void Main(string[] args)
    {

        string [] Dias = ["L", "M", "M", "J", "V", "S", "D"];
        string Respuesta = "";
        string [,] Enero = new string[4, 6];
        string [,] Febrero = new string[4, 6];
        string [,] Marzo = new string[4, 6];
        string [,] Abril = new string[4, 6];
        string [,] Mayo = new string[4, 6];
        string [,] Junio = new string[4, 6];
        string [,] Julio = new string[4, 6];
        string [,] Agosto = new string[4, 6];
        string [,] Septiembre = new string[4, 6];
        string [,] Octubre = new string[4, 6];
        string [,] Noviembre = new string[4, 6];
        string [,] Diciembre = new string[4, 6];

        Enero[0, 0] = "1";
        Enero[0, 1] = "2";
        Enero[0, 2] = "3";
        Enero[0, 3] = "4";
        Enero[0, 4] = "5";
        Enero[0, 5] = "6";
        Enero[0, 6] = "7";

        Enero[1, 0] = "8";
        Enero[1, 1] = "9";
        Enero[1, 2] = "10";
        Enero[1, 3] = "11";
        Enero[1, 4] = "12";
        Enero[1, 5] = "13";
        Enero[1, 6] = "14";

        Enero[2, 0] = "15";
        Enero[2, 1] = "16";
        Enero[2, 2] = "17";
        Enero[2, 3] = "18";
        Enero[2, 4] = "19";
        Enero[2, 5] = "20";
        Enero[2, 6] = "21";

        Enero[3, 0] = "22";
        Enero[3, 1] = "23";
        Enero[3, 2] = "24";
        Enero[3, 3] = "25";
        Enero[3, 4] = "26";
        Enero[3, 5] = "27";
        Enero[3, 6] = "28";

        Enero[4, 0] = "29";
        Enero[4, 1] = "30";
        Enero[4, 2] = "31";

        //Febrero

        Febrero[0, 0] = "";
        Febrero[0, 1] = "";
        Febrero[0, 2] = "";
        Febrero[0, 3] = "1";
        Febrero[0, 4] = "2";
        Febrero[0, 5] = "3";
        Febrero[0, 6] = "4";

        Febrero[1, 0] = "5";
        Febrero[1, 1] = "6";
        Febrero[1, 2] = "7";
        Febrero[1, 3] = "8";
        Febrero[1, 4] = "9";
        Febrero[1, 5] = "10";
        Febrero[1, 6] = "11";

        Febrero[2, 0] = "12";
        Febrero[2, 1] = "13";
        Febrero[2, 2] = "14";
        Febrero[2, 3] = "15";
        Febrero[2, 4] = "16";
        Febrero[2, 5] = "17";
        Febrero[2, 6] = "18";

        Febrero[3, 0] = "19";
        Febrero[3, 1] = "20";
        Febrero[3, 2] = "21";
        Febrero[3, 3] = "22";
        Febrero[3, 4] = "23";
        Febrero[3, 5] = "24";
        Febrero[3, 6] = "25";

        Febrero[4, 0] = "26";
        Febrero[4, 1] = "27";
        Febrero[4, 2] = "28";
        Febrero[4, 3] = "29";


        //Marzo


        Marzo[0, 0] = "";
        Marzo[0, 1] = "";
        Marzo[0, 2] = "";
        Marzo[0, 3] = "";
        Marzo[0, 4] = "1";
        Marzo[0, 5] = "2";
        Marzo[0, 6] = "3";

        Marzo[1, 0] = "4";
        Marzo[1, 1] = "5";
        Marzo[1, 2] = "6";
        Marzo[1, 3] = "7";
        Marzo[1, 4] = "8";
        Marzo[1, 5] = "9";
        Marzo[1, 6] = "10";

        Marzo[2, 0] = "11";
        Marzo[2, 1] = "12";
        Marzo[2, 2] = "13";
        Marzo[2, 3] = "14";
        Marzo[2, 4] = "15";
        Marzo[2, 5] = "16";
        Marzo[2, 6] = "17";

        Marzo[3, 0] = "18";
        Marzo[3, 1] = "19";
        Marzo[3, 2] = "20";
        Marzo[3, 3] = "21";
        Marzo[3, 4] = "22";
        Marzo[3, 5] = "23";
        Marzo[3, 6] = "24";

        Marzo[4, 0] = "25";
        Marzo[4, 1] = "26";
        Marzo[4, 2] = "27";
        Marzo[4, 3] = "28";
        Marzo[4, 4] = "29";
        Marzo[4, 5] = "30";
        Marzo[4, 6] = "31";

        //Abril

        Abril[0, 0] = "1";
        Abril[0, 1] = "2";
        Abril[0, 2] = "3";
        Abril[0, 3] = "4";
        Abril[0, 4] = "5";
        Abril[0, 5] = "6";
        Abril[0, 6] = "7";

        Abril[1, 0] = "8";
        Abril[1, 1] = "9";
        Abril[1, 2] = "10";
        Abril[1, 3] = "11";
        Abril[1, 4] = "12";
        Abril[1, 5] = "13";
        Abril[1, 6] = "14";

        Abril[2, 0] = "15";
        Abril[2, 1] = "16";
        Abril[2, 2] = "17";
        Abril[2, 3] = "18";
        Abril[2, 4] = "19";
        Abril[2, 5] = "20";
        Abril[2, 6] = "21";

        Abril[3, 0] = "22";
        Abril[3, 1] = "23";
        Abril[3, 2] = "24";
        Abril[3, 3] = "25";
        Abril[3, 4] = "26";
        Abril[3, 5] = "27";
        Abril[3, 6] = "28";

        Abril[4, 0] = "29";
        Abril[4, 1] = "30";
        Abril[4, 2] = "";
        Abril[4, 3] = "";
        Abril[4, 4] = "";
        Abril[4, 5] = "";
        Abril[4, 6] = "";

        //Mayo

        Mayo[0, 0] = "";
        Mayo[0, 1] = "";
        Mayo[0, 2] = "1";
        Mayo[0, 3] = "2";
        Mayo[0, 4] = "3";
        Mayo[0, 5] = "4";
        Mayo[0, 6] = "5";

        Mayo[1, 0] = "6";
        Mayo[1, 1] = "7";
        Mayo[1, 2] = "8";
        Mayo[1, 3] = "9";
        Mayo[1, 4] = "10";
        Mayo[1, 5] = "11";
        Mayo[1, 6] = "12";

        Mayo[2, 0] = "13";
        Mayo[2, 1] = "14";
        Mayo[2, 2] = "15";
        Mayo[2, 3] = "16";
        Mayo[2, 4] = "17";
        Mayo[2, 5] = "18";
        Mayo[2, 6] = "19";

        Mayo[3, 0] = "20";
        Mayo[3, 1] = "21";
        Mayo[3, 2] = "22";
        Mayo[3, 3] = "23";
        Mayo[3, 4] = "24";
        Mayo[3, 5] = "25";
        Mayo[3, 6] = "26";
    
        Mayo[4, 0] = "27";
        Mayo[4, 1] = "28";
        Mayo[4, 2] = "29";
        Mayo[4, 3] = "30";
        Mayo[4, 4] = "31";
        Mayo[4, 5] = "";
        Mayo[4, 6] = "";

        //Junio

        Junio[0, 0] = "";
        Junio[0, 1] = "";
        Junio[0, 2] = "";
        Junio[0, 3] = "";
        Junio[0, 4] = "";
        Junio[0, 5] = "1";
        Junio[0, 6] = "2";

        Junio[1, 0] = "3";
        Junio[1, 1] = "4";
        Junio[1, 2] = "5";
        Junio[1, 3] = "6";
        Junio[1, 4] = "7";
        Junio[1, 5] = "8";
        Junio[1, 6] = "9";

        Junio[2, 0] = "10";
        Junio[2, 1] = "11";
        Junio[2, 2] = "12";
        Junio[2, 3] = "13";
        Junio[2, 4] = "14";
        Junio[2, 5] = "15";
        Junio[2, 6] = "16";

        Junio[3, 0] = "17";
        Junio[3, 1] = "18";
        Junio[3, 2] = "19";
        Junio[3, 3] = "20";
        Junio[3, 4] = "21";
        Junio[3, 5] = "22";
        Junio[3, 6] = "23";

        Junio[4, 0] = "24";
        Junio[4, 1] = "25";
        Junio[4, 2] = "26";
        Junio[4, 3] = "27";
        Junio[4, 4] = "28";
        Junio[4, 5] = "29";
        Junio[4, 6] = "30";

        //Julio

        Julio[0, 0] = "1";
        Julio[0, 1] = "2";
        Julio[0, 2] = "3";
        Julio[0, 3] = "4";
        Julio[0, 4] = "5";
        Julio[0, 5] = "6";
        Julio[0, 6] = "7";

        Julio[1, 0] = "8";
        Julio[1, 1] = "9";
        Julio[1, 2] = "10";
        Julio[1, 3] = "11";
        Julio[1, 4] = "12";
        Julio[1, 5] = "13";
        Julio[1, 6] = "14";

        Julio[2, 0] = "15";
        Julio[2, 1] = "16";
        Julio[2, 2] = "17";
        Julio[2, 3] = "18";
        Julio[2, 4] = "19";
        Julio[2, 5] = "20";
        Julio[2, 6] = "21";

        Julio[3, 0] = "22";
        Julio[3, 1] = "23";
        Julio[3, 2] = "24";
        Julio[3, 3] = "25";
        Julio[3, 4] = "26";
        Julio[3, 5] = "27";
        Julio[3, 6] = "28";

        Julio[4, 0] = "29";
        Julio[4, 1] = "30";
        Julio[4, 2] = "31";
        Julio[4, 3] = "";
        Julio[4, 4] = "";
        Julio[4, 5] = "";
        Julio[4, 6] = "";

        //Agosto

        Agosto[0, 0] = "";
        Agosto[0, 1] = "";
        Agosto[0, 2] = "";
        Agosto[0, 3] = "1";
        Agosto[0, 4] = "2";
        Agosto[0, 5] = "3";
        Agosto[0, 6] = "4";

        Agosto[1, 0] = "5";
        Agosto[1, 1] = "6";
        Agosto[1, 2] = "7";
        Agosto[1, 3] = "8";
        Agosto[1, 4] = "9";
        Agosto[1, 5] = "10";
        Agosto[1, 6] = "11";

        Agosto[2, 0] = "12";
        Agosto[2, 1] = "13";
        Agosto[2, 2] = "14";
        Agosto[2, 3] = "15";
        Agosto[2, 4] = "16";
        Agosto[2, 5] = "17";
        Agosto[2, 6] = "18";

        Agosto[3, 0] = "19";
        Agosto[3, 1] = "20";
        Agosto[3, 2] = "21";
        Agosto[3, 3] = "22";
        Agosto[3, 4] = "23";
        Agosto[3, 5] = "24";
        Agosto[3, 6] = "25";

        Agosto[4, 0] = "26";
        Agosto[4, 1] = "27";
        Agosto[4, 2] = "28";
        Agosto[4, 3] = "29";
        Agosto[4, 4] = "30";
        Agosto[4, 5] = "31";
        Agosto[4, 6] = "";








        Console.WriteLine(Dias[0] +"  "+ Dias[1] + "  " + Dias[2] + "  " + Dias[3] + "  " + Dias[4] + "  " + Dias[5] + "  " + Dias[6]);

        /*switch (Respuesta) 
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "11":
            case "12":
            default:
                Console.WriteLine("Ingresa una opcion valida");
                break;
        
        
        }*/

    }
}