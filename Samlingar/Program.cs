using System;
using System.Collections.Generic;
using Raylib_cs;

namespace Samlingar
{
  class Program
  {
    static void Main(string[] args)
    {

      Raylib.InitWindow(800, 600, "hello");
      Raylib.SetTargetFPS(60);

      List<Rectangle> enemies = new List<Rectangle>();

      Rectangle e1 = new Rectangle(10, 10, 30, 30);
      Rectangle e2 = new Rectangle(50, 50, 30, 30);

      enemies.Add(e1);
      enemies.Add(e2);

      enemies.Add(new Rectangle(300, 200, 70, 70));

      while (!Raylib.WindowShouldClose())
      {

        for (int i = 0; i < enemies.Count; i++)
        {
          Rectangle tmp = enemies[i];
          tmp.x += 1;
          enemies[i] = tmp;
        }

        


        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.GOLD);

        int distance = 100;
        for (int i = 0; i < 6; i++)
        {
          Raylib.DrawLine(i * distance, 0, i * distance, 500, Color.BLACK);
          Raylib.DrawLine(0, i * distance, 500, i * distance, Color.BLACK);
        }


        DrawManyRects(enemies);
        

        Raylib.EndDrawing();

      }


      // List<string> names = new List<string>() {"Harbert", "Anna", "Kim"};

      // names.Add("Micke");

      // for (int i = 0; i < 4; i++)
      // {
      //     Console.WriteLine(names[i]);
      // }

      // int i = 0;
      // while (i < 4)
      // {

      //   i++;
      // }


      // Console.WriteLine(names[0]);
      // Console.WriteLine(names[1]);
      // Console.WriteLine(names[2]);
      // Console.WriteLine(names[3]);


      // Random generator = new Random();
      // int h = generator.Next(4);

      // Console.WriteLine(names[h]);

      //Console.ReadLine();


      string name = "Micke";

    }

    static void DrawManyRects(List<Rectangle> rects)
    {
      for (int i = 0; i < rects.Count; i++)
      {
        Raylib.DrawRectangleRec(rects[i], Color.RED);
      }
    }

  }
}
