using Raylib_cs;

namespace Core
{
  namespace Game
  {
    class Game
    {
      public Game(int width, int height, string title)
      {
        Raylib.InitWindow(width, height, title);
      }
      public bool IsRunning()
      {
        return !Raylib.WindowShouldClose();
      }

      public void Render()
      {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RAYWHITE);
        Raylib.DrawText("Hello, world", 12, 12, 20, Color.BLACK);
        Raylib.EndDrawing();
      }

      public void Clean()
      {
        Raylib.CloseWindow();
      }
    }

  }

}
