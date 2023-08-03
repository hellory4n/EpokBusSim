using Godot;
using System;

public class Bruh : Button {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetParent().GetParent().QueueFree();
    }
}
