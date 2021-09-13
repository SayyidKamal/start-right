using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace start_right.Module.BusinessObjects.StartRight
{
    [DefaultClassOptions]
    [FriendlyKeyProperty("IdName")]
    [DefaultProperty("IdName")]

    public partial class tblStudent
    {
        public tblStudent(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
