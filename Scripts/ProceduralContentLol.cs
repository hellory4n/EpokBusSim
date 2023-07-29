using Godot;
using System;

public class ProceduralContentLol : Timer {
    Vector2 GroundPosition = new Vector2(13200, 467);
    PackedScene Ground;
    PackedScene Trees;
    PackedScene Sky;

    public override void _Ready() {
        base._Ready();
        this.Connect("timeout", this, nameof(ContentCreator));
        Ground = ResourceLoader.Load<PackedScene>("res://Scenes/GroundOmgomgomgogm.tscn");
    }

    public void ContentCreator() {
        // add more ground :)
        for (int i = 0; i < 10; i++) {
            RigidBody2D theGround = (RigidBody2D)Ground.Instance();
            theGround.Position = GroundPosition;
            GetParent().AddChild(theGround);
            GroundPosition = new Vector2(GroundPosition.x+1500, 467);
        }
    }
}
