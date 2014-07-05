using UnityEngine;
using System.Collections;

public class Medal : MonoBehaviour
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
