using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.Events;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class ControlVidas:MonoBehaviour
{
    public void OnQuitarVida(){
        GameManager.Instance.LoseLife();

        int vidasActuales = GameManager.Instance.CurrentLives;
        Debug.Log("Cantidad Vidas: " + vidasActuales);
    }

}
