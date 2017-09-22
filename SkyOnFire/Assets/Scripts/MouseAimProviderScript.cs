using UnityEngine;

public class MouseAimProviderScript : AimProviderScript
{
    [SerializeField]
    private Vector3 aimDirection;

    // Use this for initialization
    void Start()
    {
        this.SetAim();
    }

    // Update is called once per frame
    void Update()
    {
        this.SetAim();
    }

    private void SetAim()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        this.aimDirection = mouseRay.direction;
    }

    public override Vector3 GetAimDirection()
    {
        return this.aimDirection;
    }
}