using Godot;
using System;

public class CreditsOpen : Button {
    public override void _Ready() {
        Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Credits.tscn");
        Node2D OK = (Node2D)yes.Instance();
        GetTree().Root.AddChild(OK);
    }
}
