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
    [FriendlyKeyProperty("subjectName")]
    [DefaultProperty("subjectName")]

    public partial class tblSubject
    {
        public tblSubject(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
