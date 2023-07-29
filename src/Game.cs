using System.Numerics;
using Raylib_cs;

namespace Core
{
  namespace Game
  {
    class Game
    {
      private Vector2 _ballPos;
      private Vector2 _ballVel;
      private const int _ballRadius = 20;
      private const int _ballSpeed = 50;
      public Game(int width, int height, string title)
      {
        Raylib.InitWindow(width, height, title);
        Raylib.SetTargetFPS(60);
        _ballPos.X = Raylib.GetScreenWidth() / 2;
        _ballPos.Y = Raylib.GetScreenHeight() / 2;
        _ballVel.X = 1;
        _ballVel.Y = 1;

      }
      public bool IsRunning()
      {
        return !Raylib.WindowShouldClose();
      }

      public void Update(float dt)
      {
        _ballPos.X += _ballVel.X * _ballSpeed * dt;
        _ballPos.Y += _ballVel.Y * _ballSpeed * dt;
        if (_ballPos.X <= 0 + _ballRadius || _ballPos.X >= Raylib.GetScreenWidth() - _ballRadius)
        {
          _ballVel.X *= -1;
        }
        if (_ballPos.Y <= 0 + _ballRadius || _ballPos.Y >= Raylib.GetScreenHeight() - _ballRadius)
        {
          _ballVel.Y *= -1;
        }
      }

      public void Render()
      {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("Hello, world", 12, 12, 20, Color.RAYWHITE);
        Raylib.DrawCircleV(_ballPos, _ballRadius, Color.BLUE);
        Raylib.EndDrawing();
      }

      public void Clean()
      {
        Raylib.CloseWindow();
      }
    }

  }

}
