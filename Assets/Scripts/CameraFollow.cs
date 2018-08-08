using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject Player;

    private float CameraFollowSpeed = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	void LateUpdate () {
        if (Player != null) this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(Player.transform.position.x, 0, Player.transform.position.z), Time.deltaTime * CameraFollowSpeed);

    }
}
