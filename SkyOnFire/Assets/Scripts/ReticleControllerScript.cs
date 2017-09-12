using UnityEngine;

public class ReticleControllerScript : MonoBehaviour
{
    public Camera camera;
    public GUITexture reticleTexture;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float normalizedX = Input.mousePosition.x / this.camera.pixelWidth;
        float normalizedY = Input.mousePosition.y / this.camera.pixelHeight;

        Vector2 normalizedmousePosition = new Vector2(normalizedX, normalizedY);

        this.reticleTexture.transform.position = normalizedmousePosition;
    }
}