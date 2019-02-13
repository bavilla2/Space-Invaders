using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class LiveScript : MonoBehaviour
{
    TextMeshProUGUI LifeText;
    // Start is called before the first frame update
    void Start()
    {
        LifeText = this.GetComponent<TextMeshProUGUI>();
        LevelManager.instance.onLiveUpdate.AddListener(UpdateLives);
    }

    // Update is called once per frame
    void UpdateLives(int newVal)
    {
        LifeText.text = string.Format("Lives: {0}", newVal);
    }
}
