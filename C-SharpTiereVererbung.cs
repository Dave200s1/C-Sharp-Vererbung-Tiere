using System;

namespace Vererbung
{
 
  class Tier
  {
    //Eigenschaften (2)
    public string Geschlecht {get; set;}
    public int Alter {get; set;}
    
    
    //Methode
    public void Bewegen()
    {
      Console.WriteLine("bewegt sich ..");
    }

    public void Fressen()
    {
      Console.WriteLine("Isst...");
    }
  }


  class Hund: Tier //Vererbung
  {
    //Eigenschaften
    public string Name {get; set;}

    //Methode
    public void Bellen()
    {
      Console.WriteLine("Wuff Wuff");
    }
    
  }


  class Katze: Tier
  {
    public string Name{get; set;}

    public void Miauen()
    {
      Console.WriteLine("Miau");
      
    }
  }



   class MainClass{
    public static void Main(string[]args)
    {
      //Hund
      Hund Rex= new Hund();
      Rex.Name = "Rex";
      Rex.Bellen();
      Rex.Alter= 12;
      
    //Katze
      Katze Garfield= new Katze();
      Garfield.Name="Garfield";
      Garfield.Miauen();
    }
  }

}
