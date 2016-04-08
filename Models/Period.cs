using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UploadFileMVC.Models
{
    public class Period
    {
        public DateTime submission_deadline_date { get; set; }
        public string period_covered { get; set; }
        public HttpPostedFileBase File { get; set; }
        //public string fk_level_register { get; set; }
        //public DateTime date_modified { get; set; }
        //public string done_by { get; set; }
    }
}