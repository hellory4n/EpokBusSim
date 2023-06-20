using Godot;
using System;

public class Ground : RigidBody2D{
    public override void _Process(float delta) {
        Random random = new Random();
        Position = new Vector2(0,random.Next(-1,1));
        base._Process(delta);
    }
}
