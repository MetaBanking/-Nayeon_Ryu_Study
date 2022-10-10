using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManagerLogic : MonoBehaviour
{
    public int totalItemCount;
    public int stage;
    public TextMeshProUGUI stageCountText;
    public TextMeshProUGUI playerCountText;

    void Awake()
    {
        stageCountText.text = "/ " + totalItemCount;
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }    
    }
}
