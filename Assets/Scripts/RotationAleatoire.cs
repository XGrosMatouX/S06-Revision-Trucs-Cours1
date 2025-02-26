using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAleatoire : MonoBehaviour
{
    void Start()
    {
        // Rotation completement aleatoire
        // transform.rotation = Random.rotation;

        // Rotation aléeatore entre une rangé des valeurs
    }
    private void Update()
    {
        transform.rotation = Random.rotation;
    }
}
