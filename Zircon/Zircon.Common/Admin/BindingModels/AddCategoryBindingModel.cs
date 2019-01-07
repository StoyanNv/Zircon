namespace Zircon.Common.Admin.BindingModels
{
    using Constrants;
    using System.ComponentModel.DataAnnotations;

    public class AddCategoryBindingModel
    {
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Display(Name = AttributeConstraintsConstants.NameDisplay)]
        public string Name { get; set; }
    }
}
