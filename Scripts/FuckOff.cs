using Godot;
using System;

public class FuckOff : Sprite {
    public override void _Ready() {
        base._Ready();
        // the ending has a different song
        GetNode<AudioStreamPlayer>("/root/Menu/Moosic").QueueFree();
        AudioStreamPlayer shit = new AudioStreamPlayer {
            Autoplay = true,
            Stream = ResourceLoader.Load<AudioStreamMP3>("res://Assets/shitending.mp3")
        };
        GetTree().Root.AddChild(shit);
    }

    public override void _Process(float delta) {
        RotationDegrees += 0.05f;
        base._Process(delta);
    }
}
