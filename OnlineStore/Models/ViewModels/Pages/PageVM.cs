﻿using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models.ViewModels.Pages
{
    public class PageVM
    {
        public PageVM()
        {

        }
        public PageVM(PagesDTO row)
        {
            Id = row.Id;
            Title = row.Title;
            Slug = row.Slug;
            Body = row.Body;
            Sorting = row.Sorting;
            HasSidebar = row.HasSidebar;
        }

        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength =3)]
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        public string Body { get; set; }
        public int Sorting { get; set; }
        public bool HasSidebar { get; set; }
    }
}