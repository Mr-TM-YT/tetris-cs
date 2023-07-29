// See https://aka.ms/new-console-template for more information
using Core.Game;


Game game = new Game(800, 600, "Hello, window");
while (game.IsRunning())
{
  game.Render();
}
game.Clean();