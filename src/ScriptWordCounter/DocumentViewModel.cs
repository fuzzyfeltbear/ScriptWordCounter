using System.ComponentModel;

namespace ScriptWordCounter;

public class DocumentViewModel : INotifyPropertyChanged, IDisposable
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _text = string.Empty;
    public string Text
    {
        get { return _text; }
        set 
        { 
            _text = value; 
            OnPropertyChanged(nameof(Text));
            WordCount = Counter.Count(value);
        }
    }

    private int _wordCount;
    public int WordCount
    {
        get { return _wordCount; }
        set
        {
            _wordCount = value;
            OnPropertyChanged(nameof(WordCount));
        }
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        var handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
