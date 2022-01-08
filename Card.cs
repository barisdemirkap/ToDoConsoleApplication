using System.Collections.Generic ;
namespace ToDoApplication
{
   class Card
    {  public Card ()
        {}
        
        public Card (string title, string content , SizeofCards size , TeamMembers person, int progress) 

        {
            Title = title;
            Content = content ; 
            Size = size;
            Person = person ;
            _Progress = progress;
        }
        public string Title   {get; set;}

        public string Content {get; set;}
        public SizeofCards Size         {get; set;}
        public TeamMembers Person    {get; set;}
        
        public int _Progress {get ; set; }
        
    

    


       

        

    }
}