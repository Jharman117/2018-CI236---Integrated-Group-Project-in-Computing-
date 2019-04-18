using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform mainplayer;
	
	void FixedUpdate()
	{
		transform.position = new Vector3(mainplayer.position.x, mainplayer.position.y, transform.position.z);
	}	
}
