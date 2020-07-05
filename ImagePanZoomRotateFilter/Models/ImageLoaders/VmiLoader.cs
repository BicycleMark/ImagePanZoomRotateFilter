using ImagePanZoomRotateFilter.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ImagePanZoomRotateFilter.Models.ImageLoaders
{
    public class VmiLoader : IImageLoader
    {
        public VmiLoader()
        {
        }

        public VMIHeader VMIHeader {get; }
        public byte[] data { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }

        public async Task<int> Load(Stream imageStream)
        {
            throw new NotImplementedException();
        }

       
    }
}
