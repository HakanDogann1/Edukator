using DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepositories<Contact>, IContactDal
    {
        public List<Contact> GetLast4Message()
        {
            using var context = new Context();
            return context.Contacts.OrderByDescending(x => x.ContactID).Take(4).ToList();
        }
    }
}
