using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiftDescriptorsException
{
    internal class SiftComputer
    {
        internal static (VectorOfKeyPoint kp, Mat des) ComputeSiftDescriptors(Image<Gray, byte> imageCV)
        {
            var featureDetector = new Emgu.CV.Features2D.SIFT();

            // Extract features from the reference image
            var kp = new VectorOfKeyPoint();
            var des = new Mat();
            featureDetector.DetectAndCompute(imageCV, null, kp, des, false);
            return (kp, des);
        }
    }
}
