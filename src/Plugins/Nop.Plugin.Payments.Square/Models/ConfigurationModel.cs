﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Plugin.Payments.Square.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        #region Ctor

        public ConfigurationModel()
        {
            Locations = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [NopResourceDisplayName("Plugins.Payments.Square.Fields.ApplicationId")]
        public string ApplicationId { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Square.Fields.ApplicationSecret")]
        [DataType(DataType.Password)]
        [NoTrim]
        public string ApplicationSecret { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Square.Fields.AccessToken")]
        [DataType(DataType.Password)]
        [NoTrim]
        public string AccessToken { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Square.Fields.TransactionMode")]
        public int TransactionModeId { get; set; }
        public SelectList TransactionModes { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Square.Fields.Location")]
        public string LocationId { get; set; }
        public IList<SelectListItem> Locations { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Square.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Square.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }

        #endregion
    }
}