﻿using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
	public bool isRightTrigger;

	Controls controls;

	public GameObject player;

	void Awake()
	{
		if(isRightTrigger)
		{
			controls = player.GetComponents<Controls>()[0];
		}
		else
		{
			controls = player.GetComponents<Controls>()[1];
		}
	}

	void OnTriggerStay(Collider other)
	{
		if(other.tag == "Item")
		{
			//print (isRightTrigger + ": item in Trigger");
			controls.itemInTrigger = true;
			if(controls.item == null)
			{
				controls.item = other.gameObject;
			}
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Item")
		{
			controls.itemInTrigger = false;
			if(controls.item != null)
			{
				controls.item = null;
			}
		}
	}

}
