using Godot;
using System;

public class ToggleFullscreen : Label {
    public override void _Ready() {
        base._Ready();
        if (OS.GetName() == "Android")
            QueueFree();
    }

    public override void _Process(float delta) {
        if (Input.IsActionJustReleased("fullscreen"))
            OS.WindowFullscreen = !OS.WindowFullscreen;
        base._Process(delta);
    }
}
