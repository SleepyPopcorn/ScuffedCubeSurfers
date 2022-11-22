using System.Collections.Generic;
using UnityEngine;

public class charStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();

    private GameObject lastBlockObject;

 
    void Start()
    {
        UpdateLastBlockObject();
    }

    public void IncreaseStack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.06f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - 0.06f, lastBlockObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        ScoreManager.instance.AddCube();
        UpdateLastBlockObject();
    }

    public void DecreaseStack(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        ScoreManager.instance.DecreaseCube();
        UpdateLastBlockObject();
    }

    public void DecreaseStackButKeepTheLastBoxNumber(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObject();
    }
      
    private void UpdateLastBlockObject()
    {
        lastBlockObject = blockList[blockList.Count - 1];
    }

    
}
