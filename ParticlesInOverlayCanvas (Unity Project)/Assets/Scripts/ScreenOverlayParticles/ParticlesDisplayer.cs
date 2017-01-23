using UnityEngine;
using System.Collections;

public class ParticlesDisplayer : MonoBehaviour 
{
	public RectTransform imageTransform;

	public void ResetPosition()
	{
		imageTransform.anchoredPosition = Vector2.zero;
	}

	public void MoveToPosition(Vector3 pos)
	{
		imageTransform.position = pos;
	}
}
