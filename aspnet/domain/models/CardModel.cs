using domain.abstracts;

namespace domain.models
{
    public class CardModel : AEntity
    {
        public string Name {get; set;}
        public string CardType {get; set;}
        public string ManaCost {get;set;}
        public string PowerToughness {get;set;}
        public string ImagePath{get;set;}

        
    }
}