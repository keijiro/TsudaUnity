using UnityEngine;
using System.Collections;

public class Gold : MonoBehaviour
{
    public GameObject clearText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            clearText.SetActive(true);
        }
    }
}
