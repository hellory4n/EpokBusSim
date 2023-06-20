using Godot;
using System;

public class Bus : RigidBody2D {
    public override void _Process(float delta) {
        LinearVelocity = new Vector2(1000, LinearVelocity.y);
        base._Process(delta);
    }
}
