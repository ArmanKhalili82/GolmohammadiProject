﻿namespace GolmohammadiProject.Models.Product;

public class ProductGroup
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<SubGroup> subGroups { get; set; }
}
