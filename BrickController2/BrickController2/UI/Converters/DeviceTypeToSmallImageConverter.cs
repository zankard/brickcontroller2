﻿using BrickController2.DeviceManagement;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace BrickController2.UI.Converters
{
    public class DeviceTypeToSmallImageConverter : IValueConverter
    {
        private const string ImagesNamespacePrefix = "BrickController2.UI.Images.";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var deviceType = (DeviceType)value;
            switch (deviceType)
            {
                case DeviceType.BuWizz:
                case DeviceType.BuWizz2:
                   return ImageSource.FromResource($"{ImagesNamespacePrefix}buwizz_image_small.png");

                case DeviceType.SBrick:
                    return ImageSource.FromResource($"{ImagesNamespacePrefix}sbrick_image_small.png");

                case DeviceType.Infrared:
                    return ImageSource.FromResource($"{ImagesNamespacePrefix}infra_image_small.png");

                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
