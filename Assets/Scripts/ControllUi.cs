using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControllUi : MonoBehaviour
{
    [SerializeField] private GameObject SpawnPanel;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SpawnPanel.SetActive(true);
            Time.timeScale = 0;

            Cursor.lockState = CursorLockMode.None;

        }
    }

    public void SetPanelFalse()
    {
        SpawnPanel.SetActive(false);
        Time.timeScale = 1;
    
        Cursor.lockState = CursorLockMode.Locked;


    }
    
    public void SetPanelFalseMobile()
    {
        SpawnPanel.SetActive(false);
        Time.timeScale = 1;
    
        


    }
    
    public void SetPanelTrueMobile()
    {
        SpawnPanel.SetActive(true);
        Time.timeScale = 0;
    
        Cursor.lockState = CursorLockMode.None;


    }
}
