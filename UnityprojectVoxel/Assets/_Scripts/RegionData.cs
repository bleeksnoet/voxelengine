using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionData
{
    public TileType[] tiles;
    public int tileSize = 32;
    public int tileHeight = 32;
    public World worldReference;
    public Vector3Int worldPosition;
    
    public bool modifiedByThePlayer = false;
    
    public RegionData(int tileSize, int tileHeight, World world, Vector3Int worldPosition)
    {
        this.tileHeight = tileHeight;
        this.tileSize = tileSize;
        this.worldReference = world;
        this.worldPosition = worldPosition;
        tiles = new TileType[tileSize * tileHeight * tileSize];
        
    }
}
