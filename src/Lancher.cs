namespace MyLauncher.Models
{
  public class Game
  {
    public string Name { get; set; }      // 游戏显示名，比如"原神"
    public string ExePath { get; set; }   // exe完整路径，比如 D:\Game\xxx.exe
    public string IconPath { get; set; }  // 图标路径（暂时用不到，先留着）
  }
}