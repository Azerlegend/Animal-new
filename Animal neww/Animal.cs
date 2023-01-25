using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_neww
{
    public class Animal
    {
        public string name;
        public string color;
        public string breed;
        public int age;
        public string voice;
        public Animal(string name,string color,string breed,int age,string voice)
        {
            this.name = name;
            this.color = color;
            this.breed = breed;
            this.age = age;
            this.voice = voice;
        }
       public virtual string GetVoice()
        {
            return $"{voice}";
        }



    }
}
