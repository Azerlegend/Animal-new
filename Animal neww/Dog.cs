﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_neww
{
   internal class Dog : Animal

    {
        public Dog(string name, string color, string breed, int age, string voice):base(name,color,breed,age,voice)
        {
           



        }
         public override string GetVoice()
        {
            return $"{voice}";

        }

    }
}
