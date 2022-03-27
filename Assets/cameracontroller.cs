using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject[] Camera;
    public int i = 0;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.V))
        {
            if (i == 4)
            {
                ResetCamera();


            }
            nextCamera();
            i++;
        }
    }

    void nextCamera()
    {
         if( i < Camera.Length)
        {
            
            
                Camera[i].SetActive(false);

                Camera[i + 1].SetActive(true);
            
            

            Debug.Log(i);
            
        }
        
    }

    private void ResetCamera()
    {
        Camera[0].SetActive(true);
        Camera[1].SetActive(false);
        Camera[2].SetActive(false);
        Camera[3].SetActive(false);
        i = 0;
    }
}
