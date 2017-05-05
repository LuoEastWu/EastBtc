using System;

namespace JY.Model
{
    public class SessionUser
    {
        private long _Id;
        private long _UserId;
        private long _RoleId;
        private string _UserType;
        private string _UserName;
        private string _AidRuleId;

        public long Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }
        }

        public long UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this._UserId = value;
            }
        }

        public long RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                _RoleId = value;
            }
        }

        public string AidRuleId
        {
            get
            {
                return this._AidRuleId;
            }
            set
            {
                this._AidRuleId = value;
            }
        }

        public string UserType
        {
            get
            {
                return this._UserType;
            }
            set
            {
                this._UserType = value;
            }
        }

        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                this._UserName = value;
            }
        }
    }
}

