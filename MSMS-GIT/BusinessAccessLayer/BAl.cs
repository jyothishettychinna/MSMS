using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSMS_GIT.IRepository;
using MSMS_GIT.Repository;

namespace MSMS_GIT.BusinessAccessLayer
{
    public class BAl
    {
        IReposit Iobj;
        public BAl(Reposit Iobj1)
        {
            Iobj = Iobj1;
        }
    }
}

