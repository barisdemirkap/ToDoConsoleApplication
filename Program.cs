using System ;

namespace ToDoApplication 
{
    class program
    {       
            static void Main(string [] args)
            {   Methods newMethod = new Methods () ;
                
                while(true)
                {   Console.WriteLine("Please select the application to do :)") ;
                    Console.WriteLine("****************************************") ;
                    Console.WriteLine("(1) List The Board \n(2) Add a Card To the Board \n(3) Delete a Card from the OnBoard \n(4) Move a Card") ;
                    int n = Int32.Parse(Console.ReadLine());
                    
                    try{
                        
                    switch(n)
                    {   
                        case 1:

                        {           
                                        newMethod.PressTheBoard() ;     
                            break;   
                        }
                        case 2:
                        {  
                                        newMethod.AddaCard() ;
                          break;
                         }   
                        case 3:
                        {                               
                                         newMethod.DeleteaCard() ;
                          break;
                         }   
                        case 4:
                        {
                                    newMethod.MoveaCard() ;
        
                          break;
                         }  
                    }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e) ;
                    }   
 }  
 } 
 }
}