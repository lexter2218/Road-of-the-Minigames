using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScutiUtils.Systems
{
    public class CustomGrid
    {
        private int width, height;
        private int[,] data;

        public CustomGrid(int width, int height)
        {
            this.width = width;
            this.height = height;

            this.data = new int[width, height];

            // Debug.Log($"{width}x{height}");

            // for (int x = 0; x < width; x++)
            // {
            //     for (int y = 0; y < height; y++)
            //     {
            //         Debug.Log($"{x},{y}");
            //     }
            // }
        }
    }
}

