using Godot;
using System;

public class Wheel : CollisionShape2D {
    Random random = new Random();

    public override void _Ready() {
        Timer timer = new Timer();
        timer.Connect("timeout", this, nameof(Suffering));
        timer.WaitTime = 0.1f;
        timer.OneShot = false;
        AddChild(timer);
        timer.Start();
        base._Ready();
    }

    public void Suffering() {
        CircleShape2D pain = new CircleShape2D();
        pain.Radius = random.Next(-50,50);
        Shape = pain;
    }
}
