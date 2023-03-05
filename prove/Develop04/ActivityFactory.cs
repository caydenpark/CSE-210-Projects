using System;

public class ActivityFactory
{
    public Activity CreateActivity(string activityNumber)
        {
            Activity activity = new Activity("");

            if (activityNumber == "1")
                activity = new Breather();
            else if(activityNumber == "2")
                activity = new Reflection();
            else if(activityNumber == "3")
                activity = new Listing();
            return activity;
        }
}