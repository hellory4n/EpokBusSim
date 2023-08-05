using Godot;
using System;

public class Bus : RigidBody2D {
    bool cheatingMode = false;

    public override void _Process(float delta) {
        if (Input.IsActionJustReleased("cheating_mode™"))
            cheatingMode = !cheatingMode;

        if (cheatingMode)
            LinearVelocity = new Vector2(1000*5000, LinearVelocity.y);
        else
            LinearVelocity = new Vector2(1000, LinearVelocity.y);
        base._Process(delta);
    }
}
