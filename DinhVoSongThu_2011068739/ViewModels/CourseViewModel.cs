using DinhVoSongThu_2011068739.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace DinhVoSongThu_2011068739.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}