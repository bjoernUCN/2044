using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SelectionManager))]
public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; } //Inputmanager is a singleton
    [SerializeField] List<KeyCode> keys = new List<KeyCode>();
    public Camera camRaycam;
    SelectionManager selectionManager;

    public Vector3 GetMousePosition()
    {
        Ray temp = camRaycam.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up,-Vector3.up/2);
        float outFloat=0;

        plane.Raycast(temp, out outFloat);

        //Debug.Log(outFloat);
        //Debug.Log(temp);
        
        return temp.GetPoint(outFloat);
    }

    public RaycastHit GetHit()
    {
        
        Ray temp = camRaycam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(temp, out hit))
        {
            Debug.Log(hit.transform.gameObject.name);
        }
        
        return hit;
    }




    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }


        selectionManager = GetComponent<SelectionManager>();
    }

    void Update()
    {
        if (CheckKD(keys[0])) //Select
        {
           selectionManager.ToggleSelectAtPosition();
        }

        if (CheckKD(keys[1])) //Cmd
        {

        }


    }

    private bool CheckKD(KeyCode k)
    {
        return Input.GetKeyDown(k);
    }
    private bool Check(KeyCode k)
    {
        return Input.GetKey(k);
    }

}

/*Debug.DrawLine(Vector3.zero, GetMousePosition());
       Vector3 pos = GetMousePosition();
       transform.position = pos + new Vector3(0,-5,0);*/