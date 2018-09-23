namespace Zircon.Common.Admin.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddCategoryBindingModel
    {
        [Required]
        public string Name { get; set; }
    }
}
