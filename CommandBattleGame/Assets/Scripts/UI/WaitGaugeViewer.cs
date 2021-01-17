using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitGaugeViewer : MonoBehaviour
{

    public Image[] CharacterGaugeImages = new Image[3];
    public float[] CharacterSpeeds = new float[3];
    // Start is called before the first frame update
   public  void Init()
    {
        for (int i = 0; i < 3; i ++)
        {
            CharacterGaugeImages[i].fillAmount = 0;
        }
    }

    // Update is called once per frame
   public  void WaitGaugeUpDate()
    {
        for (int i = 0; i < 3; i++)
        {
            CharacterGaugeImages[i].fillAmount += CharacterSpeeds[i] / 10000f;
        }
    }

    private void LateUpdate()
    {
        WaitGaugeUpDate();
    }
}
