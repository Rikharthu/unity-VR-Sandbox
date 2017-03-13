using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RadialProgressBar : MonoBehaviour
{

    public Transform LoadingBar;
    public Transform TextIndicator;
    public Transform TextLoading;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            // Loading...
			currentAmount+=speed*Time.deltaTime;
			TextIndicator.GetComponent<Text>().text=((int)currentAmount).ToString()+"%";
			TextLoading.gameObject.SetActive(true);
        }
        else
        {
            // Done
			TextLoading.gameObject.SetActive(false);
			TextIndicator.GetComponent<Text>().text = "DONE!";
        }

		LoadingBar.GetComponent<Image>().fillAmount = currentAmount/100;
    }
}
