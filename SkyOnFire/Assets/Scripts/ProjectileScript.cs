using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Vector3 velocity;
    public float lifetime = 5;

    // Use this for initialization
    void Start()
    {
        Alive();
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().MovePosition(this.transform.position + this.velocity);
    }

    void OnTriggerEnter(Collider collider)
    {
        Object.Destroy(this.gameObject);
    }

    void Alive()
    {
        Destroy(gameObject, lifetime);
    }
}