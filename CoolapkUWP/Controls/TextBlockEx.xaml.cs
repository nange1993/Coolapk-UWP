﻿using CoolapkUWP.Helpers;
using CoolapkUWP.Helpers.ValueConverters;
using CoolapkUWP.Models;
using System.Collections.Immutable;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace CoolapkUWP.Controls
{
    /// <summary> 用于显示带表情和超链接的控件。使用MessageText指定要显示的内容。 </summary>
    public sealed partial class TextBlockEx : UserControl
    {
        private string _messageText;
        public string MessageText
        {
            get => _messageText;
            set
            {
                var str = value.Replace("<!--break-->", string.Empty, System.StringComparison.OrdinalIgnoreCase);
                if (str != _messageText)
                {
                    _messageText = str;
                    GetTextBlock();
                }
            }
        }

        public int MaxLine { get; set; }

        public TextBlockEx() => this.InitializeComponent();

        private async void GetTextBlock()
        {
            var richTextBlock = new RichTextBlock
            {
                TextWrapping = TextWrapping.Wrap,
                IsTextSelectionEnabled = false,
            };
            if (MaxLine > 0)
            {
                richTextBlock.MaxLines = MaxLine;
                richTextBlock.TextTrimming = TextTrimming.WordEllipsis;
            }
            var paragraph = new Paragraph();

            void AddEmoji(string name, bool useOldEmoji = false)
            {
                InlineUIContainer container = new InlineUIContainer();
                Image image = new Image
                {
                    Height = Width = 20,
                    Source = new BitmapImage(EmojiHelper.Get(name, useOldEmoji))
                };
                ToolTipService.SetToolTip(image, new ToolTip { Content = name });
                container.Child = image;
                paragraph.Inlines.Add(container);
            }
            void NewLine()
            {
                richTextBlock.Blocks.Add(paragraph);
                paragraph = new Paragraph();
            }
            void AddText(string item) => paragraph.Inlines.Add(new Run { Text = item.Replace("&amp;", "&").Replace("&quot;", "\"") });

            var imageArrayBuider = ImmutableArray.CreateBuilder<ImageModel>();
            var list = await GetStringList(_messageText);
            foreach (var item in list)
            {
                if (string.IsNullOrEmpty(item)) { NewLine(); }
                else
                {
                    switch (item[0])
                    {
                        case '<':
                            string content = item.Substring(item.IndexOf('>') + 1, item.LastIndexOf('<') - item.IndexOf('>') - 1);
                            string href = string.Empty;
                            var hrefRegex = new Regex("href=\"(\\S|\\s)+?\"");
                            if (hrefRegex.IsMatch(item))
                            {
                                var match = hrefRegex.Match(item);
                                href = match.Value.Substring(match.Value.IndexOf('"') + 1, match.Value.LastIndexOf('"') - match.Value.IndexOf('"') - 1);
                            }

                            if (item.Contains("t=\"image\"", System.StringComparison.Ordinal))
                            {
                                NewLine();

                                var imageModel = new ImageModel(href, ImageType.SmallImage);
                                imageArrayBuider.Add(imageModel);

                                InlineUIContainer container = new InlineUIContainer();
                                Image image = new Image
                                {
                                    MaxHeight = MaxWidth = 400,
                                    MinHeight = MinWidth = 56,
                                    Stretch = Stretch.Uniform
                                };
                                image.SetBinding(Image.SourceProperty, new Binding
                                {
                                    Source = imageModel,
                                    Path = new PropertyPath(nameof(imageModel.Pic)),
                                    Mode = BindingMode.OneWay
                                });

                                if (!string.IsNullOrEmpty(content))
                                    ToolTipService.SetToolTip(image, new ToolTip { Content = content });
                                image.Tapped += (sender, e) => UIHelper.ShowImage(imageModel);

                                Grid grid = new Grid();
                                if (imageModel.IsGif)
                                {
                                    StackPanel panel = new StackPanel
                                    {
                                        Orientation = Orientation.Horizontal,
                                        VerticalAlignment = VerticalAlignment.Top,
                                        HorizontalAlignment = HorizontalAlignment.Right,
                                        Margin = new Thickness(4)
                                    };
                                    Border border1 = new Border
                                    {
                                        Child = new TextBlock { Text = "GIF" },
                                        Background = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0))
                                    };

                                    Border border2 = new Border
                                    {
                                        Child = new TextBlock { Text = "长图" },
                                        Background = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0))
                                    };
                                    border2.SetBinding(VisibilityProperty, new Binding
                                    {
                                        Source = imageModel,
                                        Path = new PropertyPath(nameof(imageModel.IsLongPic)),
                                        Mode = BindingMode.OneWay,
                                        Converter = new BoolToVisibilityConverter()
                                    });

                                    panel.Children.Add(border1);
                                    grid.Children.Add(image);
                                    grid.Children.Add(panel);
                                }
                                else
                                {
                                    Border border = new Border
                                    {
                                        Child = new TextBlock { Text = "长图" },
                                        Background = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0))
                                    };
                                    border.SetBinding(VisibilityProperty, new Binding
                                    {
                                        Source = imageModel,
                                        Path = new PropertyPath(nameof(imageModel.IsLongPic)),
                                        Mode = BindingMode.OneWay,
                                        Converter = new BoolToVisibilityConverter()
                                    });

                                    grid.Children.Add(image);
                                    grid.Children.Add(border);
                                }
                                container.Child = grid;
                                Paragraph paragraph1 = new Paragraph { TextAlignment = TextAlignment.Center };
                                paragraph1.Inlines.Add(container);
                                richTextBlock.Blocks.Add(paragraph1);

                                Paragraph paragraph2 = new Paragraph
                                {
                                    TextAlignment = TextAlignment.Center,
                                    Foreground = Windows.UI.Xaml.Application.Current.Resources["GrayText"] as SolidColorBrush
                                };
                                Run run = new Run { Text = content.Replace("&amp;", "&").Replace("<br/>", "\n") };
                                paragraph2.Inlines.Add(run);
                                richTextBlock.Blocks.Add(paragraph2);
                            }
                            else
                            {
                                Hyperlink hyperlink = new Hyperlink { UnderlineStyle = UnderlineStyle.None };
                                if (!string.IsNullOrEmpty(href))
                                {
                                    ToolTipService.SetToolTip(hyperlink, new ToolTip { Content = href });
                                }

                                if (content.IndexOf('@') != 0 && content.IndexOf('#') != 0 && !item.Contains("type=\"user-detail\""))
                                {
                                    Run run2 = new Run { Text = "", FontFamily = new FontFamily("Segoe MDL2 Assets") }; //U+E167
                                    hyperlink.Inlines.Add(run2);
                                }
                                else if (content == "查看图片" && (href.IndexOf("http://image.coolapk.com") == 0 || href.IndexOf("https://image.coolapk.com") == 0))
                                {
                                    Run run2 = new Run { Text = "", FontFamily = new FontFamily("Segoe MDL2 Assets") }; //U+E158
                                    hyperlink.Inlines.Add(run2);
                                }
                                Run run = new Run { Text = content.Replace("&amp;", "&") };
                                hyperlink.Inlines.Add(run);
                                hyperlink.Click += (sender, e) =>
                                {
                                    if (content == "查看图片" && (href.IndexOf("http://image.coolapk.com") == 0 || href.IndexOf("https://image.coolapk.com") == 0))
                                    {
                                        UIHelper.ShowImage(href, ImageType.SmallImage);
                                    }
                                    else
                                    {
                                        UIHelper.OpenLinkAsync(href);
                                    }
                                };

                                paragraph.Inlines.Add(hyperlink);
                            }
                            break;

                        case '#':
                            string s = item.Substring(1, item.Length - 2);
                            if (EmojiHelper.Contains(s)) { AddEmoji(s); }
                            else { AddText(item); }
                            break;

                        case '[':
                            if (EmojiHelper.Contains(item))
                            {
                                var useOld = SettingsHelper.Get<bool>(SettingsHelper.IsUseOldEmojiMode) && EmojiHelper.Contains(item, true);
                                AddEmoji(item, useOld);
                            }
                            else { AddText(item); }
                            break;

                        default: AddText(item); break;
                    }
                }
            }

            var array = imageArrayBuider.ToImmutable();
            foreach (var item in array)
            {
                item.ContextArray = array;
            }

            richTextBlock.Blocks.Add(paragraph);
            richTextBlock.Height = richTextBlock.Width = Height = Width = double.NaN;
            richTextBlock.MaxHeight = richTextBlock.MaxWidth = MaxHeight = MaxWidth = double.PositiveInfinity;
            Content = richTextBlock;
        }

        private Task<ImmutableArray<string>> GetStringList(string text)
        {
            return Task.Run(() =>
            {
                Regex linkRegex = new Regex("<a(\\S|\\s)*?>(\\S|\\s)*?</a>"), emojiRegex1 = new Regex(@"\[\S*?\]"), emojiRegex2 = new Regex(@"#\(\S*?\)");
                var buider = ImmutableArray.CreateBuilder<string>();

                //处理超链接或图文中的图片
                for (int i = 0; i < text.Length;)
                {
                    var matchedValue = linkRegex.Match(text, i);
                    int index = (string.IsNullOrEmpty(matchedValue.Value) ? text.Length : text.IndexOf(matchedValue.Value, i)) - i;
                    if (index == 0)
                    {
                        buider.Add(matchedValue.Value.Replace("\n", "<br/>"));
                        i += matchedValue.Length;
                    }
                    else if (index > 0)
                    {
                        buider.Add(text.Substring(i, index));
                        i += index;
                    }
                }

                //处理[..]样式的表情
                for (int j = 0; j < buider.Count; j++)
                {
                    for (int i = 0; i < buider[j].Length;)
                    {
                        var v = emojiRegex1.Match(buider[j], i);
                        int a = string.IsNullOrEmpty(v.Value) ? -1 : buider[j].IndexOf(v.Value, i) - i;
                        if (a == 0)
                        {
                            if (EmojiHelper.Contains(buider[j].Substring(0, v.Length)) && (emojiRegex1.IsMatch(buider[j], i + v.Length) || buider[j].Length > v.Length))
                            {
                                buider.Insert(j + 1, buider[j].Substring(v.Length));
                                buider[j] = buider[j].Substring(0, v.Length);
                            }
                            i += v.Length;
                        }
                        else if (a > 0)
                        {
                            if (EmojiHelper.Contains(buider[j].Substring(a, v.Length)))
                            {
                                buider.Insert(j + 1, buider[j].Substring(a));
                                buider[j] = buider[j].Substring(0, a);
                            }
                            i += a;
                        }
                        else if (a == -1) break;
                    }
                }

                //处理#(..)样式的表情
                for (int j = 0; j < buider.Count; j++)
                {
                    for (int i = 0; i < buider[j].Length;)
                    {
                        var v = emojiRegex2.Match(buider[j], i);
                        int a = string.IsNullOrEmpty(v.Value) ? -1 : buider[j].IndexOf(v.Value, i) - i;
                        if (a == 0)
                        {
                            if (EmojiHelper.Contains(buider[j].Substring(1, v.Length - 2)) && emojiRegex2.IsMatch(buider[j], i + v.Length) || buider[j].Length > v.Length)
                            {
                                buider.Insert(j + 1, buider[j].Substring(v.Length));
                                buider[j] = buider[j].Substring(0, v.Length);
                            }
                            i += v.Length;
                        }
                        else if (a > 0)
                        {
                            if (EmojiHelper.Contains(buider[j].Substring(a + 1, v.Length - 2)))
                            {
                                buider.Insert(j + 1, buider[j].Substring(a));
                                buider[j] = buider[j].Substring(0, a);
                            }
                            i += a;
                        }
                        else if (a == -1) break;
                    }
                }

                ////处理 \n
                for (int j = 0; j < buider.Count; j++)
                {
                    for (int i = 0; i < buider[j].Length;)
                    {
                        int a = buider[j].IndexOf("\n", i) == -1 ? -1 : buider[j].IndexOf("\n", i) - i;
                        if (a == 0)
                        {
                            if (!linkRegex.IsMatch(buider[j]) && buider[j].Length > 1)
                            {
                                buider.Insert(j + 1, buider[j].Substring(1));
                                buider[j] = string.Empty;
                            }
                            i += 1;
                        }
                        else if (a > 0)
                        {
                            if (!linkRegex.IsMatch(buider[j]))
                            {
                                buider.Insert(j + 1, buider[j].Substring(a));
                                buider[j] = buider[j].Substring(0, a);
                            }
                            i += a;
                        }
                        else if (a == -1) break;
                    }
                }

                return buider.ToImmutableArray();
            });
        }
    }
}