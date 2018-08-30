using System.ComponentModel.DataAnnotations;

namespace Zircon.Common.Admin.BindingModels
{
    public class AddCategoryBindingModel
    {
        [Required]
        public string Name { get; set; }
    }
}
