using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManger gamemanger;

    void OnTriggerEnter()
    {
        gamemanger.CompleteLevel();
    }
} 

