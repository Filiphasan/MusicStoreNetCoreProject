using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicSore.Entities.ViewModels
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez!"),StringLength(250,MinimumLength =3,ErrorMessage ="Şartlara uygun değerler giriniz!")]
        public string CategoryName { get; set; }
    }
}
