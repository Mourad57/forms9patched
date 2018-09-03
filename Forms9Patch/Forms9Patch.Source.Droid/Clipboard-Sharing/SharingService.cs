using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using Android.Webkit;
using Android.Database;
using Android.Net;
using System.Collections.Generic;
using Java.Lang.Reflect;
using System.Runtime.InteropServices;
using Java.Nio.FileNio;
using System.Collections;
using System.IO;
using System.Linq;
using Android.OS;
using System.Reflection;
using Android.Content.Res;
using Android.Content.PM;
using Java.IO;
using P42.Utils;

[assembly: Dependency(typeof(Forms9Patch.Droid.SharingService))]
namespace Forms9Patch.Droid
{
    public class SharingService : Forms9Patch.ISharingService
    {
        public void Share(Forms9Patch.MimeItemCollection mimeItemCollection, VisualElement target)
        {
            var uris = mimeItemCollection.AsContentUris();
            if (uris.Count > 0)
            {
                Intent intent = new Intent();
                if (uris.Count == 1)
                {
                    intent.SetAction(Intent.ActionSend);
                    intent.PutExtra(Intent.ExtraStream, uris[0]);
                    intent.SetType(ClipboardContentProvider.UriItems[uris[0]].MimeType);
                }
                else
                {
                    intent.SetAction(Intent.ActionSendMultiple);
                    intent.PutParcelableArrayListExtra(Intent.ExtraStream, uris.ToArray());
                    intent.SetType(mimeItemCollection.LowestCommonMimeType());
                }

                string html = null;
                string text = null;
                foreach (var item in ClipboardContentProvider.UriItems)
                {
                    if (html == null && item.Value.MimeType == "text/html")
                    {
                        html = (string)item.Value.Value;
                        break;
                    }
                    if (text == null && item.Value.MimeType == "text/plain")
                        text = (string)item.Value.Value;
                }
                if (text != null)
                {
                    intent.PutExtra(Intent.ExtraText, text);
                    if (html != null)
                        intent.PutExtra(Intent.ExtraHtmlText, html);
                }

                Forms9Patch.Droid.Settings.Activity.StartActivity(Intent.CreateChooser(intent, "Share ..."));
            }
        }
    }
}