using System;
using System.Text;
using System.IO;

namespace GenericFrameworkNhibernate{

  public class Criptografy{
  
      private static int sizeCriptografy = 512;
      
      public static string CreateHash(string inputText){
        SHA3Managed hash = null;               
        ASCIIEncoding encoding = null;
        
        hash = new SHA3Managed(sizeCriptografy);
        encoding = ASCIIEncoding();
        
        byte[] MessageBytes = encoding.GetBytes(inputText); 
        byte[] ComputeHashBytes = hash.ComputeHash(MessageBytes);
        StringBuilder x = new StringBuilder();                
        foreach (var item in ComputeHashBytes)
        {
            x.Append(item.ToString("X2"));
        }
         return x.ToString();
      }
    
  }

}
