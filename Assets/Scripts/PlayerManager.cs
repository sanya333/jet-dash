using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public Rigidbody rb;

	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0, 2000 * Time.deltaTime);
		
	}
}
