using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAleatoire : MonoBehaviour
{
    void Start()
    {
        // Rotation completement aleatoire
        // transform.rotation = Random.rotation;

        // Rotation al�eatore entre une rang� des valeurs
    }
    private void Update()
    {
        transform.rotation = Random.rotation;
    }
}
