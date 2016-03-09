using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float speed;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = 10;
			Vector3 modifiedPos = Camera.main.ScreenToWorldPoint (mousePos);

			if (mouseIsLeftOfPlayer (modifiedPos)) {
				rb.velocity = new Vector2 (speed, 0);
			} else {
				rb.velocity = new Vector2 (-speed, 0);
			}
		}
	}

	private bool mouseIsLeftOfPlayer(Vector3 mousePos) {
		if (rb.position.x < mousePos.x) {
			return true;
		}
		return false;
	}
}
