using Godot;
using System;

public class EpicCoolTimer : Label {
    double timeomgomgomg = 0f;

    public override void _Process(float delta) {
        timeomgomgomg += delta;
        TimeSpan yes = TimeSpan.FromSeconds(timeomgomgomg);
        TimeSpan pain = new TimeSpan(8, 0, 0) - yes;
        Text = $"{yes.Hours:00}:{yes.Minutes:00}:{yes.Seconds:00} ({pain.Hours:00}:{pain.Minutes:00}:{pain.Seconds:00} left!)";
        base._Process(delta);
    }
}
