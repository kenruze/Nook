using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NookPlayerControls : MonoBehaviour
{
    public float movementSpeed = 10;
    public float mouseSensitivityX = 5;
    public float mouseSensitivityY = -3;

    Vector3 cameraAngles;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            cameraAngles.x = Mathf.Clamp(cameraAngles.x + Input.GetAxis("Mouse Y") * mouseSensitivityY, -85, 85);
            cameraAngles.y = cameraAngles.y + Input.GetAxis("Mouse X") * mouseSensitivityX;
            while (cameraAngles.y > 180)
            {
                cameraAngles.y -= 360;
            } while (cameraAngles.y < -180)
            {
                cameraAngles.y += 360;
            }
            transform.rotation = Quaternion.Euler(cameraAngles);
        }

        Vector3 flatForward = transform.forward;
        flatForward.y = 0;
        Vector3 movement = Quaternion.LookRotation(flatForward) * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.Q))
        {
            movement.y -= 0.5f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            movement.y += 0.5f;
        }

        transform.position += movement * Time.deltaTime * movementSpeed;
    }
}
