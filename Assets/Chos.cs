using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chos : MonoBehaviour {
    public Vector2 mousePos, playerPos;
    public Transform Target;
    public Rigidbody2D Player;

	void Start () {
	}
	
	void Update () {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        playerPos = transform.position;

        Vector2 deltaPos = mousePos - playerPos;
        float angle = Mathf.Atan2(deltaPos.y, deltaPos.x) * Mathf.Rad2Deg;
        Target.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Player.AddForce(transform.right * 10000);


        }
    }
}
