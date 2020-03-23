using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector3 world_position;

    
    public int g_cost;
    public int h_cost;
    public int grid_x, grid_y;
    public Node parent;

    public Node(bool walkable, Vector3 world_position, int grid_x, int grid_y)
    {
        this.walkable = walkable;
        this.world_position = world_position;
        this.grid_x = grid_x;
        this.grid_y = grid_y;
    }
    public int f_cost { get{return g_cost + h_cost;} }
}
