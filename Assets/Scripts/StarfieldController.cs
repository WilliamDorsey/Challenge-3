using UnityEngine;
using System.Collections;

public class StarfieldController : MonoBehaviour {

    public int starDensity = 20;
    public int startDens;
    public float starTempo = 1;
    public GameObject star;
    public Vector3 spawnValues;

	void Start () {
	    for(int i = 0; i < starDensity*200; i++)
        {
            Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, UnityEngine.Random.Range(23, -7));
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(star, spawnPosition, Quaternion.Euler(90, 0, Random.Range(0, 359)));
        }

        StartCoroutine(StarScroll());
	}

    private IEnumerator StarScroll()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(star, spawnPosition, Quaternion.Euler(90, 0, Random.Range(0, 359)));

            yield return new WaitForSeconds(starTempo/starDensity);
        }
    }
}
