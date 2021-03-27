﻿using ERP.Common.NotifyProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WpfClient.Model
{
    public class CustomerModel : ViewModelBase
    {
        private int _Id;
        private string _firstName;
        private string _lastName;
        private string _contactNo;
        private string _address;
        private DateTime _createdDate;
        private string _createdBy;
        private DateTime? _updatedDate;
        private string _updatedBy;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; RaisePropertyChanged("Id"); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged("FirstName"); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged("LastName"); }
        }

        public string ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; RaisePropertyChanged("ContactNo"); }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; RaisePropertyChanged("Address"); }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; RaisePropertyChanged("CreatedDate"); }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; RaisePropertyChanged("CreatedBy"); }
        }

        public DateTime? UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; RaisePropertyChanged("UpdatedDate"); }
        }

        public string UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; RaisePropertyChanged("UpdatedBy"); }
        }
    }
}
