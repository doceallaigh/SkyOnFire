using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Vector3 velocity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(this.velocity);
    }
}