using Godot;
using System;

public class Quit : Button {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetTree().Quit();
    }
}
