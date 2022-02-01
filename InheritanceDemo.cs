using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the gifts", true, "Marcus Canty");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Got new truck", "Marcus Canty",
                "https://autotrader.com", true);


            VideoPost videoPost1 = new VideoPost("Hawaii vacation", 
                "Marcus Canty", "https://youtube.com", true, 10);



            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Post
    {
        private static int currentPostId;

        //properties give you more info about the Post object 
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class doesn't invoke a
        //base class constructor explicitly the default constructor
        //is called implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Marcus Canty";
        }

        //Instance constructor that has 3 parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }
        
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method override of the ToString method that is inherited
        //from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //ImagePost derives from Post and adds a property (ImageURL) and two constructors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }
        // this default constructor is called if the arguments are empty 
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            //Property ImageUrl is a member of ImagePost, but not Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //Video derives from Post, adds a property and two constructors
    class VideoPost : Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;
        
        //Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        
        public VideoPost() { }

        public VideoPost(string title, string sendByUser, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUser;  
            this.IsPublic = isPublic;

            //Property VideoUrl is a member of VideoPost, but not of Post
            this.VideoURL = videoURL;
            this.Length = length;
        }
        
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
            Console.WriteLine("Playing");
            timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }

        private void TimerCallback(Object o)
        {
            if(currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
            Console.WriteLine("Stopped at {0} seconds", currentDuration);
            currentDuration = 0;
            timer.Dispose();
            }

        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} minutes - by {this.SendByUsername}");
        }

    }
}
