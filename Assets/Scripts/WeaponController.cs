using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

    private AudioSource audioSource;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float shotDelay;

	void Start () {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating ("Fire", shotDelay, fireRate);
	}

    void Fire ()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audioSource.Play ();
    }
}
