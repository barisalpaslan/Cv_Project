﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.TBL_YETENEKLER.ToList();
            Repeater4.DataBind();

            Repeater5.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_ILETISIM t = new TBL_ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.TBL_ILETISIM.Add(t);
            db.SaveChanges();
        }
    }
}