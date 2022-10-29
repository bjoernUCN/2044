using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable_ : MonoBehaviour
{
    [SerializeField] private SelectionState ss = new SelectionState();

    private void LateUpdate()
    {
        if (ss == SelectionState.Selected)
        {
            //Debug.Log((int)ss);
            Debug.DrawRay(transform.position, Vector3.forward);
            Debug.DrawRay(transform.position, Vector3.up);
            Debug.DrawRay(transform.position, Vector3.back);

        }
    }

    public void Select()
    {
        ss = SelectionState.Selected;
    }

    public void DeSelect()
    {
        ss = SelectionState.UnSelected;
    }

    public SelectionState GetSelectionState()
    {
        return ss;
    }


}
