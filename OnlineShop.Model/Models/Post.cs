﻿using OnlineShop.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự động tăng
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public String Name { get; set; }

        [Required]
        [MaxLength(250)]
        public String Alias { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }


        #region Khóa ngoại
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }

        #endregion

    }
}