using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using PcConsoleMode.ViewModels;
using PcConsoleMode.Views;

namespace PcConsoleMode;

public partial class App : Application {
  public override void Initialize() {
    AvaloniaXamlLoader.Load(this);
  }

  public override void OnFrameworkInitializationCompleted() {
    if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
      desktop.MainWindow = new MainWindow {
        DataContext = new MainViewModel()
      };
    } else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform) {
      singleViewPlatform.MainView = new MainView {
        DataContext = new MainViewModel()
      };
    }

    base.OnFrameworkInitializationCompleted();
  }

  private void TrayIcon_Clicked(object? sender, System.EventArgs e) {
    if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
      desktop.MainWindow?.Activate();
    }

    return;
  }
}
