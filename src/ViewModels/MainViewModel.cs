using System.Windows.Input;
using Launcher.Helpers;

namespace Launcher.ViewModels
{
  public class MainViewModel : BaseViewModel
  {
    // ===== 数据属性（界面会绑定到这里） =====
    private string _contentText = "欢迎使用启动器！";
    public string ContentText
    {
      get => _contentText;
      set => SetProperty(ref _contentText, value);
    }

    private bool _isStarting;
    public bool IsStarting
    {
      get => _isStarting;
      set
      {
        SetProperty(ref _isStarting, value);
        // 当 IsStarting 变化时，重新评估命令是否可用
        CommandManager.InvalidateRequerySuggested();
      }
    }

    // ===== 命令（界面按钮绑定到这里） =====
    public ICommand StartCommand { get; }
    public ICommand SettingsCommand { get; }
    public ICommand AboutCommand { get; }

    public MainViewModel()
    {
      // 初始化命令
      StartCommand = new RelayCommand(ExecuteStart, CanExecuteStart);
      SettingsCommand = new RelayCommand(ExecuteSettings);
      AboutCommand = new RelayCommand(ExecuteAbout);
    }

    // ===== 命令执行方法（你原来的业务逻辑移到这里） =====
    private void ExecuteStart()
    {
      IsStarting = true;
      ContentText = "⏳ 正在启动...";

      try
      {
        // ★★★ 这里放你原来的业务逻辑 ★★★
        // 例如：
        // - 启动游戏进程
        // - 检查更新
        // - 下载文件
        // 现在业务逻辑和界面完全分离了！

        // 模拟耗时操作
        System.Threading.Thread.Sleep(1000);
        ContentText = "✅ 启动成功！";
      }
      catch (System.Exception ex)
      {
        ContentText = $"❌ 启动失败：{ex.Message}";
      }
      finally
      {
        IsStarting = false;
      }
    }

    private bool CanExecuteStart()
    {
      // 正在启动时，按钮不可用
      return !IsStarting;
    }

    private void ExecuteSettings()
    {
      ContentText = "⚙️ 设置页面";
      // 可以在这里打开设置窗口
      // 例如：new SettingsWindow().ShowDialog();
    }

    private void ExecuteAbout()
    {
      ContentText = "📌 关于本启动器\n版本 1.0\n开发者：Your Name";
    }
  }
}