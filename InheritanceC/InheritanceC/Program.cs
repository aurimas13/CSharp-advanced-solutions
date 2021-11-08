// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Aurimas Nausedas");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Aurimas Nausedas",
                "https://images.com/shoes", true);

            VideoPost videoPost1 = new VideoPost("FailVideo", "Aurimas Nausedas",
                "https://video.com/failvideo", true, 10);

            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
        }

    }
}
