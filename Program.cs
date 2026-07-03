using System;
using MyLauncher.Models;
using MyLauncher.Core;

namespace MyLauncher
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== 启动器测试版本 ===");

      var game = new Game
      {
        Name = "测试游戏",
        ExePath = @"D:\游戏路径.exe"//根据实际的游戏路径进行修改
      };

      Console.WriteLine($"准备启动: {game.Name}");
      Console.WriteLine($"路径: {game.ExePath}");
      Console.WriteLine("按 Y 启动，按其他键取消");

      if (Console.ReadKey().Key == ConsoleKey.Y)
      {
        Console.WriteLine("\n正在启动...");
        var launcher = new GameLauncher();
        bool success = launcher.Launch(game);
        Console.WriteLine(success ? "启动成功" : "启动失败");
      }

      Console.ReadKey();
    }
  }
}