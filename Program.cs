using System;
using System.Globalization;

namespace CreditCardApplication
{
    class Program
    {
        static void Main(string[] args)
        {



            CreditCart creditCart = new CreditCart("1111111111111111", "İsa Aras","19/12/23", 789);
            creditCart.cardControl();
            Console.WriteLine(creditCart.getInfo() + "\n \n");


            creditCart.setInfos("232133232313","Fatih Yol","09/12/22");
            creditCart.cardControl();
            Console.WriteLine(creditCart.getInfo() + "\n \n");






            creditCart.setInfos("555555555555435355555","Ramazan Çalışkan","02/12/19");
            creditCart.cardControl();
            Console.WriteLine(creditCart.getInfo() + "\n \n");




        }

    }
}
