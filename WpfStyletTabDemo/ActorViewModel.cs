using Stylet;
using System.Collections.Generic;

namespace WpfStyletTabDemo;

public class ActorViewModel : Screen
{
    private string _actorName;
    public string ActorName
    {
        get => _actorName;
        set => SetAndNotify(ref _actorName, value);
    }

    private string _sampleText;
    public string SampleText
    {
        get => _sampleText;
        set => SetAndNotify(ref _sampleText, value);
    }

    private BindableCollection<string> _sampleTags;
    public BindableCollection<string> SampleTags
    {
        get => _sampleTags;
        set => SetAndNotify(ref _sampleTags, value);
    }

    public ActorViewModel(string name, string text, IEnumerable<string> tags)
    {
        ActorName = name;
        SampleText = text;
        SampleTags = new BindableCollection<string>(tags);
    }
}
