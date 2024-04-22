using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToDisable; // L'objet � d�sactiver

    void Start()
    {
        // Obtenir le composant Button et ajouter un �couteur � l'�v�nement de clic
        GetComponent<Button>().onClick.AddListener(DisableObject);
    }

    void DisableObject()
    {
        // D�sactiver l'objet
        objectToDisable.SetActive(false);
    }
}

