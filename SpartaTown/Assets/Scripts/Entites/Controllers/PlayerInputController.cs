using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputController : TopDownController
{
    Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }
    private void FixedUpdate()
    {
        MainCameraMove();
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
    public void MainCameraMove()
    {
        Vector3 cameraPositon = camera.transform.position;
        cameraPositon.x = this.transform.position.x;
        cameraPositon.y = this.transform.position.y;
        camera.transform.position = cameraPositon;
    }
}
