using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp11
{
    class Program
    {
        static int points = 0;
        
        public static void Main ()
        {
            Turtle.Speed = 5;
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            
            GraphicsWindow.BrushColor = GraphicsWindow.GetRandomColor();
            var eat = Shapes.AddEllipse(10, 10);
            int x = 200;
            int y = 200;
            Turtle.PenUp();
            Shapes.Move(eat, x, y);
            Random rand  = new Random();
            while (true)  

            {
                Turtle.Move(10);
                if (Turtle.X >= x && Turtle.X <= x + 10 && Turtle.Y >= y && Turtle.Y <= y + 10)
                {
                    x = x + 20;
                    x = rand.Next(0, 400);
                    y = rand.Next(0, 400);
                    Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                    points++;
                    TextWindow.WriteLine("очки = " + points);
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "W")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "D")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "S")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "A")
            {
                Turtle.Angle = 270;
            }
            else if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Speed++; 
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Speed--;
            }
            else if (GraphicsWindow.LastKey == "F")
            {
                Turtle.Y = 260;
                Turtle.X = 330;
            }
            else if (GraphicsWindow.LastKey == "G")
            {
                var eat = Shapes.AddEllipse(10, 10);
                int x = 200;
                int y = 200;
                Shapes.Move(eat, x, y);
                Random rand = new Random();    
            }
          
  


        }
    }
}
