﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Random;

namespace B10402109_B10402110_B10402146
{
    class ClassA  // 隨機傳回一個0~99的數字
    {
        public int number(){
            
            Random rand = new Random();
            int a = rand.Next(100);
            return a;
        }
    
    }
}
