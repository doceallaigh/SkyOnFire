using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Vector3 velocity;

    [SerializeField] private float lifetime = 5;

    // Use this for initialization
    void Start()
    {
        this.Alive();
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
        Object.Destroy(this.gameObject, this.lifetime);
    }
}