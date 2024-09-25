using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraSwitch : MonoBehaviour
{
    public CinemachineVirtualCamera danceCam1, danceCam2, danceCam3;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cameraSwitcher(danceCam1);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            cameraSwitcher(danceCam2);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            cameraSwitcher(danceCam3);
        }
    }

    void cameraSwitcher(CinemachineVirtualCamera currentCam)
    {
        currentCam.Priority = 10;
        foreach(CinemachineVirtualCamera camera in FindObjectsOfType<CinemachineVirtualCamera>())
        {
            if(camera != currentCam)
            {
                camera.Priority = 9;
            }
        }
    }
}
