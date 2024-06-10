using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class SaveSystem : MonoBehaviour
{
    [SerializeField] private Transform _leftDoor;
    [SerializeField] private Transform _rightDoor;
    [SerializeField] private Transform cube1;
    [SerializeField] private Transform cube2;
    [SerializeField] private Transform cube3;
    [SerializeField] private Transform cube4;

    private DataStorage _data = new DataStorage();
    private string _path;

    private void Start()
    {
        _path = Path.Combine(Application.persistentDataPath, "data.json");

        Debug.Log(_leftDoor.transform.localRotation.x);
        Debug.Log(_leftDoor.transform.localRotation.y);
        Debug.Log(_leftDoor.transform.localRotation);

        if (File.Exists(_path))
        {
            _data = JsonUtility.FromJson<DataStorage>(File.ReadAllText(_path));

            _leftDoor.transform.localPosition = new Vector3(
                _data.leftDoor.positionX,
                _data.leftDoor.positionY,
                _data.leftDoor.positionZ);
            _leftDoor.transform.localRotation = new Quaternion(
                _data.leftDoor.positionX,
                _data.leftDoor.positionY,
                _data.leftDoor.positionZ,
                _data.leftDoor.rotationW);
        }

        Debug.Log(_leftDoor.transform.localRotation.x);
        Debug.Log(_leftDoor.transform.localRotation.y);
        Debug.Log(_leftDoor.transform.localRotation);
    }

    public void SaveData()
    {
        _data.leftDoor.positionX = _leftDoor.localPosition.x;
        _data.leftDoor.positionY = _leftDoor.localPosition.y;
        _data.leftDoor.positionZ = _leftDoor.localPosition.z;
        _data.leftDoor.rotationX = _leftDoor.localRotation.x;
        _data.leftDoor.rotationY = _leftDoor.localRotation.y;
        _data.leftDoor.rotationZ = _leftDoor.localRotation.z;
        _data.leftDoor.rotationW = _leftDoor.localRotation.w;

        var json = JsonUtility.ToJson(_data);

        using (var writer = new StreamWriter(_path))
        {
            writer.WriteLine(json);
        }
        Debug.Log("123123");
    }
}
