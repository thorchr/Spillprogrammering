using UnityEngine;
using System.Collections;

public class DestroyBarrels : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "cube")
		{
			Destroy(col.gameObject);
		}
	}
}
