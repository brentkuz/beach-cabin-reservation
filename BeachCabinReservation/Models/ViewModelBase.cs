﻿using BeachCabinReservation.Utility.CustomAttributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BeachCabinReservation.Models
{
    public class ViewModelBase
    {
        protected UrlConstants urls = new UrlConstants();
        public virtual string GetClientConfig()
        {
            var dict = new Dictionary<string, string>();
            var props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                if (Attribute.IsDefined(p, typeof(ClientConfigurationAttribute)))
                    dict.Add(p.Name, p.GetValue(this)?.ToString());
            }

            return JsonConvert.SerializeObject(dict);
        }
        public virtual string GetUrls()
        {
            return JsonConvert.SerializeObject(urls);
        }
    }
}
