using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;

namespace GetStartedWinForms;

public class Category
{
    public int CategoryID {  get; set; }
    public string? Name { get; set; } 
    public virtual ObservableCollectionListSource<Product> Products { get; } = new ();
}