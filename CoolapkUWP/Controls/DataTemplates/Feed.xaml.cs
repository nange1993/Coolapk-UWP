﻿using CoolapkUWP.Helpers;
using CoolapkUWP.Models;
using Newtonsoft.Json.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace CoolapkUWP.Controls.DataTemplates
{
    public partial class Feed : ResourceDictionary
    {
        public Feed() => InitializeComponent();

        private void OnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (e != null && !UIHelper.IsOriginSource(sender, e.OriginalSource)) { return; }

            UIHelper.OpenLinkAsync((sender as FrameworkElement).Tag as string);
        }

        private async void FeedButton_Click(object sender, RoutedEventArgs e)
        {
            void ChangeLikeStatus(ILike f, FrameworkElement button, bool isLike)
            {
                f.Liked = isLike;
                if (button.FindName("like1") is SymbolIcon symbolIcon1)
                {
                    symbolIcon1.Visibility = isLike ? Visibility.Visible : Visibility.Collapsed;
                }

                if (button.FindName("like2") is SymbolIcon symbolIcon2)
                {
                    symbolIcon2.Visibility = isLike ? Visibility.Collapsed : Visibility.Visible;
                }
            }

            FrameworkElement element = sender as FrameworkElement;
            switch (element.Name)
            {
                case "makeReplyButton":
                    var item = Microsoft.Toolkit.Uwp.UI.Extensions.VisualTree.FindAscendant<ListViewItem>(element);
                    var ctrl = item.FindName("makeFeed") as MakeFeedControl;
                    ctrl.Visibility = ctrl.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                    break;

                case "likeButton":
                    var f = element.Tag as ILike;
                    bool isReply = f is FeedReplyModel;
                    bool b = false;
                    JObject o;
                    if (f.Liked)
                    {
                        o = (JObject)await DataHelper.GetDataAsync(DataUriType.OperateUnlike, isReply ? "Reply" : string.Empty, f.Id);
                    }
                    else
                    {
                        o = (JObject)await DataHelper.GetDataAsync(DataUriType.OperateLike, isReply ? "Reply" : string.Empty, f.Id);
                        b = true;
                    }

                    if (isReply)
                    {
                        f.Likenum = o.ToString().Replace("\"", string.Empty);
                    }
                    else if (o != null)
                    {
                        f.Likenum = o.Value<int>("count").ToString();
                    }

                    ChangeLikeStatus(f, element, b);
                    break;
                default:
                    UIHelper.OpenLinkAsync((sender as FrameworkElement).Tag as string);
                    break;
            }
        }

        private void ListViewItem_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (UIHelper.IsOriginSource(sender, e.OriginalSource))
            {
                if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.Space)
                {
                    OnTapped(sender, null);
                }
            }
        }

        private void makeFeed_MakedFeedSuccessful(object sender, System.EventArgs e)
        {
            if (((FrameworkElement)sender).Tag is ICanChangeReplyNum m)
            {
                m.Replynum = (int.Parse(m.Replynum) + 1).ToString();
            }
        }
    }
}