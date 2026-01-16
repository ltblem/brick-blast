using UnityEngine;

public class Shape: MonoBehaviour
{
    public ShapeData data;
    public GameObject cellPrefab;
    public float cellSize = 1f;

    void Start()
    {
        Build();
    }

    void Build()
    {
        foreach (Vector2Int cell in data.cells)
        {
            GameObject cellGo = Instantiate(cellPrefab, transform);
            cellGo.transform.localPosition = new Vector3(
                cell.x * cellSize,
                cell.y * cellSize,
                0f
            );
        }
    }
}