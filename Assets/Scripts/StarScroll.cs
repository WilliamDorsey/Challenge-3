using UnityEngine;
using System.Collections;

public class StarScroll : MonoBehaviour {

    public float speed;
    public float scale = 1;

    Rigidbody rb;
    private float distance;
    private float size;

	void Start () 
    {
        distance = Random.Range(0.1f, 2f);
        size = scale * distance;
        transform.localScale = new Vector3(size, size, 1);

        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -1 * speed * distance);

        Destroy(gameObject, 30/(speed*distance));
    }
}
