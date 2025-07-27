using Mono.Cecil;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Block
{
    public int x, y;
    public int size = 2;
    public GameObject cube;

    public Block(int x, int y)
    {
        this.x = x * size;
        this.y = y * size;
    }
}