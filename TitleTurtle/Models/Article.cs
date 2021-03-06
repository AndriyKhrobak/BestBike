﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TitleTurtle.Models
{

    public class Article
    {
        [Key]
        public int ArticleID { get; set; }
        public int UserID { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        [Required]
        [Display(Name = "Название")]
        [StringLength(50, ErrorMessage = "Строка не может быть меньше 5 сымволов и больше 50 символов.", MinimumLength = 5)]
        public string ArticleTitle { get; set; }
        public string Sex { get; set; }
        public string Hight { get; set; }
        public string Place { get; set; }
        public string Rama { get; set; }
        public string MasaRovera { get; set; }
        public string Amortizator { get; set; }
        public string Speeds { get; set; }
        [Required]
        [Display(Name = "Текст статьи")]
        [StringLength(500000, ErrorMessage = "Строка не может быть больше, чем 500000 символов.")]
        public string ArticleText { get; set; }
        [Display(Name = "Статус")]
        public int ArticleStatus { get; set; }
        [Display(Name = "Количество коментариев")]
        public int CommentCount { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual Like Like { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Edit> Edits { get; set; }
        public virtual ICollection<MediaInArticle> MedialInArticles { get; set; }
        public virtual ICollection<TagInArticle> TagInArticles { get; set; }

    }
}

