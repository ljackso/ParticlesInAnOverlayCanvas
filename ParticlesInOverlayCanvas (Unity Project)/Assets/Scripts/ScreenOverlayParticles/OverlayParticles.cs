using UnityEngine;
using System.Collections;

public static class OverlayParticles 
{
	private static ParticlesPlayer player;
	private static ParticlesDisplayer displayer;

	public static void IntializeCheck()
	{
		if(player == null)
		{
			player = GameObject.FindObjectOfType<ParticlesPlayer>();
		}

		if(displayer == null)
		{
			displayer = GameObject.FindObjectOfType<ParticlesDisplayer>();
		}
	}

	public static void ShowParticles(int count)
	{
		IntializeCheck();

		displayer.ResetPosition();
		player.ShowParticles(count);
	}

	public static void ShowParticles(int count, Vector3 pos)
	{
		IntializeCheck();

		displayer.MoveToPosition(pos);
		player.ShowParticles(count);
	}

	public static void ShowContinuousParticles()
	{
		IntializeCheck();

		displayer.ResetPosition();
		player.StartContinuousEmission();
	}


	public static void ShowContinuousParticles(Vector3 pos)
	{
		IntializeCheck();

		displayer.MoveToPosition(pos);
		player.StartContinuousEmission();
	}

	public static void StopContinuousParticles()
	{
		IntializeCheck();

		player.StopEmission();
		displayer.ResetPosition();
	}
}
