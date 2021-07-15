﻿using System.ComponentModel.DataAnnotations;
using CookieDropBlock.Attributes;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CookieDropBlock.Models
{
    [ContentType(
        DisplayName = "Cookie Drop Block",
        GUID = "21957414-ab47-4788-b043-9dbe13b7eeb4",
        Description = "Used to drop a cookie on a page")]
    [Icon]
    public class CookieDropBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Cookie Name",
            Description = "The name of the cookie to drop on the page",
            GroupName = "Cookie Information",
            Order = 10)]
        public virtual string CookieName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Cookie Value",
            Description = "The value to set for the cookie",
            GroupName = "Cookie Information",
            Order = 20)]
        public virtual string CookieValue { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Hide edit mode message",
            Description = "If checked will hide the yellow message shown in on page edit mode",
            GroupName = "Cookie Information",
            Order = 20)]
        public virtual bool HideEditModeMessage { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            HideEditModeMessage = false;
        }
    }
}