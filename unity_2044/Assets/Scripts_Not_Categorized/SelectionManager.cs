using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private List<Selectable_> selectable_s = new List<Selectable_>();


    public void ToggleSelectAtPosition()
    {
        RaycastHit hit = InputManager.Instance.GetHit();
        //Debug.Log(InputManager.Instance);

       if (hit.transform != null) //WE HIT SOMETHING WITH RAY
        {
       if (hit.transform.gameObject.GetComponent<Selectable_>() != null)
        {
            Selectable_ s = hit.transform.gameObject.GetComponent<Selectable_>();
            SelectionState sa = s.GetSelectionState();
            if (sa == SelectionState.UnSelected)
            {
                s.Select();
                    selectable_s.Add(s);
            }
            else
            {
                s.DeSelect();
                    selectable_s.Remove(s);
            }
        }
        }
        else //WE DID NOT
        {
            DeSelectAll();
        }
    }


    public void DeSelectAll()
    {
        foreach (Selectable_ s in selectable_s)
        {
            s.DeSelect();
        }
        selectable_s.Clear();
    }



}
