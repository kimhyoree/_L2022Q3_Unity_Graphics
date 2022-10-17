using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Controller : MonoBehaviour
{
    public GameObject Light;
    bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        Light.SetActive(isOn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L down"); //L키를 누를 때마다
            print(Light.name);
            isOn = !isOn; //트루를 폴스로 폴스를 트루로 바꿔주는 코드
            Light.SetActive(isOn);
        }
    }

    private void OnMouseDown()
    {
        print(gameObject.name + "mouse down");
        isOn = !isOn; //트루를 폴스로 폴스를 트루로 바꿔주는 코드
        Light.SetActive(isOn);
    }

}
