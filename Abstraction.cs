using System;

namespace abstraction
{
    class Program
    {
        abstract class Name
        {
            public void myName()
            {
                Console.WriteLine("African Giant ");
            }
        }

        class Painter : Name
        {
            public void myPainter()
            {
                Console.WriteLine("Name: Jungle Justice ");
            }
        }
        class Medium : Painter
        {
            public void myMedium()
            {
                Console.WriteLine("Medium: Africanized!");
            }
        }

        class Year : Medium
        {
            public void myYear()
            {
                Console.WriteLine("Year: 2020!");
            }
        }
        class PublicMessage : Year
        {
            public void myPublicMessage()
            {
                Console.WriteLine("Welcome to the Africa!");
            }
        }
        static void Main(string[] args)
        {
            PublicMessage myPubMsg = new PublicMessage();
            myPubMsg.myPublicMessage();
            myPubMsg.myName();
            myPubMsg.myPainter();
            myPubMsg.myMedium();
            myPubMsg.myYear();

        }
    }
}