using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public GameObject panelWithButtons; // Define el campo para asignar el objeto del Panel desde el Inspector.
    public GameObject canvasToActivate;

    public void OnClick()
    {
        panelWithButtons.SetActive(false); // Desactiva el Panel que contiene los botones "Play" y "Exit".
        canvasToActivate.SetActive(true);
    }
}
