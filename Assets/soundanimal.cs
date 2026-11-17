using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundanimal : MonoBehaviour
{
    [SerializeField] AudioSource dogvoice;

    void PlayAnimalSound()
    {
        // Vérifier si le AudioClip est défini
        if (dogvoice.clip != null)
        {
            // Jouer le son de l'animal
            dogvoice.Play();
        }
        else
        {
            Debug.LogError("Le son de l'animal n'est pas défini. Veuillez attacher un AudioClip dans l'inspecteur.");
        }
    }
}
