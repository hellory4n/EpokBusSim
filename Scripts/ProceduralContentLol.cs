using Godot;
using System;

public class ProceduralContentLol : Timer {
    Vector2 GroundPosition = new Vector2(13200, 467);
    Vector2 TreePosition = new Vector2(15173, 247);
    PackedScene Ground;
    Texture Trees;

    public override void _Ready() {
        base._Ready();
        this.Connect("timeout", this, nameof(ContentCreator));
        Ground = ResourceLoader.Load<PackedScene>("res://Scenes/GroundOmgomgomgogm.tscn");
        Trees = ResourceLoader.Load<Texture>("res://Assets/Forest.png");
    }

    public void ContentCreator() {
        // add more ground :)
        for (int i = 0; i < 10; i++) {
            RigidBody2D theGround = (RigidBody2D)Ground.Instance();
            theGround.Position = GroundPosition;
            GetParent().AddChild(theGround);
            GroundPosition = new Vector2(GroundPosition.x+1500, 467);
        }

        // more trees :))))
        for (int i = 0; i < 2; i++) {
            Sprite stupid = new Sprite();
            stupid.Texture = Trees;
            stupid.Centered = false;
            stupid.Position = TreePosition;
            GetParent().AddChild(stupid);
            TreePosition = new Vector2(TreePosition.x+9560, 247);
        }
    }
}
