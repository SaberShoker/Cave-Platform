using Godot;
using System;

public class Player : KinematicBody2D
{
	// Declare member variables here. Examples:
	const int ACCEL = 500;
	public int MAX_SPEED = 60;
	
	public Vector2 motion = Vector2.Zero;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// public override void _physic_process

	//  Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		// if (Input.IsActionPressed("move_right"))
	}
}
