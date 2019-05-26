using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NookPlayer : NetworkBehaviour
{
    public GameObject camera;
    public GameObject avatar;
    public NookPlayerControls playerControls;

    public override void OnStartLocalPlayer()
    {
        playerControls.enabled = true;
        camera.SetActive(true);
        avatar.SetActive(false);
    }

    void Start()
    {

    }
}
