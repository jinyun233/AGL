namespace MyLauncher.Models
{
  public class Game
  {
    public string Name { get; set; }      // 显示出的游戏名，例如"原神"
    public string ExePath { get; set; }   // exe完整路径，例如 D:\Game\xxx.exe
    public string IconPath { get; set; }  // 图标路径（暂时未设置）
  }
}