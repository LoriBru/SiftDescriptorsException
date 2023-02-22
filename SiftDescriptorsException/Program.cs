using Emgu.CV.Structure;
using Emgu.CV;
using System;
using SiftDescriptorsException;

var i = 0;
while (i < 1000)
{
    var image = new Image<Gray, byte>("CvFov.tiff");

    // Compute Sift descriptors
    (var kp, var des) = SiftComputer.ComputeSiftDescriptors(image);
    Console.WriteLine($"i: {i}, kp: {kp.Length}, des: {des.Total}");
    i++;
}

