// See https://aka.ms/new-console-template for more information
using Core.Game;

Game game = new Game(800, 600, "Hello, window");
while (game.IsRunning())
{
  game.Update(Raylib_cs.Raylib.GetFrameTime());
  game.Render();
}
game.Clean();