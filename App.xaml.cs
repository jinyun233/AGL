using System.Windows;

namespace Launcher
{
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      // MessageBox.Show("App OnStartup 被调用了！"); // 调试用
      // 程序启动时的初始化（可选）
      // 例如：加载配置文件、检查更新、初始化日志等

      // 创建主窗口并显示
      base.OnStartup(e);
    }
  }
}