﻿namespace WeChatApi.MediaPlatform
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class WeChatUserInfo
    {
        /// <summary>
        /// 用户是否订阅该公众号标识，值为0时，拉取不到其余信息
        /// </summary>
        public int subscribe { get; set; }

        /// <summary>
        /// 普通用户的标识，对当前公众号唯一
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// 用户的昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        ///  用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
        /// </summary>
        public int sex { get; set; }

        /// <summary>
        /// 用户所在城市
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 用户所在国家
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// 用户所在省份
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 用户的语言，zh-CN 简体，zh-TW 繁体，en 英语，默认为zh-CN
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// <para>用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。</para>
        /// <para>示例：http://wx.qlogo.cn/mmopen/g3MonUZtNHkdmzicIlibx6iaFqAc56vxLSUfpb6n5WKSYVY0ChQKkiaJSgQ1dZuTOgvLLrhJbERQQ4eMsv84eavHiaiceqxibJxCfHe/0 </para>
        /// </summary>
        public string headimgurl { get; set; }

        /// <summary>
        /// 获取指定大小的用户头像网址
        /// </summary>
        /// <param name="size">代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像）</param>
        /// <returns></returns>
        public string GetHeadImageUrl(int size = 0)
        {
            var url = headimgurl;
            if (url == null)
                return null;

            var tail = "/" + size.ToString("d");
            if (url.EndsWith(tail))
                return url;

            var slashIndex = url.LastIndexOf('/');
            if (slashIndex < 0)
                return url;

            return url.Substring(0, slashIndex) + tail;
        }

        /// <summary>
        ///  用户关注时间，为时间戳。如果用户曾多次关注，则取最后关注时间
        /// </summary>
        public long subscribe_time { get; set; }

        // TODO 临时关闭
        //public DateTimeOffset GetSubscribeTime()
        //{
        //    return DateTimeHelper.GetDateTimeFromXml(subscribe_time);
        //}

        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段
        /// </summary>
        public string unionid { get; set; }

        /// <summary>
        /// 公众号运营者对粉丝的备注，公众号运营者可在微信公众平台用户管理界面对粉丝添加备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        ///  用户所在的分组ID
        /// </summary>
        public int groupid { get; set; }


        /// <summary>
        /// 用户被打上的标签ID列表
        /// </summary>
        public int[] tagid_list { get; set; }
    }
}
