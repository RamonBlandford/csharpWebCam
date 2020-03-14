using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ZXing;

namespace Demo
{
    class Recognizer
    {
        private ZXing.BarcodeReader _reader;

        public Recognizer()
        {
            _reader = new BarcodeReader();
        }

        public Result Decode(Bitmap image)
        {
            try
            {
                var result = _reader.Decode(image);
                return result;
            }
            catch (Exception ex)
            {
                return null;

            }
        }
    }
}
