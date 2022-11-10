using Microsoft.AspNetCore.Mvc.Rendering;

namespace animalrescue.mainmodule.web.helpers
{
    public static class SelectListeItemExtensions
    {
        public static ICollection<SelectListItem> AddDefaultItem(this ICollection<SelectListItem> options, bool isSelected = true, bool sortByValue = true)
        {
            options.Add(new SelectListItem{
                Value = "-1",
                Text = "--Select--",
                Selected = isSelected
            });
            return options.OrderBy(o => o.Value).ToList();
        }
    }
}