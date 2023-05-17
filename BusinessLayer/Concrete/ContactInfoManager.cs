using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class ContactInfoManager : IContactInfoService
    {
        private readonly IContactInfoService _contactInfoService;
        public ContactInfoManager(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }
        public void TDelete(ContactInfo t)
        {
            throw new NotImplementedException();
        }

        public ContactInfo TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactInfo> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ContactInfo t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
