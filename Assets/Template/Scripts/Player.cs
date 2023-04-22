using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, IAliveObject
{
    public void Die()
    {
        Image[] images = gameObject.GetComponent<HealthSystem>().hearts;
        foreach (Image image in images)
        {
            image.enabled = false;
        }
        Destroy(gameObject);
    }
}
