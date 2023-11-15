using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorVidas : MonoBehaviour
{
    [SerializeField]
    private TMP_Text contador;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        contador.SetText(GameManager.Instance.CurrentLives.ToString());
        // Verificar si el contador ha llegado a cero
        if (GameManager.Instance.CurrentLives <= 0)
        {
            // Cambiar a escena perdio
            UnityEngine.SceneManagement.SceneManager.LoadScene("Perdio");
        }
    }
}