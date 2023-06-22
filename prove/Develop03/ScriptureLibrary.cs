using System;
using System.Collections.Generic;
using System.Linq;

class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private Random random;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
        random = new Random();
        InitializeLibrary();
    }

    private void InitializeLibrary()
    {
        // First stab at a Library.
        scriptures.Add(new Scripture(new Reference("1 Nephi 3:7"), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        scriptures.Add(new Scripture(new Reference("Alma 41:10"), "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness."));
        scriptures.Add(new Scripture(new Reference("2 Nepji 32:8-9"),"And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray. But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul."));

    }

    public bool AllScripturesHidden => scriptures.All(scripture => scripture.AllWordsHidden);

    public Scripture GetRandomScripture()
    {
        List<Scripture> availableScriptures = scriptures.Where(scriptures => !scriptures.AllWordsHidden).ToList();
        int count = availableScriptures.Count;

        if (count == 0)
        {
            return null;
        }
    
        int randomIndex = random.Next(count);
        return availableScriptures[randomIndex];
    }
}