using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerTest : MonoBehaviour {

	[SerializeField]
	private int Number = 0;

	public void OnClick()
	{
		SoundManager.Instance.Play(Number);
	}

}
