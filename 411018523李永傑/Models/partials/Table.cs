using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _411018523李永傑.Models.partials
{
    [MetadataType(typeof(TablesMetadata))]

    public class Table
    {
    }
    public class TablesMetadata
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "必填")]
        [Display(Name = "標題")]
        [StringLength(50)]

        public string Title { get; set; }
        [Required(ErrorMessage = "必填")]
        [Display(Name = "內容")]
        [StringLength(50)]

        public string Content { get; set; }
        [Required(ErrorMessage = "必填")]
        [Display(Name = "發布日期")]
        [StringLength(50)]

        public System.DateTime PublishDate { get; set; }
    }
}