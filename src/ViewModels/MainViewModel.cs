
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Services.GameLauncher;

namespace Launcher.ViewModels
{
  public partial class MainViewModel : ObservableObject // 添加partial关键字
  {
    [ObservableProperty] // 属性标记
    private string titleText = "欢迎使用AGL启动器！";

    [ObservableProperty]
    private string filePathText = "设置即将启动的文件路径";

    [RelayCommand] // 命令标记
    private void ExecuteStart()
    {
      TitleText = "正在启动……";
    }

    [RelayCommand]
    private void ExecuteSettings()
    {
      TitleText = "点击了设置按钮";
    }

    [RelayCommand]
    private void ExecuteAbout()
    {
      TitleText = "点击了关于按钮";
    }
  }
}