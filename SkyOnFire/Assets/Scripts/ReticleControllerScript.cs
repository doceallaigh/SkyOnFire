using UnityEngine;

public class ReticleControllerScript : MonoBehaviour
{
    public GUITexture reticleTexture;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float normalizedX = Input.mousePosition.x / Camera.main.pixelWidth;
        float normalizedY = Input.mousePosition.y / Camera.main.pixelHeight;

        Vector2 normalizedmousePosition = new Vector2(normalizedX, normalizedY);

        this.reticleTexture.transform.position = normalizedmousePosition;
    }
}