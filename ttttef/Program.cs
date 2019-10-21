using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ttttef
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var ctx = new ttContent())
            //{
            //    var tc = new teacther
            //    {
            //        FirstName = "text",
            //        SecondName="dd",
            //        Classorder="ttttt"
            //    };

            //    ctx.Teacther.Add(tc);
            //    ctx.SaveChanges();

            //}

            ContentHelp ch = new ContentHelp();
            teacther t = new teacther();
            t.FirstName = "1";
            t.SecondName = "2";
            t.Classorder = "3";

            ch.Add(t);

            //var aa = ch.GetList<teacther>().ToList();
            //var bb = ch.GetListByConditions<teacther>(x => x.ID == 1).ToList();

            //var cc = ch.GetModelByConditions<teacther>(x => x.ID == 2);
            //var tc = new teacther
            //{
            //    FirstName = "text",
            //    SecondName = "dd",
            //    Classorder = "ttttt"
            //};
            //var dd = ch.Add(tc);

            //List<teacther> tlist = new List<teacther>();
            //for (int i = 0; i < 5; i++)
            //{
            //    var teacther = new teacther
            //    {
            //        FirstName = "name"+i.ToString(),
            //        SecondName = "dis" + i.ToString(),
            //        Classorder = i.ToString()
            //    };
            //    tlist.Add(teacther);
            //}
            //var ee = ch.AddRange(tlist);

            //teacther tt = ch.GetModelByConditions<teacther>(x => x.ID == 4);
            //if (tt!=null)
            //{
            //    tt.Classorder = "change";
            //}
            //var ff = ch.Update(tt);
            
            //var gg = ch.Del<teacther>(8);

        }
    }
}
