using ImagePanZoomRotateFilter.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ImagePanZoomRotateFilter.Models.ImageLoaders
{
    public class PngLoader : IImageLoader
    {

        public byte[] data { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }

        public async Task<int> Load(Stream imageStream)
        {
            await Task.Delay(100);
            return 12;
           
        }
    }
}
