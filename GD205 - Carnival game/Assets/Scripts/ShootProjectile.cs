
using UnityEngine;

public class ShootProjectile : MonoBehaviour {
	public float damage = 5f;
	public float range = 100f; 
	public Camera fpsCam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"));
		{
			Fire ();

		}

	}

	void Fire()

	{
		RaycastHit hit;
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range));
		{

			Debug.Log (hit.transform.name);

		}
	}
}
