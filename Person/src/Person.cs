using System; 
 
namespace Person 
{ 
    public class Person 
    {   
        private string _name; 

        private string _id; 

        public string Name{
            get {
                return this._name;
            }

            set {
                if (value != ""){
                    this._name = value;
                }
                else{
                    this._name = "Novalido";
                }
            }
        }

        public string ID{
            get{
                return _id;
            }

            set{
                if (Validar.IdIsValid(value)){
                  this._id = value;
                }
                else {
                    this._id = "Novalido";
                }
            }
        }

        public Person(string _name, string _id) 
        { 
            if(Validar.IdIsValid(_id)){
            this.Name = _name;}
            this.ID = _id; 
        } 

        public void IntroduceYourself() 
        { 
            if (this._name == "Novalido" || this._id == "Novalido"){
                Console.WriteLine("C.I. y/o nombre incorrectos");
            }
            else{
            Console.WriteLine($"Soy {this._name} y mi cédula es {this._id}");
            }
        } 
    } 
}
