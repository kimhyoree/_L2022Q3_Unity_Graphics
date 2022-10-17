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
            print("L down"); //LŰ�� ���� ������
            print(Light.name);
            isOn = !isOn; //Ʈ�縦 ������ ������ Ʈ��� �ٲ��ִ� �ڵ�
            Light.SetActive(isOn);
        }
    }

    private void OnMouseDown()
    {
        print(gameObject.name + "mouse down");
        isOn = !isOn; //Ʈ�縦 ������ ������ Ʈ��� �ٲ��ִ� �ڵ�
        Light.SetActive(isOn);
    }

}
