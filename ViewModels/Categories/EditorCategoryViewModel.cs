﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo devente conter entre 3 e 40 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O slug é obrigatório")]
        public string Slug { get; set; }
    }
}
