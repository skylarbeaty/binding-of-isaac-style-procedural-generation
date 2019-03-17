using UnityEngine;

[System.Serializable]
public class ColorToGameObject { //this is a class, rather than a struct, because structs are not serializable in Unity
	public Color color;
	public GameObject prefab;
}
