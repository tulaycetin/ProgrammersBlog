﻿using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ArticleUpdateDto
    {
        [Required]
                                                                                               public int Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]                public string Title { get; set; }

        [DisplayName("İçerik")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]                public string Content { get; set; }

        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]                 public string Thumbnail { get; set; }

        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy")]      public DateTime Date { get; set; }

        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]                   public string SeoAuthor { get; set; }
            
        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]                   public string SeoDescription { get; set; }

        [DisplayName("Seo Etiketler")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]                   public string SeoTags { get; set; }

        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]                                  public int categoryId { get; set; }
                                                                                              public Category Category { get; set; }

        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]                                   public bool IsActive { get; set; }

        [DisplayName("Silinsin mi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")] public bool ISDelete { get; set; }

    }
}
