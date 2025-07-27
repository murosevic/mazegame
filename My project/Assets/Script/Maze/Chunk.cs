using Unity.Collections;
using UnityEngine;

public class Chunk
{
    public Block[,] blocks = new Block[8,8];

    public int chunkPos;

    public Chunk(int chunkPos)
    {
        this.chunkPos = chunkPos;
    }
}