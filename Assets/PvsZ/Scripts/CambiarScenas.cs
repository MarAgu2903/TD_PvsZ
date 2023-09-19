using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarScenas : MonoBehaviour
{

    public void Cambiar(string nombre)
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene(nombre);
    }
}
