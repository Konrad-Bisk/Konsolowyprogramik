using System;

namespace ConsoleApp
{
    class Program
    {
        private static int w = 0;


        static void Main(string[] args)
        {
            bool ok;
            do
            {       Console.WriteLine("wpisz liczbe 1 ");
                    string liczba1 = Console.ReadLine();
                    Console.WriteLine("wpisz liczbe 2");
                    string liczba2 = Console.ReadLine();
                    Console.WriteLine("wpisz liczbe 3");
                    string liczba3 = Console.ReadLine();
                    Console.WriteLine("wpisz liczbe 4");
                    string liczba4 = Console.ReadLine(); 
                    int a = int.Parse(liczba1); //konwersja stringa wprowadzona z konsoli na int-a
                    int b = int.Parse(liczba2);
                    int c = int.Parse(liczba3);
                    int h = int.Parse(liczba4);
                if (a>0 && b>0 && c>0 && h>0) // || lub , && i , !zaprzeczenie
                {
                    if (a == b && b == c || c==h || h==c)
                    {
                        Console.WriteLine("Z podanych liczb można obliczyć Pole kwadratu. Czy chcesz policzyć ?");
                        string tak = Console.ReadLine();
                        if (tak == "tak")
                        {
                            Pole_kwadrat(a);

                        }
                        else
                        {
                            Home();


                        }
                    }

                    if (a > b || b > a)   // || lub , && i , !zaprzeczenie *** #Prostokąt
                    {
                        Console.WriteLine("Z podanych liczb można obliczyć Pole prostokąta. Czy chcesz policzyć ?");
                        string tak = Console.ReadLine();
                        if (tak == "tak")
                        {
                            Pole_prostokat(a, b);

                        }
                        else
                        {

                            Home();

                        }
                    }

                        ok = true;

                }

                else { ok = false;
                    Console.WriteLine("Błędne liczby.Wprowadz poprawne liczby wieksze od zera ! ");
                }
            } while (!ok);

            /*     
                    //bool isNumber = int.TryParse(liczba4, out h);
                    if (a <0)
                    {
                    Console.WriteLine("Nie prawidłowa wartośc zmiennej " + "liczba1") ;

                    }
                    if (b <= 0) 
                    {
                    Console.WriteLine("Nie prawidłowa wartośc zmiennej " + "liczba2");

                    }
                    if (c <= 0) 
                    {
                    Console.WriteLine("Nie prawidłowa wartośc zmiennej " + "liczba3");

                    }
                    if (!isNumber) 
                    {
                        Console.WriteLine("Nie prawidłowa wartośc zmiennej " + "liczba4");


                     }


                        if (a > b || b > a)   // || lub , && i , !zaprzeczenie *** #Prostokąt
                        {
                            Console.WriteLine("Z podanych liczb można obliczyć Pole prostokąta. Czy chcesz policzyć ?");
                            string tak = Console.ReadLine();
                            if (tak == "tak")
                            {
                                Pole_prostokat(a, b);

                            }
                            else
                            {

                                Home();

                            }


                        }

                            if (a == b && h == a && h == b && h == c)  //#Kwadrat
                            {
                                Console.WriteLine("Z podanych liczb można obliczyć Pole kwadratu. Czy chcesz policzyć ?");
                                string tak = Console.ReadLine();
                                if (tak == "tak")
                                {
                                    Pole_kwadrat(a);

                                }
                                else
                                {
                                    Home();



                                }


                            }

                            if ((a > b) && (h < b) && (c < b - 2)) // # trójkąt różnoboczny
                            {
                                Console.WriteLine("Z podanych liczb można obliczyć Pole trójkąta różnobocznego . Czy chcesz policzyć ?");
                                string tak = Console.ReadLine();
                                if (tak == "tak")
                                {
                                    Pole_trojkata_roznobocznego(a, h);

                                }
                                else
                                {
                                    Home();



                                }

                            }

                            */













        }

        static int Pole_trojkata_roznobocznego(int a, int h)
            {
                Console.WriteLine("Pole jest równe " + (w = (a*h)*1/2));

                return w;
            }

            static  int Pole_prostokat(int a, int b)
                {
                    Console.WriteLine("Pole jest równe " +  (w = a * b));

                return w;
                }


            static int Pole_kwadrat(int a)
            {
                Console.WriteLine("Pole jest równe " + (w = a*a ));
                return w;
            }

            static void Home()
            {


                Console.WriteLine("Dziękujemy");



            }

        }
    }

