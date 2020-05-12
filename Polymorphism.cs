using System;

namespace polymorphism
{
    class Program
    {
        class myPainting
        {
            public virtual void descriptions()
            {
                Console.WriteLine("[Insert Painting Descriptions Here]");
            }
        }

        class Name : myPainting
        {
            public override void descriptions()
            {
                Console.WriteLine("African Giant!");
            }
        }

        class Artist : myPainting
        {
            public override void descriptions()
            {
                Console.WriteLine("Burna Boy");
            }
        }
        class Medium : myPainting
        {
            public override void descriptions()
            {
                Console.WriteLine("Africanized");
            }
        }

        class Year : myPainting
        {
            public override void descriptions()
            {
                Console.WriteLine("Released Date: 2020");
            }
        }

        static void Main(string[] args)
        {
            myPainting mymyPainting = new myPainting();
            myPainting myName = new Name();
            myPainting myArtist = new Artist();
            myPainting myMeidum = new Medium();
            myPainting myYear = new Year();

            mymyPainting.descriptions();
            myName.descriptions();
            myArtist.descriptions();
            myMeidum.descriptions();
            myYear.descriptions();
        }
    }
}
