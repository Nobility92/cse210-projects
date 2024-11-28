
public class Library
{
    private List<Scripture> _scriptures;
    public Random _random = new Random();

    public Library()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son that whosoever believeth in Him should not perish but have eternal life."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),
            new Scripture(new Reference("Isaiah", 41, 10), "Fear thou not; for I am with thee: be not dismayed; for I am thy God."),
            new Scripture(new Reference("Matthew", 5, 16), "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Isaiah", 40, 30, 31), "Even the youths shall faint and be weary, and the young men shall utterly fall. But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."),
            new Scripture(new Reference("Matthew", 11, 28, 30), "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."),
            new Scripture(new Reference("Helaman", 5, 12), "Remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation."),
            new Scripture(new Reference("Moroni", 10, 3, 5), "Behold, I would exhort you that when ye shall read these things... and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            new Scripture(new Reference("Exodus", 14, 13, 14), "Fear ye not, stand still, and see the salvation of the Lord... The Lord shall fight for you, and ye shall hold your peace."),
            new Scripture(new Reference("Hebrews", 11, 1), "Now faith is the substance of things hoped for, the evidence of things not seen."),
            new Scripture(new Reference("James", 1, 5, 6), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally... But let him ask in faith, nothing wavering."),
            new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God."),
            new Scripture(new Reference("3 Nephi", 12, 14), "Ye are the light of the world. A city that is set on a hill cannot be hid."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Jacob", 2, 18, 19), "But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them for the intent to do good - to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted."),

        };
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
