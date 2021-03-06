﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    public class GetCampaign_PictureVoteItemListArgs : GetItemListArgs
    {

        public Guid CampaignId
        {
            get;
            set;
        }

        public EnumCampaignPictureVoteItemApproveStatus? ApproveStatus
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string MemberName
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public const string DefaultOrderBy = "UploadTime";
        private string _orderBy = DefaultOrderBy;
        public string OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }
    }
}
