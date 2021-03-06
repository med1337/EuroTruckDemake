﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobMessages
{
    public static string[] pickup_message_prefixes =
    {
        "Oi, I need you to take this trailer full of ",
        "Could you take this trailer of ",
        "Take this trailer containing ",
        "Bring this trailer of ",
        "Hey, the last guy didn't make it. Can you take this trailer of ",
        "'Bout time you showed up. I need you to take this trailer of ",
        "This might be an odd request, but could you bring this trailer full of ",
        "This might be dangerous, but could you take this trailer of ",
        "Ah, you're here. Could you take this half-full trailer of ",
        "Wonderful, could you take this trailer full of ",
        "Are you the new driver? I need you to deliver this trailer of ",
        "Good morning! Or is it afternoon? Anyway, take this trailer containing ",
        "What a wonderful day for a drive! Could you bring this trailer of "
    };

    public static string[] cargo_types =
    {
        "Unattended Luggage",
        "Dogs",
        "Mysterious Boxes",
        "Coolaid",
        "Broken VR Headsets",
        "Strange Meat",
        "NES Controllers",
        "Bottlecaps",
        "E.T. Cartridges",
        "Fancy Chairs",
        "85\" Touch-Screen TVs",
        "Glitter Paint",
        "Christmas Crackers",
        "Fireworks",
        "Lightsabers",
        "Odds and Ends",
        "Loo Rolls",
        "Red Hair Dye",
        "Bowling Balls",
        "Bananas",
        "Odd Socks",
        "Soap",
        "CD Keys",
        "Lost USB Sticks",
        "Nose Clippers",
        "Wonka Bars",
        "Coconut Shells",
        "Meal Deals",
        "Sour Wine Gums",
        "Cocktail Umbrellas",
        "Economy Plungers",
        "Massage Coupons",
        "Baguettes",
        "Football Hoodies",
        "Oversized Pencils",
        "Used Underwear",
        "Beach Balls",
        "Cupcakes",
        "Broken Clocks",
        "Marbles",
        "Balloons",
        "Top Hats",
        "Pickles",
        "Early Access Titles",
        "Fluffy Kittens",
        "Hopes and Dreams",
        "Unicorn Tears",
        "Magic Beans",
        "Power Gloves",
        "Wet Concrete"
    };

    public static string[] pickup_message_suffixes =
    {
        " to the Depot. We need it ASAP.",
        " to the Depot as quickly as possible, I don't mind if it gets banged about a bit.",
        " to the Depot. I need it for ... reasons.",
        " to the Depot. There's a swarm of people here asking for it!",
        " to the Depot, and be discrete about it, if you could.",
        " to the Depot as safely as possible, I need it in tip top condition.",
        " to the Depot by yesterday.",
        " to the Depot. I'd do it myself, but I'm babysitting.",
        " to my house, no wait.. the Depot. I meant the Depot.",
        " to the Depot. Now get out of here, I'm busy playing SlotDrop.",
        " to the Secret Depot. You know the place, right?",
        " to the usual place. It's right by the uh... cargo containers? I forget.",
        " to the spot where we put stuff. I'm sure it's got a name..",
        " to the Depot as soon as you can, I'm starving!",
        " to the Depot. I need to give my niece something for her birthday.",
        " to the beach. On second thought, it might be safer to take it to the Depot."
    };

    public static string[] delivery_messages =
    {
        "Grand! Thanks for this, it will come in real handy.",
        "Appreciate the drop-off. A bit late, but I'll handle the paperwork.",
        "This isn't what I ordered at all! Oh well, I'm sure I'll find a use for it. Thanks anyway.",
        "A speedy delivery by today's standards. Good job.",
        "Who are you? Oh, hey. Thanks for the goods. Keep up the good work!",
        "What time do you call this? It was supposed to be here three weeks ago? Oh well thanks anyway.",
        "Well well well, look who it is... Late as usual. Just leave it there.",
        "Thanks for the delivery. I'll be out in a minute. Or two... Don't wait for me.",
        "Awesome. Thanks for that. I'm surprised you managed to get here, what with the radiation and all.",
        "Fantastic! I can't wait to show this to the kids.",
        "9.. 8.. 7.. 6.. Ah, there you are! You didn't have long left. Thanks for the delivery.",
        "Hmm.. I probably shouldn't give you full payment for this, but I will, because I'm nice."
    };

    public static string[] job_fail_messages =
    {
        "You wrecked the cargo! Damn, that's not going to go down well with my investors.",
        "How did you manage that?! Oh well, I don't think anyone needed it anyway.",
        "You flipped the trailer.. Can't say I'm surprised.",
        "I thought I told you to deliver the trailer, not tip it!",
        "Uhh, just pretend no one saw that. Drive away, quick!",
        "Oh boy I can't wait for this trailer to arrive... Oh.. you flipped it. Nevermind.",
        "That was some expensive cargo! Darn. Insurance should cover it, I hope."
    };

}
