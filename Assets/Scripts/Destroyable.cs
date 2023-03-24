using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    GameController gameController;
    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
    }
    // script for the target
    public int timeBonus = 10;
    private void OnCollisionEnter(Collision collision)
    {
        print("collided");
        // destroy this object
        DestroyObject(gameObject);
    }
    private void OnDestroy()
    {
        // tell the game controller
        if (gameController != null)
        {
            gameController.TargetDestroyed();
        }
    }
}
