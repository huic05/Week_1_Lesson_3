using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider hitBox)
    {
        hitBox.transform.position += new Vector3(0, 5, 0);
    }
}
