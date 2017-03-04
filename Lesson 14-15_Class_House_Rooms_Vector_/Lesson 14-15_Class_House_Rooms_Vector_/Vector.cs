using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_15_Class_House_Rooms_Vector_
{
    class Vector
    {
        private float x; 
         private float y; 
         private float magn; 
 
 
         public float X 
         { 
             get 
             { 
                 return x; 
             } 
             set 
             { 
                 x = value; 
                 CalcMagnitude(); 
             } 
         } 
 
 
         public float Y
         { 
             get 
             { 
                 return y; 
             } 
             set 
             { 
                 y = value; 
                 CalcMagnitude(); 
             } 
         } 
 
 
         public float Magn
         { 
             get 
             { 
                 return magn; 
             } 
         } 
 
 
         public Vector()
         { 
         } 
 
 
         private void CalcMagnitude()
         { 
             magn = (float)Math.Sqrt(x* x + y* y); 
         } 
 
 
         public void SetX(float value)
         { 
             x = value; 
             CalcMagnitude(); 

         } 
 
 
         public float GetX()
         { 
             return x; 
         } 
 
 
         public void SetY(float y)
         { 
             this.y = y; 
             CalcMagnitude(); 
         } 
 
 
         public float GetY()
         { 
             return y; 
         } 
 
 
         public float GetMagn()
         { 
             return magn; 
       } 

 
         public override string ToString()
        { 
             return String.Format("X: {0}\nY: {1}\nMagnitude: {2}", x, y, magn); 
         } 

    }
}
