using Avalonia;
using Avalonia.Controls;
using PcConsoleMode.ViewModels;

namespace PcConsoleMode.Views;

public partial class MainWindow : Window {
  public MainWindow() {
    InitializeComponent();
  }

  private void MainWindow_Deactivated(object? sender, System.EventArgs e) {
    (DataContext as MainViewModel).ShowInTaskBar = false;

    return;
  }

  private void MainWindow_Activated(object? sender, System.EventArgs e) {
    (DataContext as MainViewModel).ShowInTaskBar = true;
  }
}
