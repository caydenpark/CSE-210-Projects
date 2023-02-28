using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Book
    {  
        private Random _random = new Random();
        private List<string> _scriptures = new List<string>();
        private string _selectedScripture = "";

        public Book()
        {
            AddScriptures();
        }

        private void AddScriptures()
        {
            _scriptures.Add("2 Nephi 28:30 | For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have.");
            _scriptures.Add("2 Nephi 32:3 | Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.");
            _scriptures.Add("2 Nephi 32:8-9 | 8 And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray.\n9 But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul.");
            _scriptures.Add("Mosiah 4:9 | Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend.");
            _scriptures.Add("Ether 12:6 | And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.");
            _scriptures.Add("Helaman 5:12 | And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        }

        public void ChooseScripture()
        {
            _selectedScripture = 
                _scriptures[_random.Next(0, (_scriptures.Count))];
        }
        
        public string GetScripture()
        {
            return _selectedScripture;
        }

        public void InputNewScripture()
        {
            Console.WriteLine("What is your reference? ");

            string input = Console.ReadLine();
            _selectedScripture += input + " | ";

            Console.WriteLine("Submit the first verse: ");
            input = Console.ReadLine();

            _selectedScripture += input;

            Console.WriteLine("Are there any more verses? ");
            input = Console.ReadLine();

            while (input != "no")
            {
                Console.WriteLine("Submit the next verse: ");
                input = Console.ReadLine();
                _selectedScripture += "\n" + input;

                Console.WriteLine("Are there any more verses? ");
                input = Console.ReadLine();
            }

        }
    }
}