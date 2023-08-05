using Godot;
using System;

public class FuckOff : Sprite {
    public override void _Process(float delta) {
        RotationDegrees += 0.05f;
        base._Process(delta);
    }
}
