﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Traceless.OPQSDK.Models.Event
{
    public class GroupInviteArgs
    {
        /// <summary>
        /// 序列号
        /// </summary>
        public long Seq { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 邀请类型的文字描述（邀请加群）
        /// </summary>
        public string MsgTypeStr { get; set; }

        /// <summary>
        /// 被邀请的人
        /// </summary>
        public long Who { get; set; }

        /// <summary>
        /// 被邀请人的昵称
        /// </summary>
        public string WhoName { get; set; }

        /// <summary>
        /// 消息类型状态
        /// </summary>
        public string MsgStatusStr { get; set; }

        /// <summary>
        /// 识别号？
        /// </summary>
        public int Flag_7 { get; set; }

        /// <summary>
        /// 识别号
        /// </summary>
        public int Flag_8 { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        public long GroupId { get; set; }

        /// <summary>
        /// 群名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 邀请人(处理人)
        /// </summary>
        public int ActionUin { get; set; }

        /// <summary>
        /// 邀请人(处理人)昵称
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 邀请人(处理人)群名片
        /// </summary>
        public string ActionGroupCard { get; set; }

        /// <summary>
        /// --11 agree 14 忽略 12/21 disagree
        /// </summary>
        public int Action { get; set; }
    }
}