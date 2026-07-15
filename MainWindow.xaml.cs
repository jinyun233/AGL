// 主窗口逻辑

using System.Windows;
using Launcher.ViewModels;

namespace Launcher
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      // MessageBox.Show("MainWindow 构造函数被调用了！"); // 调试用
      InitializeComponent();
      this.DataContext = new MainViewModel();
    }
  }
}