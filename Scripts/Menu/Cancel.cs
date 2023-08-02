using Godot;
using System;

public class Cancel : Button {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetParent().QueueFree();
    }
}
