﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Game : MonoBehaviour 
{
	public Image healthBar;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Damage(float playerHealth)
	{
		healthBar.rectTransform.localScale = new Vector3 (playerHealth, 1f, 1f);
	}
}