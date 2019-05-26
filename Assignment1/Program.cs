using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }
        public void Go()
        {
            Rectangle obj = new Rectangle();
           
            bool exitProgram = false;


            string len = string.Empty;
            int length = 0;
            do
            {
                Console.Write("Enter the Length of Rectangle ");
                len = Console.ReadLine();
            } while (!(ValidateInt(len)));
            length = int.Parse(len);
            obj.SetLength(length);





            string widt = string.Empty;
            int width = 0;
            do
            {
                Console.Write("Enter the Width of Rectangle ");
                widt = Console.ReadLine();
            } while (!(ValidateInt(widt)));
            width = int.Parse(widt);
            obj.SetWidth(width);

            Rectangle secondConstructor = new Rectangle(length, width);





            do
            { 
               

                
               
                    ArrayList Schedule = new ArrayList();

                    Schedule.Add(":  Get Rectangle Length");
                    Schedule.Add(":  Change Rectangle Length");
                    Schedule.Add(":  Get Rectangle Width");
                    Schedule.Add(":  Change Rectangle Width");
                    Schedule.Add(":  Get Rectangle Perimeter");
                    Schedule.Add(":  Get Rectangle Area");
                    Schedule.Add(":  Exit");



                    for (int i = 0; i < Schedule.Count; i++)
                    {
                        Console.WriteLine("{0}. {1}", i + 1, Schedule[i]);
                    }
                

                

                string menuSelected = string.Empty;
                do
                {
                    menuSelected = Console.ReadLine();
                } while (!ValidateInt(menuSelected));

                int menuOption = int.Parse(menuSelected);

                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Length is :{0}", obj.GetLength());
                        break;
                    case 2:
                        string leng = string.Empty;
                        int lengthl = 0;
                        do
                        {
                            Console.Write("Enter New Length : ");
                            leng = Console.ReadLine();
                        } while (!(ValidateInt(leng)));
                        lengthl = int.Parse(leng);
                        Console.WriteLine("New Length is :{0}",obj.SetLength(lengthl));
                        break;
                    case 3:
                        Console.WriteLine("Width is :{0}", obj.GetWidth());
                        break;
                    case 4:
                        string wid = string.Empty;
                        int widthw = 0;
                        do
                        {
                            Console.Write("Enter New Width : ");
                            wid = Console.ReadLine();
                        } while (!(ValidateInt(wid)));
                        widthw = int.Parse(wid);
                        Console.WriteLine("New Width is :{0}", obj.SetWidth(widthw));
                        break;
                    case 5:
                        Console.WriteLine("Perimeter is :{0}", obj.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Area is  :{0}", obj.GetArea());
                        break;
                    case 7:
                        exitProgram = true;
                        break;
                    
                    default:
                        Console.WriteLine("Please, Select Valid Input");
                        break;
                }






                } while (!exitProgram) ;




            

}



        bool ValidateInt(string userinput)
        {
            int integer = 0;

            if (int.TryParse(userinput, out integer))
            {
                if (integer > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



    }

    
}
