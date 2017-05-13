using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

/*
 * This works with the drag handler to allow the child of a parent be able to move.
 * In the reference page*/

public class Slot : MonoBehaviour, IDropHandler
{

    public GameObject item
    {
        get
        {
            if (transform.childCount > 0) //if there is no object there
            {
                return transform.GetChild(0).gameObject; // this will put the child back to where the parent is so it doesnt just hover in empty space
            }
            return null;
        }
    }
    #region IdropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragHandler.item.transform.SetParent(transform); //changes where the child obeject goes so it can stay where it is.
        }
    }
    #endregion

}