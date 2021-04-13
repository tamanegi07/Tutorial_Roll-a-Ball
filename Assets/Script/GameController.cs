using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public UnityEngine.UI.Text scoreLabel;
	public void Update ()
	{
		int count = GameObject.FindGameObjectsWithTag ("item").Length;
		scoreLabel.text = count.ToString ();
	}
}