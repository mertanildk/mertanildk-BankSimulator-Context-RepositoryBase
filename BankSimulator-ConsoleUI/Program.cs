using Business.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {

        //müşteri olacak
        //banka olacak
        //müşteri username password tutan bir yer olacak 
        //yeni müşteri
        //müşteri silme


        //müşteri işlemleri
        //yeni müşteri
        //isim
        //soyisim
        //tcNo
        //adres(il)
        //yaş <18 olamaza
        //username belirle
        //şifre belirle


        //müşteri işlemleri
        //para çekme
        //para yatırma
        //tutar görüntüleme
        //para gönderme
        //password değiştirme
        //abonelik iptal ==içerde parası varsa paranızı çekiniz para==0 olacak,



        //bankaaccount 
        //yeni müşteri hesap açtı 
        //hesap id random olsun 12-13 basamaklı.
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //customerManager.Add(new Customer
            //{
            //    CustomerName = "Enes",
            //    CustomerSurname = "Demiroğ",
            //    NationalityId = "12344612334",
            //    Password = "33351212",
            //    Age = 32,
            //    Money = 120000
            //});


            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CustomerName.PadRight(10)+" ---- ".PadRight(7)+customer.Money+" TL");
            }


        }
    }
}
