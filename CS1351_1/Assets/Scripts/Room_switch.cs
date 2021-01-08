using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_switch : MonoBehaviour
{
    public CharacterController controller = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            controller.enabled = false;
            this.transform.position = new Vector3(50,-6,0);
            controller.enabled = true;
        }
        if (Input.GetKeyDown("1"))
        {
            controller.enabled = false;
            this.transform.position = new Vector3(0, 1, 0);
            controller.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
         #if UNITY_EDITOR
           UnityEditor.EditorApplication.isPlaying = false;
         #else
            Application.Quit();
         #endif
        }
    }
}
