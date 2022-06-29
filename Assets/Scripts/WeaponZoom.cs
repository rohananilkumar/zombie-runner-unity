using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60;
    [SerializeField] float zoomedInFOV = 20;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = .5f;


    bool zoomedInToggle = false;

    public bool ZoomedInToggle { get { return zoomedInToggle; }  }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ZoomToggle();
        } 
    }

    public void ZoomToggle()
    {
        zoomedInToggle = !zoomedInToggle;
        fpsCamera.fieldOfView = zoomedInToggle ? zoomedInFOV : zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomedInToggle ? zoomedInSensitivity : zoomedOutSensitivity; //here
        fpsController.mouseLook.YSensitivity = zoomedInToggle ? zoomedInSensitivity : zoomedOutSensitivity;
    }
}
