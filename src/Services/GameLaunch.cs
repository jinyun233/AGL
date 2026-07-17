using System.Diagnostics;
using Launcher.Models;

namespace Services.GameLauncher
{
  public class GameLauncher
  {
    public bool Launch(Game game)
    {
      if (game == null || string.IsNullOrEmpty(game.ExePath))
      {
        Console.WriteLine("游戏信息不完整，无法启动");
        return false;
      }

      try
      {
        // 核心步骤，用于启动exe
        Process.Start(game.ExePath);
        Console.WriteLine($"已启动: {game.Name}");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"启动失败: {ex.Message}");
        return false;
      }
    }
  }
}