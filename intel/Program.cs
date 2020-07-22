using System;

namespace intel
{
    class Program
    {
        public static int AX = 0;
        public static int BX = 0;
        public static int CX = 0;
        public static int DX = 0;

        

        public static void Status()
        {
            
            Console.WriteLine($"AX: {AX}");
            Console.WriteLine($"BX: {BX}");
            Console.WriteLine($"CX: {CX}");
            Console.WriteLine($"DX: {DX}");
        }

        static void Main(string[] args)
        {
            string x = null;
            while(x != "zakoncz")
            {
                Status();
                x = Console.ReadLine();
                if (x == "zakoncz")
                    continue;

                string[] a = x.Split(' ');

                string[] b = a[1].Split(',');

                if (a[0] == "MOV")
                {
                    if (b[1] != "AX" && b[1] != "BX" && b[1] != "CX" && b[1] != "DX")
                    {
                        switch (b[0])
                        {
                            case "AX":
                                AX = int.Parse(b[1]);
                                break;
                            case "BX":
                                BX = int.Parse(b[1]);
                                break;
                            case "CX":
                                CX = int.Parse(b[1]);
                                break;
                            case "DX":
                                DX = int.Parse(b[1]);
                                break;
                        }
                    }
                    if (b[1] == "AX" || b[1] == "BX" || b[1] == "CX" || b[1] == "DX")
                    {
                        switch (b[1])
                        {

                            case "AX":

                                switch (b[0])
                                {
                                    case "AX":
                                        Console.WriteLine("Nie można skopiować");
                                        break;
                                    case "BX":
                                        AX = BX;
                                        //BX = 0;
                                        break;
                                    case "CX":
                                        AX = CX;
                                        //CX = 0;
                                        break;
                                    case "DX":
                                        AX = DX;
                                        //DX = 0;
                                        break;
                                }
                                break;
                            case "BX":

                                switch (b[0])
                                {
                                    case "AX":
                                        BX = AX;
                                        //AX = 0;
                                        break;
                                    case "BX":
                                        Console.WriteLine("Nie można skopiować");
                                        break;
                                    case "CX":
                                        BX = CX;
                                        //CX = 0;
                                        break;
                                    case "DX":
                                        BX = DX;
                                        //DX = 0;
                                        break;
                                }
                                break;
                            case "CX":

                                switch (b[0])
                                {
                                    case "AX":
                                        CX = AX;
                                        //AX = 0;
                                        break;
                                    case "BX":
                                        CX = BX;
                                        //BX = 0;
                                        break;
                                    case "CX":
                                        Console.WriteLine("Nie można skopiować");
                                        break;
                                    case "DX":
                                        CX = DX;
                                        //DX = 0;
                                        break;
                                }
                                break;

                            case "DX":

                                switch (b[0])
                                {
                                    case "AX":
                                        DX = AX;
                                        //AX = 0;
                                        break;
                                    case "BX":
                                        DX = BX;
                                        //BX = 0;
                                        break;
                                    case "CX":
                                        DX = CX;
                                        //CX = 0;
                                        break;
                                    case "DX":
                                        Console.WriteLine("Nie można skopiować");
                                        break;
                                }
                                break;


                        }
                    }
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Nieprawidłowa komenda, spróbuj ponownie.");
                }

                
                

            } 

            
            


        }
    }
}
