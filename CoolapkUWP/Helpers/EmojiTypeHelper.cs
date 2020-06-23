﻿using CoolapkUWP.Models.Controls.MakeFeedControlModel;
using System.Collections.Immutable;

namespace CoolapkUWP.Helpers
{
    internal static class EmojiTypeHelper
    {
        public static ImmutableArray<EmojiTypeHeader> TypeHeaders { get; private set; }

        static EmojiTypeHelper()
        {
            var buider = ImmutableArray.CreateBuilder<EmojiTypeHeader>();
            var dataBuider = ImmutableArray.CreateBuilder<EmojiData>();

            #region []

            dataBuider.Add(new EmojiData("[cos滑稽]"));
            dataBuider.Add(new EmojiData("[dw哭]"));
            dataBuider.Add(new EmojiData("[NO]"));
            dataBuider.Add(new EmojiData("[ok]"));
            dataBuider.Add(new EmojiData("[py交易]"));
            dataBuider.Add(new EmojiData("[qqdoge]"));
            dataBuider.Add(new EmojiData("[t耐克嘴]"));
            dataBuider.Add(new EmojiData("[不开心]"));
            dataBuider.Add(new EmojiData("[乒乓]"));
            dataBuider.Add(new EmojiData("[二哈]"));
            dataBuider.Add(new EmojiData("[二哈盯]"));
            dataBuider.Add(new EmojiData("[亲亲]"));
            dataBuider.Add(new EmojiData("[便便]"));
            dataBuider.Add(new EmojiData("[假笑]"));
            dataBuider.Add(new EmojiData("[偷看]"));
            dataBuider.Add(new EmojiData("[傲慢]"));
            dataBuider.Add(new EmojiData("[再见]"));
            dataBuider.Add(new EmojiData("[冷汗]"));
            dataBuider.Add(new EmojiData("[凋谢]"));
            dataBuider.Add(new EmojiData("[刀]"));
            dataBuider.Add(new EmojiData("[勾引]"));
            dataBuider.Add(new EmojiData("[卖萌]"));
            dataBuider.Add(new EmojiData("[发呆]"));
            dataBuider.Add(new EmojiData("[发怒]"));
            dataBuider.Add(new EmojiData("[发抖]"));
            dataBuider.Add(new EmojiData("[受虐滑稽]"));
            dataBuider.Add(new EmojiData("[可怜]"));
            dataBuider.Add(new EmojiData("[可爱]"));
            dataBuider.Add(new EmojiData("[右哼哼]"));
            dataBuider.Add(new EmojiData("[吃瓜]"));
            dataBuider.Add(new EmojiData("[吐]"));
            dataBuider.Add(new EmojiData("[吐舌]"));
            dataBuider.Add(new EmojiData("[吓]"));
            dataBuider.Add(new EmojiData("[呲牙]"));
            dataBuider.Add(new EmojiData("[呵呵]"));
            dataBuider.Add(new EmojiData("[咒骂]"));
            dataBuider.Add(new EmojiData("[咖啡]"));
            dataBuider.Add(new EmojiData("[哈哈]"));
            dataBuider.Add(new EmojiData("[哈哈哈]"));
            dataBuider.Add(new EmojiData("[哈欠]"));
            dataBuider.Add(new EmojiData("[哦吼吼]"));
            dataBuider.Add(new EmojiData("[哼唧]"));
            dataBuider.Add(new EmojiData("[啤酒]"));
            dataBuider.Add(new EmojiData("[喝茶]"));
            dataBuider.Add(new EmojiData("[喝酒]"));
            dataBuider.Add(new EmojiData("[喵喵]"));
            dataBuider.Add(new EmojiData("[喵喵互粉]"));
            dataBuider.Add(new EmojiData("[喵喵再见]"));
            dataBuider.Add(new EmojiData("[喵喵原谅ta]"));
            dataBuider.Add(new EmojiData("[喵喵口罩]"));
            dataBuider.Add(new EmojiData("[喵喵吃惊]"));
            dataBuider.Add(new EmojiData("[喵喵吃瓜]"));
            dataBuider.Add(new EmojiData("[喵喵告辞]"));
            dataBuider.Add(new EmojiData("[喵喵呵斥]"));
            dataBuider.Add(new EmojiData("[喵喵并不简单]"));
            dataBuider.Add(new EmojiData("[喵喵期待]"));
            dataBuider.Add(new EmojiData("[喵喵汗]"));
            dataBuider.Add(new EmojiData("[喵喵疑问]"));
            dataBuider.Add(new EmojiData("[喵喵笑哭]"));
            dataBuider.Add(new EmojiData("[喵喵装酷]"));
            dataBuider.Add(new EmojiData("[喵喵鄙视]"));
            dataBuider.Add(new EmojiData("[喵喵酷]"));
            dataBuider.Add(new EmojiData("[喵喵问号]"));
            dataBuider.Add(new EmojiData("[喵喵飞吻]"));
            dataBuider.Add(new EmojiData("[喷]"));
            dataBuider.Add(new EmojiData("[喷血]"));
            dataBuider.Add(new EmojiData("[嘘]"));
            dataBuider.Add(new EmojiData("[嘿哈]"));
            dataBuider.Add(new EmojiData("[嘿嘿]"));
            dataBuider.Add(new EmojiData("[噗]"));
            dataBuider.Add(new EmojiData("[困]"));
            dataBuider.Add(new EmojiData("[坏笑]"));
            dataBuider.Add(new EmojiData("[墨镜滑稽]"));
            dataBuider.Add(new EmojiData("[大兵]"));
            dataBuider.Add(new EmojiData("[大哭]"));
            dataBuider.Add(new EmojiData("[太阳]"));
            dataBuider.Add(new EmojiData("[奋斗]"));
            dataBuider.Add(new EmojiData("[奸笑]"));
            dataBuider.Add(new EmojiData("[委屈]"));
            dataBuider.Add(new EmojiData("[害怕]"));
            dataBuider.Add(new EmojiData("[害羞]"));
            dataBuider.Add(new EmojiData("[小嘴滑稽]"));
            dataBuider.Add(new EmojiData("[小纠结]"));
            dataBuider.Add(new EmojiData("[尴尬]"));
            dataBuider.Add(new EmojiData("[左哼哼]"));
            dataBuider.Add(new EmojiData("[差劲]"));
            dataBuider.Add(new EmojiData("[弱]"));
            dataBuider.Add(new EmojiData("[强]"));
            dataBuider.Add(new EmojiData("[得意]"));
            dataBuider.Add(new EmojiData("[微微一笑]"));
            dataBuider.Add(new EmojiData("[微笑]"));
            dataBuider.Add(new EmojiData("[心碎]"));
            dataBuider.Add(new EmojiData("[快哭了]"));
            dataBuider.Add(new EmojiData("[怄火]"));
            dataBuider.Add(new EmojiData("[惊喜]"));
            dataBuider.Add(new EmojiData("[惊恐]"));
            dataBuider.Add(new EmojiData("[惊讶]"));
            dataBuider.Add(new EmojiData("[憨笑]"));
            dataBuider.Add(new EmojiData("[懒得理]"));
            dataBuider.Add(new EmojiData("[我最美]"));
            dataBuider.Add(new EmojiData("[托腮]"));
            dataBuider.Add(new EmojiData("[抓狂]"));
            dataBuider.Add(new EmojiData("[折磨]"));
            dataBuider.Add(new EmojiData("[抠鼻]"));
            dataBuider.Add(new EmojiData("[抱拳]"));
            dataBuider.Add(new EmojiData("[拥抱]"));
            dataBuider.Add(new EmojiData("[拳头]"));
            dataBuider.Add(new EmojiData("[挑眉坏笑]"));
            dataBuider.Add(new EmojiData("[挨打]"));
            dataBuider.Add(new EmojiData("[捂嘴笑]"));
            dataBuider.Add(new EmojiData("[捂脸]"));
            dataBuider.Add(new EmojiData("[掩面笑]"));
            dataBuider.Add(new EmojiData("[握手]"));
            dataBuider.Add(new EmojiData("[撇嘴]"));
            dataBuider.Add(new EmojiData("[擦汗]"));
            dataBuider.Add(new EmojiData("[敲打]"));
            dataBuider.Add(new EmojiData("[斗鸡眼滑稽]"));
            dataBuider.Add(new EmojiData("[斜眼笑]"));
            dataBuider.Add(new EmojiData("[无奈]"));
            dataBuider.Add(new EmojiData("[无语]"));
            dataBuider.Add(new EmojiData("[晕]"));
            dataBuider.Add(new EmojiData("[月亮]"));
            dataBuider.Add(new EmojiData("[机智]"));
            dataBuider.Add(new EmojiData("[欢呼]"));
            dataBuider.Add(new EmojiData("[汗]"));
            dataBuider.Add(new EmojiData("[泪奔]"));
            dataBuider.Add(new EmojiData("[流汗]"));
            dataBuider.Add(new EmojiData("[流汗滑稽]"));
            dataBuider.Add(new EmojiData("[流泪]"));
            dataBuider.Add(new EmojiData("[滑稽]"));
            dataBuider.Add(new EmojiData("[火把]"));
            dataBuider.Add(new EmojiData("[炸弹]"));
            dataBuider.Add(new EmojiData("[爆怒]"));
            dataBuider.Add(new EmojiData("[爱你]"));
            dataBuider.Add(new EmojiData("[爱心]"));
            dataBuider.Add(new EmojiData("[爱情]"));
            dataBuider.Add(new EmojiData("[牛啤]"));
            dataBuider.Add(new EmojiData("[猪头]"));
            dataBuider.Add(new EmojiData("[玫瑰]"));
            dataBuider.Add(new EmojiData("[瓢虫]"));
            dataBuider.Add(new EmojiData("[疑问]"));
            dataBuider.Add(new EmojiData("[白眼]"));
            dataBuider.Add(new EmojiData("[皱眉]"));
            dataBuider.Add(new EmojiData("[睡]"));
            dataBuider.Add(new EmojiData("[示爱]"));
            dataBuider.Add(new EmojiData("[礼物]"));
            dataBuider.Add(new EmojiData("[笑哭]"));
            dataBuider.Add(new EmojiData("[笑哭再见]"));
            dataBuider.Add(new EmojiData("[笑眼]"));
            dataBuider.Add(new EmojiData("[篮球]"));
            dataBuider.Add(new EmojiData("[糗大了]"));
            dataBuider.Add(new EmojiData("[红药丸]"));
            dataBuider.Add(new EmojiData("[绿帽]"));
            dataBuider.Add(new EmojiData("[绿药丸]"));
            dataBuider.Add(new EmojiData("[耐克嘴]"));
            dataBuider.Add(new EmojiData("[耶]"));
            dataBuider.Add(new EmojiData("[胜利]"));
            dataBuider.Add(new EmojiData("[舒服]"));
            dataBuider.Add(new EmojiData("[舔]"));
            dataBuider.Add(new EmojiData("[色]"));
            dataBuider.Add(new EmojiData("[菜刀]"));
            dataBuider.Add(new EmojiData("[蛋糕]"));
            dataBuider.Add(new EmojiData("[表面哭泣]"));
            dataBuider.Add(new EmojiData("[表面开心]"));
            dataBuider.Add(new EmojiData("[衰]"));
            dataBuider.Add(new EmojiData("[西瓜]"));
            dataBuider.Add(new EmojiData("[调皮]"));
            dataBuider.Add(new EmojiData("[足球]"));
            dataBuider.Add(new EmojiData("[跳跳]"));
            dataBuider.Add(new EmojiData("[转圈]"));
            dataBuider.Add(new EmojiData("[鄙视]"));
            dataBuider.Add(new EmojiData("[酷]"));
            dataBuider.Add(new EmojiData("[酷安]"));
            dataBuider.Add(new EmojiData("[酷安绿帽]"));
            dataBuider.Add(new EmojiData("[酷安钓鱼]"));
            dataBuider.Add(new EmojiData("[闪电]"));
            dataBuider.Add(new EmojiData("[闭嘴]"));
            dataBuider.Add(new EmojiData("[阴险]"));
            dataBuider.Add(new EmojiData("[难过]"));
            dataBuider.Add(new EmojiData("[飞吻]"));
            dataBuider.Add(new EmojiData("[饥饿]"));
            dataBuider.Add(new EmojiData("[饭]"));
            dataBuider.Add(new EmojiData("[骚扰]"));
            dataBuider.Add(new EmojiData("[骷髅]"));
            dataBuider.Add(new EmojiData("[黑线]"));
            dataBuider.Add(new EmojiData("[鼓掌]"));
            dataBuider.Add(new EmojiData("[Blob滑稽]"));
            dataBuider.Add(new EmojiData("[Google滑稽]"));
            dataBuider.Add(new EmojiData("[SegoeUI滑稽]"));

            buider.Add(new EmojiTypeHeader("一般", dataBuider.ToImmutable()));
            dataBuider.Clear();

            #endregion []

            #region doge

            dataBuider.Add(new EmojiData("[doge]"));
            dataBuider.Add(new EmojiData("[doge互粉]"));
            dataBuider.Add(new EmojiData("[doge原谅ta]"));
            dataBuider.Add(new EmojiData("[doge口罩]"));
            dataBuider.Add(new EmojiData("[doge吃惊]"));
            dataBuider.Add(new EmojiData("[doge吃瓜]"));
            dataBuider.Add(new EmojiData("[doge告辞]"));
            dataBuider.Add(new EmojiData("[doge呵斥]"));
            dataBuider.Add(new EmojiData("[doge并不简单]"));
            dataBuider.Add(new EmojiData("[doge期待]"));
            dataBuider.Add(new EmojiData("[doge汗]"));
            dataBuider.Add(new EmojiData("[doge疑问]"));
            dataBuider.Add(new EmojiData("[doge笑哭]"));
            dataBuider.Add(new EmojiData("[doge装酷]"));
            dataBuider.Add(new EmojiData("[doge酷]"));
            dataBuider.Add(new EmojiData("[doge问号]"));
            dataBuider.Add(new EmojiData("[doge飞吻]"));

            buider.Add(new EmojiTypeHeader("doge", dataBuider.ToImmutable()));
            dataBuider.Clear();

            #endregion doge

            #region w

            dataBuider.Add(new EmojiData("[wpy交易]"));
            dataBuider.Add(new EmojiData("[wv5]"));
            dataBuider.Add(new EmojiData("[ww亲亲]"));
            dataBuider.Add(new EmojiData("[w→_→]"));
            dataBuider.Add(new EmojiData("[w互粉]"));
            dataBuider.Add(new EmojiData("[w偷笑]"));
            dataBuider.Add(new EmojiData("[w傻眼]"));
            dataBuider.Add(new EmojiData("[w兔子]"));
            dataBuider.Add(new EmojiData("[w再见]"));
            dataBuider.Add(new EmojiData("[w压岁钱]"));
            dataBuider.Add(new EmojiData("[w可怜]"));
            dataBuider.Add(new EmojiData("[w可爱]"));
            dataBuider.Add(new EmojiData("[w右哼哼]"));
            dataBuider.Add(new EmojiData("[w吃惊]"));
            dataBuider.Add(new EmojiData("[w吃瓜]"));
            dataBuider.Add(new EmojiData("[w吐]"));
            dataBuider.Add(new EmojiData("[w呵呵]"));
            dataBuider.Add(new EmojiData("[w哆啦a梦吃惊]"));
            dataBuider.Add(new EmojiData("[w哆啦a梦笑]"));
            dataBuider.Add(new EmojiData("[w哆啦a梦色]"));
            dataBuider.Add(new EmojiData("[w哈哈]"));
            dataBuider.Add(new EmojiData("[w哭]"));
            dataBuider.Add(new EmojiData("[w哼]"));
            dataBuider.Add(new EmojiData("[w啤酒鸡腿]"));
            dataBuider.Add(new EmojiData("[w喜]"));
            dataBuider.Add(new EmojiData("[w嘘]"));
            dataBuider.Add(new EmojiData("[w嘻嘻]"));
            dataBuider.Add(new EmojiData("[w嘿嘿嘿]"));
            dataBuider.Add(new EmojiData("[w囧]"));
            dataBuider.Add(new EmojiData("[w困]"));
            dataBuider.Add(new EmojiData("[w太开心]"));
            dataBuider.Add(new EmojiData("[w失望]"));
            dataBuider.Add(new EmojiData("[w奥特曼]"));
            dataBuider.Add(new EmojiData("[w女孩儿]"));
            dataBuider.Add(new EmojiData("[w委屈]"));
            dataBuider.Add(new EmojiData("[w定]"));
            dataBuider.Add(new EmojiData("[w害羞]"));
            dataBuider.Add(new EmojiData("[w小样儿]"));
            dataBuider.Add(new EmojiData("[w左哼哼]"));
            dataBuider.Add(new EmojiData("[w左哼哼哭]"));
            dataBuider.Add(new EmojiData("[w帅]"));
            dataBuider.Add(new EmojiData("[w干杯]"));
            dataBuider.Add(new EmojiData("[w并不简单]"));
            dataBuider.Add(new EmojiData("[w广而告之]"));
            dataBuider.Add(new EmojiData("[w怒~]"));
            dataBuider.Add(new EmojiData("[w怒骂]"));
            dataBuider.Add(new EmojiData("[w思考]"));
            dataBuider.Add(new EmojiData("[w急眼]"));
            dataBuider.Add(new EmojiData("[w悲伤]"));
            dataBuider.Add(new EmojiData("[w感冒]"));
            dataBuider.Add(new EmojiData("[w懒得理你]"));
            dataBuider.Add(new EmojiData("[w我美吗]"));
            dataBuider.Add(new EmojiData("[w打哈欠]"));
            dataBuider.Add(new EmojiData("[w打脸]"));
            dataBuider.Add(new EmojiData("[w抓狂]"));
            dataBuider.Add(new EmojiData("[w拜拜]"));
            dataBuider.Add(new EmojiData("[w挖鼻屎]"));
            dataBuider.Add(new EmojiData("[w捂脸哭]"));
            dataBuider.Add(new EmojiData("[w摊手]"));
            dataBuider.Add(new EmojiData("[w操练]"));
            dataBuider.Add(new EmojiData("[w新浪]"));
            dataBuider.Add(new EmojiData("[w旅行]"));
            dataBuider.Add(new EmojiData("[w晕]"));
            dataBuider.Add(new EmojiData("[w熊猫]"));
            dataBuider.Add(new EmojiData("[w爱你]"));
            dataBuider.Add(new EmojiData("[w猪头]"));
            dataBuider.Add(new EmojiData("[w生病]"));
            dataBuider.Add(new EmojiData("[w男孩儿]"));
            dataBuider.Add(new EmojiData("[w疑问]"));
            dataBuider.Add(new EmojiData("[w睡觉]"));
            dataBuider.Add(new EmojiData("[w神兽]"));
            dataBuider.Add(new EmojiData("[w神马]"));
            dataBuider.Add(new EmojiData("[w笑哭]"));
            dataBuider.Add(new EmojiData("[w累]"));
            dataBuider.Add(new EmojiData("[w织毛衣]"));
            dataBuider.Add(new EmojiData("[w给力]"));
            dataBuider.Add(new EmojiData("[w肥皂]"));
            dataBuider.Add(new EmojiData("[w舔]"));
            dataBuider.Add(new EmojiData("[w花心]"));
            dataBuider.Add(new EmojiData("[w萌]"));
            dataBuider.Add(new EmojiData("[w蛋糕]"));
            dataBuider.Add(new EmojiData("[w调皮]"));
            dataBuider.Add(new EmojiData("[w跪了]"));
            dataBuider.Add(new EmojiData("[w鄙视]"));
            dataBuider.Add(new EmojiData("[w酷]"));
            dataBuider.Add(new EmojiData("[w酷币]"));
            dataBuider.Add(new EmojiData("[w钱]"));
            dataBuider.Add(new EmojiData("[w闭嘴]"));
            dataBuider.Add(new EmojiData("[w阴险]"));
            dataBuider.Add(new EmojiData("[w馋嘴]"));
            dataBuider.Add(new EmojiData("[w黑线]"));
            dataBuider.Add(new EmojiData("[w鼓掌]"));

            buider.Add(new EmojiTypeHeader("w", dataBuider.ToImmutable()));
            dataBuider.Clear();

            #endregion w

            #region 新酷币

            dataBuider.Add(new EmojiData("[新币1分]"));
            dataBuider.Add(new EmojiData("[新酷币1$]"));
            dataBuider.Add(new EmojiData("[新酷币100块]"));
            dataBuider.Add(new EmojiData("[新酷币10块]"));
            dataBuider.Add(new EmojiData("[新酷币1€]"));
            dataBuider.Add(new EmojiData("[新酷币1块]"));
            dataBuider.Add(new EmojiData("[新酷币1毛]"));
            dataBuider.Add(new EmojiData("[新酷币2$]"));
            dataBuider.Add(new EmojiData("[新酷币20块]"));
            dataBuider.Add(new EmojiData("[新酷币2€]"));
            dataBuider.Add(new EmojiData("[新酷币2分]"));
            dataBuider.Add(new EmojiData("[新酷币2块]"));
            dataBuider.Add(new EmojiData("[新酷币2毛]"));
            dataBuider.Add(new EmojiData("[新酷币5$]"));
            dataBuider.Add(new EmojiData("[新酷币50块]"));
            dataBuider.Add(new EmojiData("[新酷币5€]"));
            dataBuider.Add(new EmojiData("[新酷币5分]"));
            dataBuider.Add(new EmojiData("[新酷币5块]"));
            dataBuider.Add(new EmojiData("[新酷币5毛]"));
            dataBuider.Add(new EmojiData("[新酷币]"));
            dataBuider.Add(new EmojiData("[灰色酷币]"));
            dataBuider.Add(new EmojiData("[白纹酷币]"));
            dataBuider.Add(new EmojiData("[绿色酷币]"));

            buider.Add(new EmojiTypeHeader("新酷币", dataBuider.ToImmutable()));
            dataBuider.Clear();

            #endregion 新酷币

            #region 酷币

            dataBuider.Add(new EmojiData("[酷币1$]"));
            dataBuider.Add(new EmojiData("[酷币100块]"));
            dataBuider.Add(new EmojiData("[酷币10块]"));
            dataBuider.Add(new EmojiData("[酷币1]"));
            dataBuider.Add(new EmojiData("[酷币1€]"));
            dataBuider.Add(new EmojiData("[酷币1分]"));
            dataBuider.Add(new EmojiData("[酷币1块]"));
            dataBuider.Add(new EmojiData("[酷币1毛]"));
            dataBuider.Add(new EmojiData("[酷币2$]"));
            dataBuider.Add(new EmojiData("[酷币20块]"));
            dataBuider.Add(new EmojiData("[酷币2]"));
            dataBuider.Add(new EmojiData("[酷币2€]"));
            dataBuider.Add(new EmojiData("[酷币2分]"));
            dataBuider.Add(new EmojiData("[酷币2块]"));
            dataBuider.Add(new EmojiData("[酷币2毛]"));
            dataBuider.Add(new EmojiData("[酷币5$]"));
            dataBuider.Add(new EmojiData("[酷币50块]"));
            dataBuider.Add(new EmojiData("[酷币5]"));
            dataBuider.Add(new EmojiData("[酷币5€]"));
            dataBuider.Add(new EmojiData("[酷币5分]"));
            dataBuider.Add(new EmojiData("[酷币5块]"));
            dataBuider.Add(new EmojiData("[酷币5毛]"));
            dataBuider.Add(new EmojiData("[酷币]"));
            dataBuider.Add(new EmojiData("[酷币空]"));

            buider.Add(new EmojiTypeHeader("酷币", dataBuider.ToImmutable()));
            dataBuider.Clear();

            #endregion 酷币

            #region #(..)

            dataBuider.Add(new EmojiData("#(cos滑稽)"));
            dataBuider.Add(new EmojiData("#(haha)"));
            dataBuider.Add(new EmojiData("#(OK)"));
            dataBuider.Add(new EmojiData("#(sofa)"));
            dataBuider.Add(new EmojiData("#(what)"));
            dataBuider.Add(new EmojiData("#(三道杠)"));
            dataBuider.Add(new EmojiData("#(不高兴)"));
            dataBuider.Add(new EmojiData("#(乖)"));
            dataBuider.Add(new EmojiData("#(传统滑稽)"));
            dataBuider.Add(new EmojiData("#(你懂的)"));
            dataBuider.Add(new EmojiData("#(便便)"));
            dataBuider.Add(new EmojiData("#(冷)"));
            dataBuider.Add(new EmojiData("#(勉强)"));
            dataBuider.Add(new EmojiData("#(受虐滑稽)"));
            dataBuider.Add(new EmojiData("#(吃瓜)"));
            dataBuider.Add(new EmojiData("#(吐)"));
            dataBuider.Add(new EmojiData("#(吐舌)"));
            dataBuider.Add(new EmojiData("#(呀咩爹)"));
            dataBuider.Add(new EmojiData("#(呵呵)"));
            dataBuider.Add(new EmojiData("#(呼~)"));
            dataBuider.Add(new EmojiData("#(咦)"));
            dataBuider.Add(new EmojiData("#(哈哈)"));
            dataBuider.Add(new EmojiData("#(哼)"));
            dataBuider.Add(new EmojiData("#(啊)"));
            dataBuider.Add(new EmojiData("#(喝酒)"));
            dataBuider.Add(new EmojiData("#(喷)"));
            dataBuider.Add(new EmojiData("#(嘿嘿嘿)"));
            dataBuider.Add(new EmojiData("#(噗)"));
            dataBuider.Add(new EmojiData("#(困成狗)"));
            dataBuider.Add(new EmojiData("#(墨镜滑稽)"));
            dataBuider.Add(new EmojiData("#(大拇指)"));
            dataBuider.Add(new EmojiData("#(太开心)"));
            dataBuider.Add(new EmojiData("#(太阳)"));
            dataBuider.Add(new EmojiData("#(委屈)"));
            dataBuider.Add(new EmojiData("#(小乖)"));
            dataBuider.Add(new EmojiData("#(小嘴滑稽)"));
            dataBuider.Add(new EmojiData("#(小红脸)"));
            dataBuider.Add(new EmojiData("#(开心)"));
            dataBuider.Add(new EmojiData("#(弱)"));
            dataBuider.Add(new EmojiData("#(彩虹)"));
            dataBuider.Add(new EmojiData("#(微微一笑)"));
            dataBuider.Add(new EmojiData("#(心碎)"));
            dataBuider.Add(new EmojiData("#(怒)"));
            dataBuider.Add(new EmojiData("#(惊哭)"));
            dataBuider.Add(new EmojiData("#(惊讶)"));
            dataBuider.Add(new EmojiData("#(懒得理)"));
            dataBuider.Add(new EmojiData("#(托腮)"));
            dataBuider.Add(new EmojiData("#(挖鼻)"));
            dataBuider.Add(new EmojiData("#(捂嘴笑)"));
            dataBuider.Add(new EmojiData("#(摊手)"));
            dataBuider.Add(new EmojiData("#(斗鸡眼滑稽)"));
            dataBuider.Add(new EmojiData("#(星星月亮)"));
            dataBuider.Add(new EmojiData("#(暗中观察)"));
            dataBuider.Add(new EmojiData("#(柯基暗中观察)"));
            dataBuider.Add(new EmojiData("#(欢呼)"));
            dataBuider.Add(new EmojiData("#(汗)"));
            dataBuider.Add(new EmojiData("#(泪)"));
            dataBuider.Add(new EmojiData("#(流汗滑稽)"));
            dataBuider.Add(new EmojiData("#(滑稽)"));
            dataBuider.Add(new EmojiData("#(滑稽炸)"));
            dataBuider.Add(new EmojiData("#(灯泡)"));
            dataBuider.Add(new EmojiData("#(爱心)"));
            dataBuider.Add(new EmojiData("#(犀利)"));
            dataBuider.Add(new EmojiData("#(狂汗)"));
            dataBuider.Add(new EmojiData("#(玫瑰)"));
            dataBuider.Add(new EmojiData("#(疑问)"));
            dataBuider.Add(new EmojiData("#(真棒)"));
            dataBuider.Add(new EmojiData("#(睡觉)"));
            dataBuider.Add(new EmojiData("#(礼物)"));
            dataBuider.Add(new EmojiData("#(稽滑)"));
            dataBuider.Add(new EmojiData("#(突然兴奋)"));
            dataBuider.Add(new EmojiData("#(笑尿)"));
            dataBuider.Add(new EmojiData("#(笑眼)"));
            dataBuider.Add(new EmojiData("#(紧张)"));
            dataBuider.Add(new EmojiData("#(红领巾)"));
            dataBuider.Add(new EmojiData("#(纸巾)"));
            dataBuider.Add(new EmojiData("#(胜利)"));
            dataBuider.Add(new EmojiData("#(花心)"));
            dataBuider.Add(new EmojiData("#(茶杯)"));
            dataBuider.Add(new EmojiData("#(药丸)"));
            dataBuider.Add(new EmojiData("#(蛋糕)"));
            dataBuider.Add(new EmojiData("#(蜡烛)"));
            dataBuider.Add(new EmojiData("#(鄙视)"));
            dataBuider.Add(new EmojiData("#(酷)"));
            dataBuider.Add(new EmojiData("#(酸爽)"));
            dataBuider.Add(new EmojiData("#(钱)"));
            dataBuider.Add(new EmojiData("#(钱币)"));
            dataBuider.Add(new EmojiData("#(阴险)"));
            dataBuider.Add(new EmojiData("#(音乐)"));
            dataBuider.Add(new EmojiData("#(香蕉)"));
            dataBuider.Add(new EmojiData("#(黑头瞪眼)"));
            dataBuider.Add(new EmojiData("#(黑头高兴)"));
            dataBuider.Add(new EmojiData("#(黑线)"));

            buider.Add(new EmojiTypeHeader("旧表情", dataBuider.ToImmutable()));

            #endregion #(..)

            TypeHeaders = buider.ToImmutable();
        }
    }
}