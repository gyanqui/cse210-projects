using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Living in the Heart of Peru: Exploring Ancient Ruins", "Juan Perez Garcia", 480);

        Comment video1Comment1 = new Comment("Luisa", "This video is truly inspiring! I love how you explore the ancient ruins and share their history.");
        Comment video1Comment2 = new Comment("Carlos", "Your content always surprises me. I'm glad you're showcasing the beauty of our country.");
        Comment video1Comment3 = new Comment("Maria", "Wonderful! I would love to visit those places someday.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Hidden Gems of Peru: Uncovering Mysteries in the Andes", "Jhon Mercedes Palomino", 975);

        Comment video2Comment1 = new Comment("Diego", "What an incredible adventure! I love how you showcase the mysteries of the Andes and invite us to discover more about our history.");
        Comment video2Comment2 = new Comment("Valeria", "Your videos always transport me to new places. Thank you for sharing these hidden gems.");
        Comment video2Comment3 = new Comment("Camila", "The views are simply breathtaking. I'm proud to be Peruvian.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Peruvian Cuisine: A Gastronomic Adventure", "Miriam Velasquez Soto", 650);

        Comment video3Comment1 = new Comment("Gabriel", "My mouth was watering while watching this video! Our cuisine is truly unique and delicious.");
        Comment video3Comment2 = new Comment("Renata", "I love how you present our traditional dishes. I definitely need to try them all.");
        Comment video3Comment3 = new Comment("Fernando", "Peruvian food is famous worldwide, and your videos perfectly capture its essence.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
