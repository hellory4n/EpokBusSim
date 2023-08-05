using Godot;
using System;

public class EpicCoolTimer : Label {
    double timeomgomgomg = 0f;
    bool cheatingMode = false;

    public override void _Process(float delta) {
        if (Input.IsActionJustReleased("cheating_mode™"))
            cheatingMode = !cheatingMode;

        if (cheatingMode)
            timeomgomgomg += delta*5000;
        else
            timeomgomgomg += delta;
        
        TimeSpan yes = TimeSpan.FromSeconds(timeomgomgomg);
        TimeSpan pain = new TimeSpan(8, 0, 0) - yes;
        Text = $"{yes.Hours:00}:{yes.Minutes:00}:{yes.Seconds:00} ({pain.Hours:00}:{pain.Minutes:00}:{pain.Seconds:00} left!)";

        if (yes.Hours == 8) {
            var myes = (PackedScene)ResourceLoader.Load("res://Scenes/Ending.tscn");
            Node2D OK = (Node2D)myes.Instance();
            GetTree().Root.AddChild(OK);
            GetParent().GetParent().QueueFree();
        }
        base._Process(delta);
    }
}
