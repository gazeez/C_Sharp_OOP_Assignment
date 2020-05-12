using System;

namespace encapsulation
{
    class Painting{
              private string paintingName;
              private string artist;
              private string medium;
              private string year;
              
              public string MyPaintingName 
              { 
                  get { return paintingName; } 
                  set { paintingName = value;}
              }  
              public string MyArtist 
              { 
                  get { return artist; } 
                  set { artist = value;}
              }
              public string MyMedium 
              { 
                  get { return medium; } 
                  set { medium = value;}
              }
              public string MyYear 
              { 
                  get { return year; } 
                  set { year = value;}
              }
            }
    class Program
    { 
        static void Main(string[] args)
        {
            Painting myPainting = new Painting();
            myPainting.MyPaintingName = "Jungle Justice";
            myPainting.MyArtist = "Burna Boy";
            myPainting.MyMedium = "Africanized";
            myPainting.MyYear = "2020";
          
            Console.WriteLine("Title: " + myPainting.MyPaintingName);
            Console.WriteLine("Artist: " + myPainting.MyArtist);
            Console.WriteLine("Medium: " + myPainting.MyMedium);
            Console.WriteLine("Released Date: " + myPainting.MyYear);

        }
    }
}