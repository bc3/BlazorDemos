using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace RadzenDropdownSample.Pages;

public partial class Validation : ComponentBase
{
    private AnyModel anyModelInstance = new AnyModel();
    
    private void Callback(EditContext obj)
    {
        Console.WriteLine(anyModelInstance.Name);
        Console.Write(obj);
    }
}

class AnyModel
{
    [Required]
    public string Name { get; set; }
}