using UnityEngine;
using System.Collections;

public class UsingInstantiate : MonoBehaviour
{
	public Rigidbody rocketPrefab;
	public Transform barrelEnd;
	
	
	void Update ()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Rigidbody rocketInstance;
			rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.localRotation) as Rigidbody;
			rocketInstance.AddForce(barrelEnd.forward * 100);
		}
	}

}
