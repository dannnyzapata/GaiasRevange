using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Desactivar : MonoBehaviour
{
    public Button Boton;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivarBoton());
    }

    public IEnumerator ActivarBoton()
    {

        Boton = gameObject.GetComponent<Button>();

        Boton.interactable = false;
        yield return new WaitForSeconds(6f);
        Boton.interactable = true; 



    }

}
