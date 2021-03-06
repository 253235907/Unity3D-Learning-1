﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
	void OnCollisionEnter(Collision other)
	{
		//当玩家与侦察兵相撞
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<Animator>().SetTrigger("death");
			this.GetComponent<Animator>().SetTrigger("catch");
			Singleton<EventManager>.Instance.Over();
		}
	}
}
