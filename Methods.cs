namespace ToDoApplication
{    public class TeamMembers
    {   
        public int id {get; set;}
        public string name {get; set;}
        public string surname {get; set;} 
        
    }

    public class Methods  
    {   
        private List <Card> _ToDoS {get ; set ; } = new List<Card> ();
        private List <Card> _IPS {get ; set ; } = new List<Card> ();
        private List <Card> _DONE {get ; set ; } = new List<Card> ();
        public List <TeamMembers> Listofteam = new List <TeamMembers> {
        {new TeamMembers {id = 1 , name="Hilmi" , surname = "Mahmut"}} ,
        {new TeamMembers {id = 2 , name="Pelin" , surname = "Topal"}} ,
        {new TeamMembers {id = 3 , name="Melih" , surname = "DMJ"}} ,
        {new TeamMembers {id = 4 , name="Ayse" , surname = "Gul"}} ,
        {new TeamMembers {id = 4 , name="baris" , surname = "demirkap"}} ,       
        } ;
        
       
           private void pressonlyonecard (Card item)
           {                    Console.WriteLine("Title        :{0}" , item.Title) ;
                                Console.WriteLine("Content       :{0} " , item.Content) ;
                                Console.WriteLine("in Charge of  :{0}" , item.Person.id) ;
                                Console.WriteLine("Size          :{0}" ,item.Size) ;

           }     
        
       
        
        public void PressTheBoard() 
        {              Console.WriteLine("To Do Line") ;
                       Console.WriteLine("***************") ;

                            foreach(var item in _ToDoS) 
                               { pressonlyonecard(item) ;
                               }
                       Console.WriteLine("In Progress Line") ;
                       Console.WriteLine("***************") ;
                            foreach(var item in _IPS) 
                               { 
                                   pressonlyonecard(item) ;
                               }
                        Console.WriteLine("Done Line") ;
                        Console.WriteLine("***************") ;
                            foreach(var item in _DONE) 
                               {
                                   pressonlyonecard(item) ;
                               }        
                  
          

        }
        public void AddaCard()
        {                      
                            Console.WriteLine("Enter a Title") ;
                            string title = Convert.ToString(Console.ReadLine() ) ; 
                            Console.WriteLine("Enter a Content") ;
                            string content = Convert.ToString(Console.ReadLine() ) ; 
                            Console.WriteLine("Enter a Size -> XS (1),S (2),M (3),L (4), XL (5)") ;
                            int size = Int32.Parse(Console.ReadLine() ) ;
                            SizeofCards Size = (SizeofCards)size ;
                            Console.WriteLine("Select a Person") ;
                            int idofperson = Int32.Parse(Console.ReadLine() ) ; 
                            int progress=1 ;
                            
                           try {
                               Card newCard = new Card (title , content , Size , FindInTheTeamList(idofperson), progress ) ;
                               _ToDoS.Add(newCard) ;
                               
                               Console.WriteLine("Added") ;
                           }
                           catch (Exception eX) {
                               Console.WriteLine(eX) ;
                           }
                          }

         public void DeleteaCard()
        {           Console.WriteLine("First of all, Card must be picked before it will be deleted") ;
                    Console.WriteLine ("Please, Enter the Title of the Card") ;
                    string temp = Convert.ToString(Console.ReadLine())  ;
                    
                    try { RemovePickedCard(temp) ;
                        
                            Console.WriteLine(temp +" was deleted.");


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("There is no information about your entered word, Please Select a option") ;
                        Console.WriteLine("* Quit deleting operation   :  (1)") ;
                        Console.WriteLine("* Try Again   :  (2)") ;
                        int givininput = Int32.Parse(Console.ReadLine()) ;
                        switch (givininput)
                        {
                            case 1 :
                            break;
                            case 2 : 
                                    DeleteaCard() ;
                            break ;
                          }
                    }

            
        }

            public void MoveaCard()
            {    Console.WriteLine("First of all, Card must be picked before it will be moved") ;
                    Console.WriteLine ("Please, Enter the Title of the Card") ;
                    string temp = Convert.ToString(Console.ReadLine())  ;
                    
                    try {  


                            Console.WriteLine("Information of determined Card:") ;
                            Console.WriteLine("*******************************") ;
                            Card newCARD = FindCard(temp);
                            RemovePickedCard(temp) ;
                            Console.WriteLine("\n\nPlease select line that card could be moved:\n(1) TODO\n(2) In Progress\n(3) Done") ;
                            int temp2 = Convert.ToInt32(Console.ReadLine())  ;
                            switch(temp2)
                            {
                                case 1: _ToDoS.Add(newCARD) ;
                                break ;
                                case 2: _IPS.Add(newCARD) ;
                                break;
                                case 3 : _DONE.Add(newCARD) ;
                                break ; 
                            }

                            Console.WriteLine(temp +" moved from "+ temp + " to " + temp + ".");


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("There is no information about your entered word, Please Select a option") ;
                        Console.WriteLine("* Quit moving operation   :  (1)") ;
                        Console.WriteLine("* Try Again   :  (2)") ;
                        int givininput = Int32.Parse(Console.ReadLine()) ;
                        switch (givininput)
                        {
                            case 1 :
                            break;
                            case 2 : 
                                    DeleteaCard() ;
                            break ;
                          }
                    }


            }
        public TeamMembers FindInTheTeamList(int id) 
            {   foreach (var item in Listofteam)
                           { if(id==item.id)
                                return item;
                            }

            return null ;
                
            }

        public void RemovePickedCard(string temp)
        {           
            
                    foreach (var item in _ToDoS)
                           { if(temp == item.Title)
                                _ToDoS.Remove(item) ;
                                break;
                            }
                    foreach (var item in _IPS)
                           { if(temp == item.Title)
                                _IPS.Remove(item) ;
                                break;
                            }
                    foreach (var item in _DONE)
                           { if(temp == item.Title)
                                 _DONE.Remove(item) ;
                                 break;
                            }
       
        }
        private Card FindCard(string temp)
        {           Card newCARD = new Card () ;
            
                    foreach (var item in _ToDoS)
                           { if(temp == item.Title)
                                pressonlyonecard(item) ;
                                Console.WriteLine("Line       : ToDo") ;
                                return item ;
                                break;
                            }
                    foreach (var item in _IPS)
                           { if(temp == item.Title)
                                pressonlyonecard(item) ;
                                Console.WriteLine("Line       :Inprogress") ;
                                return item ;
                                break;
                            }
                    foreach (var item in _DONE)
                           { if(temp == item.Title)
                               pressonlyonecard(item) ; 
                               Console.WriteLine("Line       : Done") ; 
                               return item ;
                                 break;
                            }
            return newCARD;                            
       
        }
        


    }


  
}