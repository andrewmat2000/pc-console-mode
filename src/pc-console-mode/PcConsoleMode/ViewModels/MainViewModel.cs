using ReactiveUI;

namespace PcConsoleMode.ViewModels;

public class MainViewModel : ViewModelBase {
  private bool _showInTaskBar = true;
  public bool ShowInTaskBar { get => _showInTaskBar; set => this.RaiseAndSetIfChanged(ref _showInTaskBar, value); }
  public string Greeting => "Welcome to Avalonia!";
}
