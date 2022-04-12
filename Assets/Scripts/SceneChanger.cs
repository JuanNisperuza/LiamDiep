using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public int index;
    public string levelName;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (levelName == "RightChanger")

            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 20, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
            else
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 20, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }


           }

    }

    private void Start()
    {
        levelName = gameObject.name;
    }
}
