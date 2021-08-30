using System;

namespace Person
{
        class Program 
    { 
        static void Main(string[] args) 
        { 
            Person john = new Person("John Doe", "5.212.626-4"); 
            Person jane = new Person("Jane Doe", "4.849.224-1");
            john.IntroduceYourself(); 
            jane.IntroduceYourself();

        } 
    } 
}