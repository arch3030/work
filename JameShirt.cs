using System;
using System.Collections.Generic;

namespace shirtShop
{
    class Program
    {
        static void Main(string[] args)
        {
            tShirt J1 = new tShirt("L", "Red", 500f, "Nomad Symbol");
            tShirt J2 = new tShirt("M", "Green", 750f, "Street Kid Symbol");
            tShirt J3 = new tShirt("S", "Blue", 625f, "Corpo Symbol");
            user all = new user("Jame Watson", "Jame@gmail.com");
            Address location1 = new Address("Phutthamonthon", "Nakon Prathom", "10180");

            all.sent();
            all.shirt(J1);
            all.shirt(J2);
            all.shirt(J3);
            J1.tshirt1();
            J2.tshirt1();
            J3.tshirt1();
            all.ADDress(location1);
            location1.address1();
            Console.WriteLine("Total Cost : {0} Bath", J1.cost + J2.cost + J3.cost);

            Console.ReadLine();
        }


        class tShirt
        {
            public string size;
            public string color;
            public float cost;
            public string image;
            public tShirt(string valueSize, string valueColor, float valueCost, string valueImage)
            {
                size = valueSize;
                color = valueColor;
                cost = valueCost;
                image = valueImage;
            }
            public void tshirt1()
            {
                Console.Write("Size : {0}",this.size);
                Console.Write("| Color : {0}",this.color);
                Console.Write("| Image : {0}", this.image);
                Console.WriteLine("\nCost : {0}",this.cost);
                
            }
        }
        class user
        {
            public string name;
            public string email;
            public List<tShirt> shirtOrder;
            public List<Address> location;
            public user(string valueName, string valueEmail)
            {
                name = valueName;
                email = valueEmail;
                shirtOrder = new List<tShirt>();
                location = new List<Address>();
            }
            public void shirt(tShirt tshirt)
            {
                shirtOrder.Add(tshirt);
            }
            public void ADDress(Address ADdress)
            {
                location.Add(ADdress);
            }
            public void sent()
            {
                Console.WriteLine("Username : {0}", this.name);
                Console.WriteLine("Email : {0}", this.email);
            }
        }
        class Address
        {
            public string street;
            public string city;
            public string zipCode;
            public Address(string valueStreet, string valueCity, string valueZipcode)
            {
                street = valueStreet;
                city = valueCity;
                zipCode = valueZipcode;
            }
            public void address1()
            {
                Console.WriteLine("131 / 75 Street : {0}, city : {1}, Zipcode : {2}",this.street,this.city,this.zipCode);
            }
        }
        class shoppingCart
        {
            public List<tShirt> TShirt;
            public List<Address> ADDRESS;

            public shoppingCart()
            {
                TShirt = new List<tShirt>();
                ADDRESS = new List<Address>();
            }
        }
    }
    
}
