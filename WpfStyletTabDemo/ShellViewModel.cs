using Stylet;
using System.Collections.Generic;

namespace WpfStyletTabDemo;

public class ShellViewModel : Screen
{
    private BindableCollection<ActorViewModel> _actors;
    public BindableCollection<ActorViewModel> Actors
    {
        get => _actors;
        set => SetAndNotify(ref _actors, value);
    }

    private ActorViewModel _selectedActor;
    public ActorViewModel SelectedActor
    {
        get => _selectedActor;
        set => SetAndNotify(ref _selectedActor, value);
    }

    public ShellViewModel()
    {
        var actorA = new ActorViewModel("Actor A", "Description of A", new List<string> { "TagA1", "TagA2", "TagA3" });
        var actorB = new ActorViewModel("Actor B", "Description of B", new List<string> { "TagB1", "TagB2", "TagB3" });
        var actorC = new ActorViewModel("Actor C", "Description of C", new List<string> { "TagC1", "TagC2", "TagC3" });
        var actorD = new ActorViewModel("Actor D", "Description of D", new List<string> { "TagD1", "TagD2", "TagD3" });

        Actors = new BindableCollection<ActorViewModel>();
        Actors.Add(actorA);
        Actors.Add(actorB);
        Actors.Add(actorC);
        Actors.Add(actorD);
    }
}
