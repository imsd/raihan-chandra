using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour {


	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.name == "HitBall(Clone)")
		{
			Destroy(collision.gameObject);
			Destroy(this.gameObject);
		}
		//else {
			//Destroy (this.gameObject, 3);
	//}


}
}
