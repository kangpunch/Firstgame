using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerLogic : MonoBehaviour
{
    public int TotalItemCount;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;
    void Awake() 
    {
        stageCountText.text = " / " + TotalItemCount;
    }
    void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        SceneManager.LoadScene(stage);

    }

}
