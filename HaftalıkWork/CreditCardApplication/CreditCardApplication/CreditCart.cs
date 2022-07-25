using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CreditCardApplication
{
    class CreditCart
    {

        private String number;
        private String holderName;
        private string expirationDate;
        private int ccv;

      


        public CreditCart(string number, string holderName,string expirationDate, int ccv)
        {


       

            this.number = number;
            this.holderName = holderName;
            this.expirationDate = expirationDate;
            this.ccv = ccv;


        }

 

        public void setInfos(string number)
        {
            this.number = number;
           
        }

        public void setInfos(string number, string holderName,string expirationDate)
        {
            this.number = number;
            this.expirationDate = expirationDate;
            this.holderName = holderName;
        

        }





        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string HolderName
        {
            get
            {
                return holderName;
            }

            set
            {
                holderName = value;
            }
        }

        public string ExpirationDate
        {
            get

                {
                return expirationDate;
            }

            set
            {
                expirationDate = value;
            }
        }


        public int CCv
        {
            get
            {
                return ccv;
            }

            set
            {
                ccv = value;
            }
        }











        public DateTime ConvertToDateTime()
        {

            DateTime dtFinaldate; string sDateTime;
            try
            {
                dtFinaldate = Convert.ToDateTime(expirationDate);

                if (dtFinaldate.Year <= 2022)
                {
                  
                    Console.WriteLine("Kart Tarihi Geçersiz Lütfen Tarihi Değiştirin.");
                }
                else
                {
                    
                    Console.WriteLine("Kart Tarihi Geçerli Kart Onaylandı");
                }

            }
            catch (Exception e)
            {
                string[] sDate = expirationDate.Split('/');
                sDateTime = sDate[0] + '/' + sDate[1] + '/' + sDate[2];
                dtFinaldate = Convert.ToDateTime(sDateTime);

              

            }
            return dtFinaldate;
        }


        










        public void cardControl()
        {
            try
            {
                if (number.Length != 16)
                {
                    throw new CreditCartException("Kart Numarası Geçersiz Lütfen 16 Haneli Olacak Şekilde Tanımlayınız. !!!");
                    
                }
                else
                {
                    Console.WriteLine("Geçerli Kart Numarası Doğru Tanımlanmıştır.");

                }
                return;
               
            }
            catch (CreditCartException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


      public class CreditCartException : System.Exception
        {
            public CreditCartException()
                : base()
            { }

            public CreditCartException(String message)
                : base(message)

            { }

            public CreditCartException(String message, Exception innerException)
                : base(message, innerException)
            { }

            protected CreditCartException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            { }
        }


        public String getInfo()
        {

            return "Kart No :"+number+"\t"+"Ad Soyad :"+holderName+"\t"+"Tarih :"+ConvertToDateTime().ToString().TrimEnd('0',':')+ "\t"+"Güvenlik Kodu :"+ccv;
          
        }


      

    }
}
