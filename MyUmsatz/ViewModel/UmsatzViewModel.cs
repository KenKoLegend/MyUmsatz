using MyUmsatz.Model;
using MyUmsatz.View.UserControls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class UmsatzViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<Umsatz> _umsatzListe;
    public ObservableCollection<Umsatz> UmsatzListe
    {
        get { return _umsatzListe; }
        set
        {
            _umsatzListe = value;
            OnPropertyChanged();
        }
    }

    private Umsatz _selectedUmsatz;
    public Umsatz SelectedUmsatz
    {
        get { return _selectedUmsatz; }
        set
        {
            _selectedUmsatz = value;
            OnPropertyChanged();
        }
    }

    public ICommand HinzufuegenCommand { get; }
    public ICommand BearbeitenCommand { get; }
    public ICommand LoeschenCommand { get; }

    public UmsatzViewModel()
    {
        UmsatzListe = new ObservableCollection<Umsatz>()
        {
            new Umsatz() { Datum = "01.02.2024", Beschreibung = "Verkauf von Produkt A", Betrag = 150.00m },
            new Umsatz() { Datum = "05.02.2024", Beschreibung = "Dienstleistung B", Betrag = 200.50m },
        };

        HinzufuegenCommand = new RelayCommand(Hinzufuegen);
        BearbeitenCommand = new RelayCommand(Bearbeiten);
        LoeschenCommand = new RelayCommand(Loeschen);
    }

    private void Hinzufuegen(object parameter)
    {
        UmsatzListe.Add(new Umsatz() { Datum = DateTime.Now.ToString(), Beschreibung = "Neuer Umsatz", Betrag = 0.0m });
    }
   
    private void Bearbeiten(object parameter)
    {
        if (SelectedUmsatz != null)
        {
        }
    }

    private void Loeschen(object parameter)
    {
        if (SelectedUmsatz != null)
        {
            UmsatzListe.Remove(SelectedUmsatz);
        }
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Func<bool> _canExecute;

    public RelayCommand(Action<object> execute, Func<bool> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public bool CanExecute(object parameter) => _canExecute == null || _canExecute();

    public void Execute(object parameter) => _execute(parameter);
}