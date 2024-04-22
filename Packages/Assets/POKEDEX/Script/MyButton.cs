using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToDisable; // L'objet à désactiver

    void Start()
    {
        // Obtenir le composant Button et ajouter un écouteur à l'événement de clic
        GetComponent<Button>().onClick.AddListener(DisableObject);
    }

    void DisableObject()
    {
        // Désactiver l'objet
        objectToDisable.SetActive(false);
    }
}

