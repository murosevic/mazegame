using UnityEngine;

public class MazeCreator : MonoBehaviour
{
    Chunk c = new Chunk(0);
    public GameObject cubePrefab;

    void Start()
    {
        DrawChunk();
    }

    void Update()
    {

    }
    
    public void DrawChunk()
    {
        Block b;

        for (int i = 0; i < c.blocks.GetLength(0); i++)
        {
            for (int j = 0; j < c.blocks.GetLength(1); j++)
            {
                b = c.blocks[i, j];
                b = new Block(i + c.chunkPos, j + c.chunkPos);
                b.cube = cubePrefab;
                Instantiate(b.cube, new Vector2(b.x + c.chunkPos, b.y + c.chunkPos), Quaternion.identity);
            }
        }
    }
}
