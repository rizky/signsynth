using UnityEngine;

public class FadeAnimation : MonoBehaviour {

	public Animation anim;
	void Start() {
		anim = GetComponent<Animation>();
	}
	void Update() {
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1F) {
			anim.CrossFade ("walk1");
			Debug.Log ("Run");
		} else {
			anim.CrossFade ("run");
			Debug.Log ("Walk");
		}
	}
}
