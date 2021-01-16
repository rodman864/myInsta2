using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> myInsta = new List<User>();

            User UserName = new User();
            User TotalViews = new User();
            User Likes = new User();
            User Comments = new User();

            myInsta.Add(UserName);
            myInsta.Add(TotalViews);
            myInsta.Add(Likes);
            myInsta.Add(Comments);

            List<myComments> myComments = new List<myComments>();


            myComments comment1 = new myComments();
            comment1.Comment = "I Love You!";

            myComments comment2 = new myComments();
            comment2.Comment = "Stay Home Order!";

            myComments comment3 = new myComments();
            comment3.Comment = "We are Happy!";

            myComments.Add(comment1);
            myComments.Add(comment2);
            myComments.Add(comment3);

           

            Console.WriteLine("My favorite Comments is:" + myComments.First());

        }
    }
}
public class User
{
    public string UserName { get; set; } = string.Empty;
    public string Comments { get; internal set; }
}
public class MyViews
{
    public string TotalViews { get; set; }
}
public class MyLikes
{
    public string Likes { get; set; }
}
public class myComments
{
  
    public string Comment { get; set; }

}

