using System;

namespace ClassNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FName = "Ajmery Jerin";
            person.LName = "Shipu";
            string name = person.getName();
            Console.WriteLine(name);

            Person user2 = new Person();
            user2.FName = "Mahbub";
            user2.LName = "Shipu";
            string name1 = user2.getName();
            Console.WriteLine(name1);

            Bottle bottle1 = new Bottle("blue", 2500);
            //Bottle bottle2 = new Bottle("red", 2000);

            Console.WriteLine($"Color:{bottle1.BottleColor},Height: {bottle1.BottleHeight}");
            //Console.WriteLine($"Color:{bottle2.BottleColor},Height: {bottle2.BottleHeight}");
            Console.WriteLine(Bottle.bottleSerialNumber);

            User user = new Student();
            Student student = new Student();
            student.Registration("jerinshipu","12546","Shipu");
            var std = student;
            Console.WriteLine(std);
        }
    }
}
